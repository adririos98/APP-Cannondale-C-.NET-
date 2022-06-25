
namespace Cannondale
{
    partial class Buscar_Clientes
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
            this.LabelDNI = new System.Windows.Forms.Label();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.BotonBuscarCliente = new System.Windows.Forms.Button();
            this.TextBoxDNI = new System.Windows.Forms.TextBox();
            this.BotonAñadir = new System.Windows.Forms.Button();
            this.LabelResultadoBusqueda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelDNI
            // 
            this.LabelDNI.AutoSize = true;
            this.LabelDNI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDNI.Location = new System.Drawing.Point(3, 21);
            this.LabelDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(141, 28);
            this.LabelDNI.TabIndex = 19;
            this.LabelDNI.Text = "Introducir DNI:";
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrar.Location = new System.Drawing.Point(590, 130);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(121, 36);
            this.BotonCerrar.TabIndex = 18;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // BotonBuscarCliente
            // 
            this.BotonBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscarCliente.Location = new System.Drawing.Point(472, 15);
            this.BotonBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BotonBuscarCliente.Name = "BotonBuscarCliente";
            this.BotonBuscarCliente.Size = new System.Drawing.Size(110, 34);
            this.BotonBuscarCliente.TabIndex = 17;
            this.BotonBuscarCliente.Text = "Buscar";
            this.BotonBuscarCliente.UseVisualStyleBackColor = true;
            this.BotonBuscarCliente.Click += new System.EventHandler(this.BotonBuscarCliente_Click);
            // 
            // TextBoxDNI
            // 
            this.TextBoxDNI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDNI.Location = new System.Drawing.Point(152, 15);
            this.TextBoxDNI.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDNI.Name = "TextBoxDNI";
            this.TextBoxDNI.Size = new System.Drawing.Size(302, 34);
            this.TextBoxDNI.TabIndex = 16;
            // 
            // BotonAñadir
            // 
            this.BotonAñadir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAñadir.Location = new System.Drawing.Point(590, 15);
            this.BotonAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAñadir.Name = "BotonAñadir";
            this.BotonAñadir.Size = new System.Drawing.Size(121, 34);
            this.BotonAñadir.TabIndex = 32;
            this.BotonAñadir.Text = "Añadir";
            this.BotonAñadir.UseVisualStyleBackColor = true;
            this.BotonAñadir.Click += new System.EventHandler(this.BotonAñadir_Click);
            // 
            // LabelResultadoBusqueda
            // 
            this.LabelResultadoBusqueda.AutoSize = true;
            this.LabelResultadoBusqueda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultadoBusqueda.Location = new System.Drawing.Point(104, 134);
            this.LabelResultadoBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelResultadoBusqueda.Name = "LabelResultadoBusqueda";
            this.LabelResultadoBusqueda.Size = new System.Drawing.Size(0, 32);
            this.LabelResultadoBusqueda.TabIndex = 33;
            // 
            // Buscar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(733, 189);
            this.Controls.Add(this.LabelResultadoBusqueda);
            this.Controls.Add(this.BotonAñadir);
            this.Controls.Add(this.LabelDNI);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.BotonBuscarCliente);
            this.Controls.Add(this.TextBoxDNI);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Buscar_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar_Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Label LabelResultadoBusqueda;
        public System.Windows.Forms.Button BotonAñadir;
        public System.Windows.Forms.Label LabelDNI;
        public System.Windows.Forms.Button BotonBuscarCliente;
        public System.Windows.Forms.TextBox TextBoxDNI;
    }
}