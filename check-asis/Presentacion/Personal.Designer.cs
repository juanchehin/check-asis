
namespace check_asis.Presentacion
{
    partial class Personal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelRegistros = new System.Windows.Forms.Panel();
            this.PanelCargos = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.btnGuardarCambiosPersonal = new System.Windows.Forms.Button();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.txtIdentifiacion = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSueldoHora = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.PanelPaginado = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelRegistros.SuspendLayout();
            this.PanelCargos.SuspendLayout();
            this.PanelPaginado.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 438);
            this.dataGridView1.TabIndex = 1;
            // 
            // PanelRegistros
            // 
            this.PanelRegistros.Controls.Add(this.PanelCargos);
            this.PanelRegistros.Controls.Add(this.button6);
            this.PanelRegistros.Controls.Add(this.btnGuardarCambiosPersonal);
            this.PanelRegistros.Controls.Add(this.btnGuardarPersonal);
            this.PanelRegistros.Controls.Add(this.btnAgregarCargo);
            this.PanelRegistros.Controls.Add(this.cbxPais);
            this.PanelRegistros.Controls.Add(this.txtIdentifiacion);
            this.PanelRegistros.Controls.Add(this.txtCargo);
            this.PanelRegistros.Controls.Add(this.txtSueldoHora);
            this.PanelRegistros.Controls.Add(this.txtNombres);
            this.PanelRegistros.Controls.Add(this.label5);
            this.PanelRegistros.Controls.Add(this.label4);
            this.PanelRegistros.Controls.Add(this.label3);
            this.PanelRegistros.Controls.Add(this.label2);
            this.PanelRegistros.Controls.Add(this.label1);
            this.PanelRegistros.Location = new System.Drawing.Point(70, 38);
            this.PanelRegistros.Name = "PanelRegistros";
            this.PanelRegistros.Size = new System.Drawing.Size(957, 331);
            this.PanelRegistros.TabIndex = 3;
            // 
            // PanelCargos
            // 
            this.PanelCargos.Controls.Add(this.button11);
            this.PanelCargos.Controls.Add(this.button12);
            this.PanelCargos.Controls.Add(this.textBox7);
            this.PanelCargos.Controls.Add(this.label11);
            this.PanelCargos.Controls.Add(this.textBox5);
            this.PanelCargos.Controls.Add(this.label10);
            this.PanelCargos.Location = new System.Drawing.Point(293, 89);
            this.PanelCargos.Name = "PanelCargos";
            this.PanelCargos.Size = new System.Drawing.Size(445, 150);
            this.PanelCargos.TabIndex = 15;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(220, 118);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 23);
            this.button11.TabIndex = 15;
            this.button11.Text = "Guardar*";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 118);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(93, 23);
            this.button12.TabIndex = 14;
            this.button12.Text = "Guardar";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(140, 66);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(173, 20);
            this.textBox7.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sueldo por hora:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 20);
            this.textBox5.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cargo:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(391, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Volver";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCambiosPersonal
            // 
            this.btnGuardarCambiosPersonal.Location = new System.Drawing.Point(177, 254);
            this.btnGuardarCambiosPersonal.Name = "btnGuardarCambiosPersonal";
            this.btnGuardarCambiosPersonal.Size = new System.Drawing.Size(158, 23);
            this.btnGuardarCambiosPersonal.TabIndex = 13;
            this.btnGuardarCambiosPersonal.Text = "Guardar Cambios";
            this.btnGuardarCambiosPersonal.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.Location = new System.Drawing.Point(58, 254);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(93, 23);
            this.btnGuardarPersonal.TabIndex = 12;
            this.btnGuardarPersonal.Text = "Guardar";
            this.btnGuardarPersonal.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.Location = new System.Drawing.Point(391, 175);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(93, 23);
            this.btnAgregarCargo.TabIndex = 11;
            this.btnAgregarCargo.Text = "Agregar cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            // 
            // cbxPais
            // 
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Items.AddRange(new object[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Ciudad del Vaticano",
            "Colombia",
            "Comoras",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guyana",
            "Guinea",
            "Guinea ecuatorial",
            "Guinea-Bisáu",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macedonia del Norte",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República del Congo",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumanía",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.cbxPais.Location = new System.Drawing.Point(175, 128);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(173, 21);
            this.cbxPais.TabIndex = 10;
            // 
            // txtIdentifiacion
            // 
            this.txtIdentifiacion.Location = new System.Drawing.Point(175, 83);
            this.txtIdentifiacion.Name = "txtIdentifiacion";
            this.txtIdentifiacion.Size = new System.Drawing.Size(173, 20);
            this.txtIdentifiacion.TabIndex = 9;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(175, 175);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(173, 20);
            this.txtCargo.TabIndex = 7;
            // 
            // txtSueldoHora
            // 
            this.txtSueldoHora.Location = new System.Drawing.Point(175, 219);
            this.txtSueldoHora.Name = "txtSueldoHora";
            this.txtSueldoHora.Size = new System.Drawing.Size(173, 20);
            this.txtSueldoHora.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(175, 45);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(173, 20);
            this.txtNombres.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo por hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identificacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido: ";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(346, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 23);
            this.button9.TabIndex = 29;
            this.button9.Text = "Ultima pagina >>";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // PanelPaginado
            // 
            this.PanelPaginado.Controls.Add(this.button7);
            this.PanelPaginado.Controls.Add(this.button8);
            this.PanelPaginado.Controls.Add(this.label6);
            this.PanelPaginado.Controls.Add(this.button9);
            this.PanelPaginado.Controls.Add(this.label7);
            this.PanelPaginado.Controls.Add(this.label8);
            this.PanelPaginado.Controls.Add(this.label9);
            this.PanelPaginado.Controls.Add(this.button10);
            this.PanelPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPaginado.Location = new System.Drawing.Point(0, 440);
            this.PanelPaginado.Name = "PanelPaginado";
            this.PanelPaginado.Size = new System.Drawing.Size(1048, 75);
            this.PanelPaginado.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(148, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 23);
            this.button7.TabIndex = 32;
            this.button7.Text = "Anterior";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(247, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 23);
            this.button8.TabIndex = 33;
            this.button8.Text = "Siguiente";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(639, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Pagina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(703, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(727, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "de";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(760, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "0";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(20, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 23);
            this.button10.TabIndex = 38;
            this.button10.Text = "<< Primera pagina";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btnAgregar);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 77);
            this.panel4.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 26);
            this.textBox1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(760, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(48, 50);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Mostrar todos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelPaginado);
            this.Controls.Add(this.PanelRegistros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1048, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelRegistros.ResumeLayout(false);
            this.PanelRegistros.PerformLayout();
            this.PanelCargos.ResumeLayout(false);
            this.PanelCargos.PerformLayout();
            this.PanelPaginado.ResumeLayout(false);
            this.PanelPaginado.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PanelRegistros;
        private System.Windows.Forms.TextBox txtIdentifiacion;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSueldoHora;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnGuardarCambiosPersonal;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Panel PanelCargos;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel PanelPaginado;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}
