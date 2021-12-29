
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
            this.datalistadoPersonal = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Ultima = new System.Windows.Forms.Button();
            this.PanelPaginado = new System.Windows.Forms.Panel();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_Sig = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Pagina = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_totalPaginas = new System.Windows.Forms.Label();
            this.btn_Primera = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtSueldoHora = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtIdentifiacion = new System.Windows.Forms.TextBox();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.btnGuardarCambiosPersonal = new System.Windows.Forms.Button();
            this.btnVolverPersonal = new System.Windows.Forms.Button();
            this.datalistadoCargos = new System.Windows.Forms.DataGridView();
            this.EditarC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelCargos = new System.Windows.Forms.Panel();
            this.btnVolverCargos = new System.Windows.Forms.Button();
            this.btnGuardarCambiosC = new System.Windows.Forms.Button();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.txtsueldoG = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCargoG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PanelRegistros = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoPersonal)).BeginInit();
            this.PanelPaginado.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoCargos)).BeginInit();
            this.PanelCargos.SuspendLayout();
            this.PanelRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // datalistadoPersonal
            // 
            this.datalistadoPersonal.AllowUserToAddRows = false;
            this.datalistadoPersonal.AllowUserToDeleteRows = false;
            this.datalistadoPersonal.AllowUserToResizeRows = false;
            this.datalistadoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.datalistadoPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistadoPersonal.Location = new System.Drawing.Point(0, 77);
            this.datalistadoPersonal.Name = "datalistadoPersonal";
            this.datalistadoPersonal.ReadOnly = true;
            this.datalistadoPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoPersonal.Size = new System.Drawing.Size(1496, 438);
            this.datalistadoPersonal.TabIndex = 1;
            this.datalistadoPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistadoPersonal_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // btn_Ultima
            // 
            this.btn_Ultima.Location = new System.Drawing.Point(346, 12);
            this.btn_Ultima.Name = "btn_Ultima";
            this.btn_Ultima.Size = new System.Drawing.Size(120, 23);
            this.btn_Ultima.TabIndex = 29;
            this.btn_Ultima.Text = "Ultima pagina >>";
            this.btn_Ultima.UseVisualStyleBackColor = true;
            this.btn_Ultima.Click += new System.EventHandler(this.btn_Ultima_Click);
            // 
            // PanelPaginado
            // 
            this.PanelPaginado.Controls.Add(this.btn_atras);
            this.PanelPaginado.Controls.Add(this.btn_Sig);
            this.PanelPaginado.Controls.Add(this.label6);
            this.PanelPaginado.Controls.Add(this.btn_Ultima);
            this.PanelPaginado.Controls.Add(this.lbl_Pagina);
            this.PanelPaginado.Controls.Add(this.label8);
            this.PanelPaginado.Controls.Add(this.lbl_totalPaginas);
            this.PanelPaginado.Controls.Add(this.btn_Primera);
            this.PanelPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPaginado.Location = new System.Drawing.Point(0, 440);
            this.PanelPaginado.Name = "PanelPaginado";
            this.PanelPaginado.Size = new System.Drawing.Size(1496, 75);
            this.PanelPaginado.TabIndex = 4;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(148, 12);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(93, 23);
            this.btn_atras.TabIndex = 32;
            this.btn_atras.Text = "Anterior";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_Sig
            // 
            this.btn_Sig.Location = new System.Drawing.Point(247, 12);
            this.btn_Sig.Name = "btn_Sig";
            this.btn_Sig.Size = new System.Drawing.Size(93, 23);
            this.btn_Sig.TabIndex = 33;
            this.btn_Sig.Text = "Siguiente";
            this.btn_Sig.UseVisualStyleBackColor = true;
            this.btn_Sig.Click += new System.EventHandler(this.btn_Sig_Click);
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
            // lbl_Pagina
            // 
            this.lbl_Pagina.AutoSize = true;
            this.lbl_Pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pagina.Location = new System.Drawing.Point(703, 15);
            this.lbl_Pagina.Name = "lbl_Pagina";
            this.lbl_Pagina.Size = new System.Drawing.Size(18, 20);
            this.lbl_Pagina.TabIndex = 35;
            this.lbl_Pagina.Text = "0";
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
            // lbl_totalPaginas
            // 
            this.lbl_totalPaginas.AutoSize = true;
            this.lbl_totalPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPaginas.Location = new System.Drawing.Point(760, 15);
            this.lbl_totalPaginas.Name = "lbl_totalPaginas";
            this.lbl_totalPaginas.Size = new System.Drawing.Size(18, 20);
            this.lbl_totalPaginas.TabIndex = 37;
            this.lbl_totalPaginas.Text = "0";
            // 
            // btn_Primera
            // 
            this.btn_Primera.Location = new System.Drawing.Point(20, 12);
            this.btn_Primera.Name = "btn_Primera";
            this.btn_Primera.Size = new System.Drawing.Size(120, 23);
            this.btn_Primera.TabIndex = 38;
            this.btn_Primera.Text = "<< Primera pagina";
            this.btn_Primera.UseVisualStyleBackColor = true;
            this.btn_Primera.Click += new System.EventHandler(this.btn_Primera_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtBuscador);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btnAgregar);
            this.panel4.Controls.Add(this.btnMostrarTodos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1496, 77);
            this.panel4.TabIndex = 5;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(3, 17);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(206, 26);
            this.txtBuscador.TabIndex = 43;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
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
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(325, 17);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(93, 23);
            this.btnMostrarTodos.TabIndex = 46;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
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
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(175, 45);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(173, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // txtSueldoHora
            // 
            this.txtSueldoHora.Location = new System.Drawing.Point(175, 219);
            this.txtSueldoHora.Name = "txtSueldoHora";
            this.txtSueldoHora.Size = new System.Drawing.Size(173, 20);
            this.txtSueldoHora.TabIndex = 5;
            this.txtSueldoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoHora_KeyPress);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(175, 175);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(173, 20);
            this.txtCargo.TabIndex = 4;
            // 
            // txtIdentifiacion
            // 
            this.txtIdentifiacion.Location = new System.Drawing.Point(175, 83);
            this.txtIdentifiacion.Name = "txtIdentifiacion";
            this.txtIdentifiacion.Size = new System.Drawing.Size(173, 20);
            this.txtIdentifiacion.TabIndex = 2;
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
            this.cbxPais.TabIndex = 3;
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.Location = new System.Drawing.Point(391, 175);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(93, 23);
            this.btnAgregarCargo.TabIndex = 11;
            this.btnAgregarCargo.Text = "Agregar cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.Location = new System.Drawing.Point(58, 254);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(93, 23);
            this.btnGuardarPersonal.TabIndex = 6;
            this.btnGuardarPersonal.Text = "Guardar";
            this.btnGuardarPersonal.UseVisualStyleBackColor = true;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.btnGuardarPersonal_Click);
            // 
            // btnGuardarCambiosPersonal
            // 
            this.btnGuardarCambiosPersonal.Location = new System.Drawing.Point(177, 254);
            this.btnGuardarCambiosPersonal.Name = "btnGuardarCambiosPersonal";
            this.btnGuardarCambiosPersonal.Size = new System.Drawing.Size(158, 23);
            this.btnGuardarCambiosPersonal.TabIndex = 13;
            this.btnGuardarCambiosPersonal.Text = "Guardar Cambios";
            this.btnGuardarCambiosPersonal.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosPersonal.Click += new System.EventHandler(this.btnGuardarCambiosPersonal_Click);
            // 
            // btnVolverPersonal
            // 
            this.btnVolverPersonal.Location = new System.Drawing.Point(345, 254);
            this.btnVolverPersonal.Name = "btnVolverPersonal";
            this.btnVolverPersonal.Size = new System.Drawing.Size(93, 23);
            this.btnVolverPersonal.TabIndex = 14;
            this.btnVolverPersonal.Text = "Volver";
            this.btnVolverPersonal.UseVisualStyleBackColor = true;
            this.btnVolverPersonal.Click += new System.EventHandler(this.btnVolverPersonal_Click);
            // 
            // datalistadoCargos
            // 
            this.datalistadoCargos.AllowUserToAddRows = false;
            this.datalistadoCargos.AllowUserToDeleteRows = false;
            this.datalistadoCargos.AllowUserToResizeRows = false;
            this.datalistadoCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarC});
            this.datalistadoCargos.Location = new System.Drawing.Point(402, 219);
            this.datalistadoCargos.Name = "datalistadoCargos";
            this.datalistadoCargos.ReadOnly = true;
            this.datalistadoCargos.Size = new System.Drawing.Size(280, 137);
            this.datalistadoCargos.TabIndex = 16;
            this.datalistadoCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistadoCargos_CellClick);
            // 
            // EditarC
            // 
            this.EditarC.HeaderText = "Editar";
            this.EditarC.Name = "EditarC";
            this.EditarC.ReadOnly = true;
            this.EditarC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditarC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PanelCargos
            // 
            this.PanelCargos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCargos.Controls.Add(this.btnVolverCargos);
            this.PanelCargos.Controls.Add(this.btnGuardarCambiosC);
            this.PanelCargos.Controls.Add(this.btnGuardarC);
            this.PanelCargos.Controls.Add(this.txtsueldoG);
            this.PanelCargos.Controls.Add(this.label11);
            this.PanelCargos.Controls.Add(this.txtCargoG);
            this.PanelCargos.Controls.Add(this.label10);
            this.PanelCargos.Location = new System.Drawing.Point(521, 63);
            this.PanelCargos.Name = "PanelCargos";
            this.PanelCargos.Size = new System.Drawing.Size(445, 150);
            this.PanelCargos.TabIndex = 15;
            // 
            // btnVolverCargos
            // 
            this.btnVolverCargos.Location = new System.Drawing.Point(6, 118);
            this.btnVolverCargos.Name = "btnVolverCargos";
            this.btnVolverCargos.Size = new System.Drawing.Size(75, 23);
            this.btnVolverCargos.TabIndex = 16;
            this.btnVolverCargos.Text = "Volver";
            this.btnVolverCargos.UseVisualStyleBackColor = true;
            this.btnVolverCargos.Click += new System.EventHandler(this.btnVolverCargos_Click);
            // 
            // btnGuardarCambiosC
            // 
            this.btnGuardarCambiosC.Location = new System.Drawing.Point(220, 118);
            this.btnGuardarCambiosC.Name = "btnGuardarCambiosC";
            this.btnGuardarCambiosC.Size = new System.Drawing.Size(137, 23);
            this.btnGuardarCambiosC.TabIndex = 15;
            this.btnGuardarCambiosC.Text = "Guardar cambios";
            this.btnGuardarCambiosC.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosC.Click += new System.EventHandler(this.btnGuardarCambiosC_Click);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Location = new System.Drawing.Point(121, 118);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(93, 23);
            this.btnGuardarC.TabIndex = 14;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // txtsueldoG
            // 
            this.txtsueldoG.Location = new System.Drawing.Point(140, 66);
            this.txtsueldoG.Name = "txtsueldoG";
            this.txtsueldoG.Size = new System.Drawing.Size(173, 20);
            this.txtsueldoG.TabIndex = 9;
            this.txtsueldoG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsueldoG_KeyPress);
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
            // txtCargoG
            // 
            this.txtCargoG.Location = new System.Drawing.Point(140, 19);
            this.txtCargoG.Name = "txtCargoG";
            this.txtCargoG.Size = new System.Drawing.Size(173, 20);
            this.txtCargoG.TabIndex = 7;
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
            // PanelRegistros
            // 
            this.PanelRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRegistros.Controls.Add(this.PanelCargos);
            this.PanelRegistros.Controls.Add(this.datalistadoCargos);
            this.PanelRegistros.Controls.Add(this.btnVolverPersonal);
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
            this.PanelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRegistros.Location = new System.Drawing.Point(0, 77);
            this.PanelRegistros.Name = "PanelRegistros";
            this.PanelRegistros.Size = new System.Drawing.Size(1496, 363);
            this.PanelRegistros.TabIndex = 3;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelRegistros);
            this.Controls.Add(this.PanelPaginado);
            this.Controls.Add(this.datalistadoPersonal);
            this.Controls.Add(this.panel4);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1496, 515);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoPersonal)).EndInit();
            this.PanelPaginado.ResumeLayout(false);
            this.PanelPaginado.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoCargos)).EndInit();
            this.PanelCargos.ResumeLayout(false);
            this.PanelCargos.PerformLayout();
            this.PanelRegistros.ResumeLayout(false);
            this.PanelRegistros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView datalistadoPersonal;
        private System.Windows.Forms.Button btn_Ultima;
        private System.Windows.Forms.Panel PanelPaginado;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_Sig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Pagina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_totalPaginas;
        private System.Windows.Forms.Button btn_Primera;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtSueldoHora;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtIdentifiacion;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.Button btnGuardarCambiosPersonal;
        private System.Windows.Forms.Button btnVolverPersonal;
        private System.Windows.Forms.DataGridView datalistadoCargos;
        private System.Windows.Forms.DataGridViewButtonColumn EditarC;
        private System.Windows.Forms.Panel PanelCargos;
        private System.Windows.Forms.Button btnVolverCargos;
        private System.Windows.Forms.Button btnGuardarCambiosC;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.TextBox txtsueldoG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCargoG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PanelRegistros;
    }
}
