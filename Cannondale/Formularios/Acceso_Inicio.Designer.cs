
namespace Cannondale
{
    partial class Form_Acceso_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Acceso_Inicio));
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPass = new System.Windows.Forms.Label();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.BotonIniciarSesion = new System.Windows.Forms.Button();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.PictureBoxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.Location = new System.Drawing.Point(12, 131);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(104, 35);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Usuario:";
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPass.Location = new System.Drawing.Point(390, 131);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(143, 35);
            this.LabelPass.TabIndex = 1;
            this.LabelPass.Text = "Contraseña:";
            this.LabelPass.Click += new System.EventHandler(this.LabelPass_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BotonCerrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BotonCerrar.Location = new System.Drawing.Point(466, 185);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(172, 42);
            this.BotonCerrar.TabIndex = 3;
            this.BotonCerrar.Text = "Cerrar Aplicación";
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // BotonIniciarSesion
            // 
            this.BotonIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIniciarSesion.Location = new System.Drawing.Point(188, 185);
            this.BotonIniciarSesion.Name = "BotonIniciarSesion";
            this.BotonIniciarSesion.Size = new System.Drawing.Size(166, 42);
            this.BotonIniciarSesion.TabIndex = 4;
            this.BotonIniciarSesion.Text = "Iniciar Sesión";
            this.BotonIniciarSesion.UseVisualStyleBackColor = true;
            this.BotonIniciarSesion.Click += new System.EventHandler(this.BotonIniciarSesion_Click);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLogin.Location = new System.Drawing.Point(100, 128);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(267, 34);
            this.TextBoxLogin.TabIndex = 5;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(506, 128);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(267, 34);
            this.TextBoxPassword.TabIndex = 6;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // PictureBoxLogin
            // 
            this.PictureBoxLogin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogin.ErrorImage")));
            this.PictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogin.Image")));
            this.PictureBoxLogin.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogin.InitialImage")));
            this.PictureBoxLogin.Location = new System.Drawing.Point(188, 12);
            this.PictureBoxLogin.Name = "PictureBoxLogin";
            this.PictureBoxLogin.Size = new System.Drawing.Size(461, 72);
            this.PictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogin.TabIndex = 2;
            this.PictureBoxLogin.TabStop = false;
            // 
            // Form_Acceso_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 261);
            this.ControlBox = false;
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.BotonIniciarSesion);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.PictureBoxLogin);
            this.Controls.Add(this.LabelPass);
            this.Controls.Add(this.LabelLogin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Acceso_Inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cannondale Ventas 1.0";
            this.Load += new System.EventHandler(this.Acceso_Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Button BotonIniciarSesion;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        public System.Windows.Forms.PictureBox PictureBoxLogin;
    }
}