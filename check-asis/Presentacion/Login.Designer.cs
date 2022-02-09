namespace check_asis.Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel5 = new System.Windows.Forms.Panel();
            this.PanelIngreso_de_contraseña = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelUsuarios = new System.Windows.Forms.Panel();
            this.Icono = new System.Windows.Forms.PictureBox();
            this.PanelIngreso_de_contraseña.SuspendLayout();
            this.PanelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(81, 54);
            this.panel5.TabIndex = 8;
            // 
            // PanelIngreso_de_contraseña
            // 
            this.PanelIngreso_de_contraseña.Controls.Add(this.label2);
            this.PanelIngreso_de_contraseña.Controls.Add(this.btnIniciarSesion);
            this.PanelIngreso_de_contraseña.Controls.Add(this.button1);
            this.PanelIngreso_de_contraseña.Controls.Add(this.txtContraseña);
            this.PanelIngreso_de_contraseña.Controls.Add(this.label1);
            this.PanelIngreso_de_contraseña.Location = new System.Drawing.Point(57, 72);
            this.PanelIngreso_de_contraseña.Name = "PanelIngreso_de_contraseña";
            this.PanelIngreso_de_contraseña.Size = new System.Drawing.Size(379, 344);
            this.PanelIngreso_de_contraseña.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pass : ";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(16, 207);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(151, 49);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cambio de usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(84, 100);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(222, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar sesion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione un usuario";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 103);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 600);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // PanelUsuarios
            // 
            this.PanelUsuarios.Controls.Add(this.flowLayoutPanel1);
            this.PanelUsuarios.Controls.Add(this.label4);
            this.PanelUsuarios.Location = new System.Drawing.Point(409, 69);
            this.PanelUsuarios.Name = "PanelUsuarios";
            this.PanelUsuarios.Size = new System.Drawing.Size(379, 344);
            this.PanelUsuarios.TabIndex = 10;
            this.PanelUsuarios.Visible = false;
            // 
            // Icono
            // 
            this.Icono.Location = new System.Drawing.Point(309, 12);
            this.Icono.Name = "Icono";
            this.Icono.Size = new System.Drawing.Size(30, 29);
            this.Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono.TabIndex = 618;
            this.Icono.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Icono);
            this.Controls.Add(this.PanelUsuarios);
            this.Controls.Add(this.PanelIngreso_de_contraseña);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelIngreso_de_contraseña.ResumeLayout(false);
            this.PanelIngreso_de_contraseña.PerformLayout();
            this.PanelUsuarios.ResumeLayout(false);
            this.PanelUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel PanelIngreso_de_contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelUsuarios;
        private System.Windows.Forms.PictureBox Icono;
    }
}