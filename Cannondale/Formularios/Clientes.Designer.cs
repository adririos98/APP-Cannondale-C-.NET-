
namespace Cannondale
{
    partial class Clientes
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
            this.TextBoxDNI = new System.Windows.Forms.TextBox();
            this.BotonInsertarCliente = new System.Windows.Forms.Button();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.LabelDNI = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.LabelApellido1 = new System.Windows.Forms.Label();
            this.TextBoxApellido1 = new System.Windows.Forms.TextBox();
            this.LabelApellido2 = new System.Windows.Forms.Label();
            this.TextBoxApellido2 = new System.Windows.Forms.TextBox();
            this.LabelDireccion = new System.Windows.Forms.Label();
            this.TextBoxDireccion = new System.Windows.Forms.TextBox();
            this.TextBoxTelefono = new System.Windows.Forms.TextBox();
            this.LabelTelefono = new System.Windows.Forms.Label();
            this.LabelCorreo = new System.Windows.Forms.Label();
            this.TextBoxMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxDNI
            // 
            this.TextBoxDNI.Location = new System.Drawing.Point(36, 44);
            this.TextBoxDNI.Name = "TextBoxDNI";
            this.TextBoxDNI.Size = new System.Drawing.Size(120, 34);
            this.TextBoxDNI.TabIndex = 0;
            // 
            // BotonInsertarCliente
            // 
            this.BotonInsertarCliente.Location = new System.Drawing.Point(225, 272);
            this.BotonInsertarCliente.Name = "BotonInsertarCliente";
            this.BotonInsertarCliente.Size = new System.Drawing.Size(96, 35);
            this.BotonInsertarCliente.TabIndex = 1;
            this.BotonInsertarCliente.Text = "Añadir";
            this.BotonInsertarCliente.UseVisualStyleBackColor = true;
            this.BotonInsertarCliente.Click += new System.EventHandler(this.BotonInsertarCliente_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(425, 272);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(97, 35);
            this.BotonCerrar.TabIndex = 2;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // LabelDNI
            // 
            this.LabelDNI.AutoSize = true;
            this.LabelDNI.Location = new System.Drawing.Point(31, 13);
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(63, 35);
            this.LabelDNI.TabIndex = 3;
            this.LabelDNI.Text = "DNI:";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(177, 13);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(111, 35);
            this.LabelNombre.TabIndex = 5;
            this.LabelNombre.Text = "Nombre:";
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(182, 44);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(120, 34);
            this.TextBoxNombre.TabIndex = 4;
            // 
            // LabelApellido1
            // 
            this.LabelApellido1.AutoSize = true;
            this.LabelApellido1.Location = new System.Drawing.Point(317, 13);
            this.LabelApellido1.Name = "LabelApellido1";
            this.LabelApellido1.Size = new System.Drawing.Size(133, 35);
            this.LabelApellido1.TabIndex = 7;
            this.LabelApellido1.Text = "1ºApellido";
            // 
            // TextBoxApellido1
            // 
            this.TextBoxApellido1.Location = new System.Drawing.Point(322, 44);
            this.TextBoxApellido1.Name = "TextBoxApellido1";
            this.TextBoxApellido1.Size = new System.Drawing.Size(210, 34);
            this.TextBoxApellido1.TabIndex = 6;
            // 
            // LabelApellido2
            // 
            this.LabelApellido2.AutoSize = true;
            this.LabelApellido2.Location = new System.Drawing.Point(317, 81);
            this.LabelApellido2.Name = "LabelApellido2";
            this.LabelApellido2.Size = new System.Drawing.Size(106, 28);
            this.LabelApellido2.TabIndex = 9;
            this.LabelApellido2.Text = "2ºApellido";
            // 
            // TextBoxApellido2
            // 
            this.TextBoxApellido2.Location = new System.Drawing.Point(322, 112);
            this.TextBoxApellido2.Name = "TextBoxApellido2";
            this.TextBoxApellido2.Size = new System.Drawing.Size(210, 34);
            this.TextBoxApellido2.TabIndex = 8;
            // 
            // LabelDireccion
            // 
            this.LabelDireccion.AutoSize = true;
            this.LabelDireccion.Location = new System.Drawing.Point(32, 160);
            this.LabelDireccion.Name = "LabelDireccion";
            this.LabelDireccion.Size = new System.Drawing.Size(183, 35);
            this.LabelDireccion.TabIndex = 11;
            this.LabelDireccion.Text = "Dirección física:";
            // 
            // TextBoxDireccion
            // 
            this.TextBoxDireccion.Location = new System.Drawing.Point(177, 160);
            this.TextBoxDireccion.Name = "TextBoxDireccion";
            this.TextBoxDireccion.Size = new System.Drawing.Size(355, 34);
            this.TextBoxDireccion.TabIndex = 10;
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.Location = new System.Drawing.Point(37, 112);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.Size = new System.Drawing.Size(198, 34);
            this.TextBoxTelefono.TabIndex = 12;
            // 
            // LabelTelefono
            // 
            this.LabelTelefono.AutoSize = true;
            this.LabelTelefono.Location = new System.Drawing.Point(32, 81);
            this.LabelTelefono.Name = "LabelTelefono";
            this.LabelTelefono.Size = new System.Drawing.Size(113, 35);
            this.LabelTelefono.TabIndex = 13;
            this.LabelTelefono.Text = "Teléfono:";
            // 
            // LabelCorreo
            // 
            this.LabelCorreo.AutoSize = true;
            this.LabelCorreo.Location = new System.Drawing.Point(32, 212);
            this.LabelCorreo.Name = "LabelCorreo";
            this.LabelCorreo.Size = new System.Drawing.Size(234, 35);
            this.LabelCorreo.TabIndex = 15;
            this.LabelCorreo.Text = "Dirección de correo:";
            // 
            // TextBoxMail
            // 
            this.TextBoxMail.Location = new System.Drawing.Point(214, 209);
            this.TextBoxMail.Name = "TextBoxMail";
            this.TextBoxMail.Size = new System.Drawing.Size(318, 34);
            this.TextBoxMail.TabIndex = 14;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(564, 332);
            this.Controls.Add(this.TextBoxMail);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.TextBoxDireccion);
            this.Controls.Add(this.LabelApellido2);
            this.Controls.Add(this.TextBoxApellido2);
            this.Controls.Add(this.TextBoxApellido1);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.BotonInsertarCliente);
            this.Controls.Add(this.TextBoxDNI);
            this.Controls.Add(this.LabelCorreo);
            this.Controls.Add(this.LabelDireccion);
            this.Controls.Add(this.LabelTelefono);
            this.Controls.Add(this.LabelApellido1);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelDNI);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxDNI;
        private System.Windows.Forms.Button BotonInsertarCliente;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Label LabelDNI;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Label LabelApellido1;
        private System.Windows.Forms.TextBox TextBoxApellido1;
        private System.Windows.Forms.Label LabelApellido2;
        private System.Windows.Forms.TextBox TextBoxApellido2;
        private System.Windows.Forms.Label LabelDireccion;
        private System.Windows.Forms.TextBox TextBoxDireccion;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.Label LabelTelefono;
        private System.Windows.Forms.Label LabelCorreo;
        private System.Windows.Forms.TextBox TextBoxMail;
    }
}