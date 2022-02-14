namespace check_asis.Presentacion.asistente_instalacion
{
    partial class InstalacionBD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstalacionBD));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.txtCrearUsuarioDb = new System.Windows.Forms.TextBox();
            this.txtArgumentosini = new System.Windows.Forms.RichTextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEliminarBase = new System.Windows.Forms.RichTextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCrear_procedimientos = new System.Windows.Forms.RichTextBox();
            this.txtnombre_scrypt = new System.Windows.Forms.TextBox();
            this.TXTbasededatos = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblnombredeservicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerCRARINI = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panelCargando = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtservidor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.panelCargando.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(288, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 177);
            this.panel5.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Instalacion del servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "No cierre esta ventana, se cerrara automaticamente";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 323);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GroupBox6);
            this.panel1.Controls.Add(this.txtArgumentosini);
            this.panel1.Controls.Add(this.GroupBox1);
            this.panel1.Controls.Add(this.GroupBox2);
            this.panel1.Controls.Add(this.txtnombre_scrypt);
            this.panel1.Controls.Add(this.TXTbasededatos);
            this.panel1.Controls.Add(this.lblcontraseña);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.lblnombredeservicio);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 732);
            this.panel1.TabIndex = 14;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.txtCrearUsuarioDb);
            this.GroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.ForeColor = System.Drawing.Color.Black;
            this.GroupBox6.Location = new System.Drawing.Point(492, 180);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(233, 304);
            this.GroupBox6.TabIndex = 633;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Servira para Crear un Usuario para el Servidor - NO TOCAR";
            // 
            // txtCrearUsuarioDb
            // 
            this.txtCrearUsuarioDb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCrearUsuarioDb.Location = new System.Drawing.Point(3, 39);
            this.txtCrearUsuarioDb.Multiline = true;
            this.txtCrearUsuarioDb.Name = "txtCrearUsuarioDb";
            this.txtCrearUsuarioDb.Size = new System.Drawing.Size(227, 262);
            this.txtCrearUsuarioDb.TabIndex = 629;
            this.txtCrearUsuarioDb.Text = resources.GetString("txtCrearUsuarioDb.Text");
            // 
            // txtArgumentosini
            // 
            this.txtArgumentosini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArgumentosini.Location = new System.Drawing.Point(12, 369);
            this.txtArgumentosini.Name = "txtArgumentosini";
            this.txtArgumentosini.Size = new System.Drawing.Size(446, 216);
            this.txtArgumentosini.TabIndex = 590;
            this.txtArgumentosini.Text = resources.GetString("txtArgumentosini.Text");
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtEliminarBase);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(503, 14);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(316, 154);
            this.GroupBox1.TabIndex = 624;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Script para Eliminar la base de datos";
            // 
            // txtEliminarBase
            // 
            this.txtEliminarBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEliminarBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminarBase.Location = new System.Drawing.Point(3, 16);
            this.txtEliminarBase.Name = "txtEliminarBase";
            this.txtEliminarBase.Size = new System.Drawing.Size(310, 135);
            this.txtEliminarBase.TabIndex = 589;
            this.txtEliminarBase.Text = "alter database check set single_user with rollback immediate \nDROP DATABASE check" +
    "";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtCrear_procedimientos);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.GroupBox2.Location = new System.Drawing.Point(6, 180);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(446, 183);
            this.GroupBox2.TabIndex = 623;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Pega tu Script para Crear las Tablas y Procedimientos";
            // 
            // txtCrear_procedimientos
            // 
            this.txtCrear_procedimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrear_procedimientos.Location = new System.Drawing.Point(6, 32);
            this.txtCrear_procedimientos.Name = "txtCrear_procedimientos";
            this.txtCrear_procedimientos.Size = new System.Drawing.Size(434, 145);
            this.txtCrear_procedimientos.TabIndex = 589;
            this.txtCrear_procedimientos.Text = resources.GetString("txtCrear_procedimientos.Text");
            // 
            // txtnombre_scrypt
            // 
            this.txtnombre_scrypt.Location = new System.Drawing.Point(134, 132);
            this.txtnombre_scrypt.Name = "txtnombre_scrypt";
            this.txtnombre_scrypt.Size = new System.Drawing.Size(100, 20);
            this.txtnombre_scrypt.TabIndex = 9;
            // 
            // TXTbasededatos
            // 
            this.TXTbasededatos.Location = new System.Drawing.Point(134, 103);
            this.TXTbasededatos.Name = "TXTbasededatos";
            this.TXTbasededatos.Size = new System.Drawing.Size(100, 20);
            this.TXTbasededatos.TabIndex = 8;
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.Location = new System.Drawing.Point(134, 71);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(100, 20);
            this.lblcontraseña.TabIndex = 7;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(134, 42);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 6;
            // 
            // lblnombredeservicio
            // 
            this.lblnombredeservicio.Location = new System.Drawing.Point(134, 14);
            this.lblnombredeservicio.Name = "lblnombredeservicio";
            this.lblnombredeservicio.Size = new System.Drawing.Size(100, 20);
            this.lblnombredeservicio.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre del script : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Base de datos : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contraseña :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Usuario :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre de la instancia : ";
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // panelCargando
            // 
            this.panelCargando.Controls.Add(this.label8);
            this.panelCargando.Location = new System.Drawing.Point(18, 28);
            this.panelCargando.Name = "panelCargando";
            this.panelCargando.Size = new System.Drawing.Size(351, 151);
            this.panelCargando.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Instalando servidor...";
            // 
            // txtservidor
            // 
            this.txtservidor.AutoSize = true;
            this.txtservidor.ForeColor = System.Drawing.Color.White;
            this.txtservidor.Location = new System.Drawing.Point(640, 273);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(16, 13);
            this.txtservidor.TabIndex = 612;
            this.txtservidor.Text = "---";
            // 
            // InstalacionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 749);
            this.Controls.Add(this.txtservidor);
            this.Controls.Add(this.panelCargando);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstalacionBD";
            this.Text = "Instalacion de la base de datos";
            this.Load += new System.EventHandler(this.InstalacionBD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.panelCargando.ResumeLayout(false);
            this.panelCargando.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.RichTextBox txtArgumentosini;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RichTextBox txtEliminarBase;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RichTextBox txtCrear_procedimientos;
        private System.Windows.Forms.TextBox txtnombre_scrypt;
        private System.Windows.Forms.TextBox TXTbasededatos;
        private System.Windows.Forms.TextBox lblcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox lblnombredeservicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerCRARINI;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.TextBox txtCrearUsuarioDb;
        private System.Windows.Forms.Panel panelCargando;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label txtservidor;
    }
}