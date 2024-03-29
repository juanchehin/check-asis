﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using check_asis.Datos;
using check_asis.Logica;

namespace check_asis.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
            MostrarPersonal();
            PanelRegistros.Visible = false;
        }
        int Idcargo = 0;
        int desde = 1;
        int hasta = 10;
        int Contador;
        int Idpersonal;
        private int items_por_pagina = 10;
        string Estado;
        int totalPaginas;

        string sueldo;
        string cargo;


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // LocalizarDtvCargos();
            PanelCargos.Visible = false;
            PanelPaginado.Visible = false;
            PanelRegistros.Visible = true;
            PanelRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombres.Clear();
            txtIdentifiacion.Clear();
            txtCargo.Clear();
            txtSueldoHora.Clear();
            BuscarCargos();
        }
        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombres.Text))
            {
                if (!string.IsNullOrEmpty(txtIdentifiacion.Text))
                {
                    if (!string.IsNullOrEmpty(cbxPais.Text))
                    {
                        if (Idcargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldoHora.Text))
                            {
                                Insertar_Personal();
                            }
                        }
                    }
                }


            }
        }

        private void Insertar_Personal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Nombres = txtNombres.Text;
            parametros.Identificacion = txtIdentifiacion.Text;
            parametros.Pais = cbxPais.Text;
            parametros.Id_cargo = Idcargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);

            if (funcion.InsertarPersonal(parametros) == true)
            {
                ReiniciarPaginado();
                MostrarPersonal();
                PanelRegistros.Visible = false;

            }

        }

        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.MostrarPersonal(ref dt, desde, hasta);
            datalistadoPersonal.DataSource = dt;
            DiseñarDtvPersonal();
        }
        private void DiseñarDtvPersonal()
        {
            Bases.DiseñoDtv(ref datalistadoPersonal);
            Bases.DiseñoDtvEliminar(ref datalistadoPersonal);
            PanelPaginado.Visible = true;
            datalistadoPersonal.Columns[2].Visible = false;
            datalistadoPersonal.Columns[7].Visible = false;
        }

        private void InsertarCargos()
        {
            if (!string.IsNullOrEmpty(txtCargoG.Text))
            {
                if (!string.IsNullOrEmpty(txtsueldoG.Text))
                {
                    Lcargos parametros = new Lcargos();
                    Dcargos funcion = new Dcargos();
                    parametros.Cargo = txtCargoG.Text;
                    parametros.SueldoPorHora = Convert.ToDouble(txtsueldoG.Text);
                    if (funcion.insertar_Cargo(parametros) == true)
                    {
                        txtCargo.Clear();
                        BuscarCargos();
                        PanelCargos.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Agrege el Sueldo", "Falta el Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Agrege el cargo", "Falta el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        /* Carga el listado de cargos en el data grid view */
        private void BuscarCargos()
        {
            DataTable dt = new DataTable();
            Dcargos funcion = new Dcargos();

            funcion.buscarCargos(ref dt, txtCargo.Text);            
            datalistadoCargos.DataSource = dt;
            Bases.DiseñoDtv(ref datalistadoCargos);

            // datalistadoCargos.Columns[1].Visible = false;
            // datalistadoCargos.Columns[3].Visible = false;

            datalistadoCargos.Visible = true;
        }
        private void ReiniciarPaginado()
        {
            desde = 1;
            hasta = 10;
            Contar();

            if (Contador > hasta)
            {
                btn_Sig.Enabled = true;
                btn_atras.Enabled = false;
                btn_Ultima.Enabled = true;
                btn_Primera.Enabled = true;

                /*btn_Sig.Visible = true;
                btn_atras.Visible = false;
                btn_Ultima.Visible = true;
                btn_Primera.Visible = true;*/
            }
            else
            {
                btn_Sig.Enabled = false;
                btn_atras.Enabled = false;
                btn_Ultima.Enabled = false;
                btn_Primera.Enabled = false;

                /* btn_Sig.Visible = false;
                btn_atras.Visible = false;
                btn_Ultima.Visible = false;
                btn_Primera.Visible = false;*/
            }
            Paginar();
        }
       
        private void Contar()
        {
            Dpersonal funcion = new Dpersonal();
            funcion.ContarPersonal(ref Contador);
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
            btnGuardarC.Visible = true;
            btnGuardarCambiosC.Visible = false;
            txtCargoG.Clear();
            txtsueldoG.Clear();
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            InsertarCargos();
        }

        private void txtsueldoG_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtsueldoG, e);
        }

        private void txtSueldoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoHora, e);
        }

        private void datalistadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selecciono columna "Editar Cargo"
            if (e.ColumnIndex == datalistadoCargos.Columns["EditarC"].Index)
            {
                if (datalistadoCargos.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Idcargo = Convert.ToInt32(datalistadoCargos.Rows[e.RowIndex].Cells[1].Value.ToString());

                    cargo = datalistadoCargos.Rows[e.RowIndex].Cells[2].Value.ToString();
                    sueldo = datalistadoCargos.Rows[e.RowIndex].Cells[3].Value.ToString();

                    ObtenerCargosEditar(Idcargo, cargo,sueldo);
                }
            }
            // Selecciono columna "Cargo" para cargar en el txtCargo
            if (e.ColumnIndex == datalistadoCargos.Columns["Cargo"].Index)
            {
                    if (datalistadoCargos.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        Idcargo = Convert.ToInt32(datalistadoCargos.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cargo = datalistadoCargos.Rows[e.RowIndex].Cells[2].Value.ToString();
                        sueldo = datalistadoCargos.Rows[e.RowIndex].Cells[3].Value.ToString();

                        ObtenerDatosCargos(Idcargo, cargo, sueldo);
                    }
            }
        }
        private void ObtenerDatosCargos(int Idcargo, string cargo, string sueldo)
        {
            // Idcargo = Idcargo;
            txtCargo.Text = cargo;
            txtSueldoHora.Text = sueldo;
            //datalistadoCargos.Visible = false;
            // PanelBtnguardarPer.Visible = true;
            // lblsueldo.Visible = true;
        }
        private void ObtenerCargosEditar(int Idcargo,string cargo,string sueldo)
        {
            txtCargoG.Text = cargo;
            txtsueldoG.Text = sueldo;

            btnGuardarC.Visible = false;
            btnGuardarCambiosC.Visible = true;
            txtCargoG.Focus();
            txtCargoG.SelectAll();
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
        }

        private void btnVolverCargos_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = false;
        }

        private void btnGuardarCambiosC_Click(object sender, EventArgs e)
        {
            EditarCargos();
        }
        private void EditarCargos()
        {
            Lcargos parametros = new Lcargos();
            Dcargos funcion = new Dcargos();
            parametros.Id_cargo = Idcargo;
            parametros.Cargo = txtCargoG.Text;
            parametros.SueldoPorHora = Convert.ToDouble(txtsueldoG.Text);
            if (funcion.editar_Cargo(parametros) == true)
            {
                txtCargo.Clear();
                BuscarCargos();
                PanelCargos.Visible = false;
            }
        }

        private void datalistadoPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadoPersonal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Solo se Cambiara el Estado para que no pueda acceder, Desea Continuar?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarPersonal();
                }

            }
            if (e.ColumnIndex == datalistadoPersonal.Columns["Editar"].Index)
            {
                ObtenerDatos();
            }
        }

        private void EliminarPersonal()
        {
            Idpersonal = Convert.ToInt32(datalistadoPersonal.SelectedCells[2].Value);
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            if (funcion.eliminarPersonal(parametros) == true)
            {
                MostrarPersonal();
            }
        }

        private void ObtenerDatos()
        {

            Idpersonal = Convert.ToInt32(datalistadoPersonal.SelectedCells[2].Value);
            Estado = datalistadoPersonal.SelectedCells[8].Value.ToString();
            if (Estado == "ELIMINADO")
            {
                restaurar_personal();
            }
            else
            {
                LocalizarDtvCargos();
                txtNombres.Text = datalistadoPersonal.SelectedCells[3].Value.ToString();
                txtIdentifiacion.Text = datalistadoPersonal.SelectedCells[4].Value.ToString();
                cbxPais.Text = datalistadoPersonal.SelectedCells[10].Value.ToString();
                txtCargo.Text = datalistadoPersonal.SelectedCells[6].Value.ToString();
                Idcargo = Convert.ToInt32(datalistadoPersonal.SelectedCells[7].Value);
                txtSueldoHora.Text = datalistadoPersonal.SelectedCells[5].Value.ToString();
                PanelPaginado.Visible = false;
                PanelRegistros.Visible = true;
                PanelRegistros.Dock = DockStyle.Fill;
                // datalistadoCargos.Visible = false;
                // lblsueldo.Visible = true;
                // PanelBtnguardarPer.Visible = true;
                btnGuardarPersonal.Visible = false;
                btnGuardarCambiosPersonal.Visible = true;
                PanelCargos.Visible = false;
            }
        }
        private void restaurar_personal()
        {
            DialogResult result = MessageBox.Show("Este Personal se Elimino. ¿Desea Volver a Habilitarlo?", "Restauracion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HabilitarPersonal();
            }

        }
        
        /* Posiciona el Data Grid view de 'cargos' en un lugar en la pantalla */
        private void LocalizarDtvCargos()
        {
            //    datalistadoCargos.Location = new Point(txtSueldoHora.Location.X, txtSueldoHora.Location.Y);
            //    datalistadoCargos.Size = new Size(469, 141);
            datalistadoCargos.Visible = true;
            BuscarCargos();
            Limpiar();
            // lblsueldo.Visible = false;
            // PanelBtnguardarPer.Visible = false;
        }
        private void HabilitarPersonal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            if (funcion.restaurar_personal(parametros) == true)
            {
                MostrarPersonal();
            }

        }

        private void EditarPersonal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();

            parametros.Id_personal = Idpersonal;
            parametros.Nombres = txtNombres.Text;
            parametros.Identificacion = txtIdentifiacion.Text;
            parametros.Pais = cbxPais.Text;
            parametros.Id_cargo = Idcargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);

            if (funcion.editarPersonal(parametros) == true)
            {
                MostrarPersonal();
                PanelRegistros.Visible = false;
            }
        }

        private void btnGuardarCambiosPersonal_Click(object sender, EventArgs e)
        {
            EditarPersonal();
        }

        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {
            PanelRegistros.Visible = false;
            PanelPaginado.Visible = true;
        }

        private void btn_Sig_Click(object sender, EventArgs e)
        {
            desde += 10;
            hasta += 10;
            MostrarPersonal();
            Contar();
            if (Contador > hasta)
            {
                btn_Sig.Enabled = true;
                btn_atras.Enabled = true;

                /*btn_Sig.Visible = true;
                btn_atras.Visible = true;*/
            }
            else
            {
                btn_Sig.Enabled = false;
                btn_atras.Enabled = true;

                /*btn_Sig.Visible = false;
                btn_atras.Visible = true;*/
            }
            Paginar();
        }
        private void Paginar()
        {
            try
            {
                lbl_Pagina.Text = (hasta / items_por_pagina).ToString();
                lbl_totalPaginas.Text = Math.Ceiling(Convert.ToSingle(Contador) / items_por_pagina).ToString();
                totalPaginas = Convert.ToInt32(lbl_totalPaginas.Text);
            }
            catch (Exception)
            {

            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            desde -= 10;
            hasta -= 10;
            MostrarPersonal();
            Contar();

            if (Contador > hasta)
            {
                btn_Sig.Enabled = true;
                btn_atras.Enabled = true;

                /*btn_Sig.Visible = true;
                btn_atras.Visible = true;*/
            }
            else
            {
                btn_Sig.Enabled = false;
                btn_atras.Enabled = true;

                /*btn_Sig.Visible = false;
                btn_atras.Visible = true;*/
            }
            if (desde == 1)
            {
                ReiniciarPaginado();
            }
            Paginar();
        }

        private void btn_Ultima_Click(object sender, EventArgs e)
        {
            hasta = totalPaginas * items_por_pagina;
            desde = hasta - 9;
            MostrarPersonal();
            Contar();
            if (Contador > hasta)
            {
                btn_Sig.Enabled = true;
                btn_atras.Enabled = true;

                /*btn_Sig.Visible = true;
                btn_atras.Visible = true;*/
            }
            else
            {
                btn_Sig.Enabled = false;
                btn_atras.Enabled = true;

                /*btn_Sig.Visible = false;
                btn_atras.Visible = true;*/
            }
            Paginar();
        }

        private void btn_Primera_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonal();
        }
        private void BuscarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.BuscarPersonal(ref dt, desde, hasta,txtBuscador.Text);
            datalistadoPersonal.DataSource = dt;
            DiseñarDtvPersonal();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }
    }
}
