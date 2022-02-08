namespace check_asis.Presentacion.asistente_instalacion
{
    partial class UsuarioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Icono = new System.Windows.Forms.PictureBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.TXTCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.txtconfirmarcontraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creacion del usuario principal (admin)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del usuario :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmar Contraseña : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "El administrador siempre tendra acceso a todas las funciones del programa";
            // 
            // Icono
            // 
            this.Icono.Image = ((System.Drawing.Image)(resources.GetObject("Icono.Image")));
            this.Icono.Location = new System.Drawing.Point(305, 300);
            this.Icono.Name = "Icono";
            this.Icono.Size = new System.Drawing.Size(163, 117);
            this.Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono.TabIndex = 6;
            this.Icono.TabStop = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(213, 95);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(179, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Location = new System.Drawing.Point(213, 130);
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(179, 20);
            this.TXTUSUARIO.TabIndex = 8;
            // 
            // TXTCONTRASEÑA
            // 
            this.TXTCONTRASEÑA.Location = new System.Drawing.Point(213, 165);
            this.TXTCONTRASEÑA.Name = "TXTCONTRASEÑA";
            this.TXTCONTRASEÑA.PasswordChar = '*';
            this.TXTCONTRASEÑA.Size = new System.Drawing.Size(179, 20);
            this.TXTCONTRASEÑA.TabIndex = 9;
            // 
            // txtconfirmarcontraseña
            // 
            this.txtconfirmarcontraseña.Location = new System.Drawing.Point(213, 201);
            this.txtconfirmarcontraseña.Name = "txtconfirmarcontraseña";
            this.txtconfirmarcontraseña.PasswordChar = '*';
            this.txtconfirmarcontraseña.Size = new System.Drawing.Size(179, 20);
            this.txtconfirmarcontraseña.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingrese hasta 6 numeros";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(687, 406);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(101, 32);
            this.btnSiguiente.TabIndex = 12;
            this.btnSiguiente.Text = "Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // UsuarioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtconfirmarcontraseña);
            this.Controls.Add(this.TXTCONTRASEÑA);
            this.Controls.Add(this.TXTUSUARIO);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.Icono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuarioPrincipal";
            this.Text = "UsuarioPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Icono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.TextBox TXTCONTRASEÑA;
        private System.Windows.Forms.TextBox txtconfirmarcontraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSiguiente;
    }
}