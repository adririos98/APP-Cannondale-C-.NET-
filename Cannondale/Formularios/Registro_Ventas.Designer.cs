
namespace Cannondale
{
    partial class Registro_Ventas
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
            this.BotonCargarVentas = new System.Windows.Forms.Button();
            this.ListViewRegistroVentas = new System.Windows.Forms.ListView();
            this.ColumnHeaderNumerFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderNombreCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderApellido1Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderApellido2Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderMailCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderTelefonoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderDireccionCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderComercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderPrecioVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderFechaVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.LabelHistorico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelLoginLogueado
            // 
            this.LabelLoginLogueado.ForeColor = System.Drawing.Color.White;
            this.LabelLoginLogueado.Location = new System.Drawing.Point(718, 57);
            // 
            // LabelTextDefecto
            // 
            this.LabelTextDefecto.ForeColor = System.Drawing.Color.White;
            this.LabelTextDefecto.Location = new System.Drawing.Point(727, 48);
            this.LabelTextDefecto.Size = new System.Drawing.Size(327, 28);
            // 
            // BotonCargarVentas
            // 
            this.BotonCargarVentas.Location = new System.Drawing.Point(1208, 224);
            this.BotonCargarVentas.Name = "BotonCargarVentas";
            this.BotonCargarVentas.Size = new System.Drawing.Size(261, 42);
            this.BotonCargarVentas.TabIndex = 1;
            this.BotonCargarVentas.Text = "Obtener ventas";
            this.BotonCargarVentas.UseVisualStyleBackColor = true;
            this.BotonCargarVentas.Click += new System.EventHandler(this.BotonCargarVentas_Click);
            // 
            // ListViewRegistroVentas
            // 
            this.ListViewRegistroVentas.BackColor = System.Drawing.SystemColors.Info;
            this.ListViewRegistroVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderNumerFactura,
            this.ColumnHeaderNombreCliente,
            this.ColumnHeaderApellido1Cliente,
            this.ColumnHeaderApellido2Cliente,
            this.ColumnHeaderMailCliente,
            this.ColumnHeaderTelefonoCliente,
            this.ColumnHeaderDireccionCliente,
            this.ColumnHeaderComercial,
            this.ColumnHeaderPrecioVenta,
            this.ColumnHeaderFechaVenta});
            this.ListViewRegistroVentas.ForeColor = System.Drawing.Color.Black;
            this.ListViewRegistroVentas.FullRowSelect = true;
            this.ListViewRegistroVentas.HideSelection = false;
            this.ListViewRegistroVentas.Location = new System.Drawing.Point(25, 281);
            this.ListViewRegistroVentas.Name = "ListViewRegistroVentas";
            this.ListViewRegistroVentas.Size = new System.Drawing.Size(1470, 427);
            this.ListViewRegistroVentas.TabIndex = 2;
            this.ListViewRegistroVentas.UseCompatibleStateImageBehavior = false;
            this.ListViewRegistroVentas.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeaderNumerFactura
            // 
            this.ColumnHeaderNumerFactura.Text = "Factura";
            this.ColumnHeaderNumerFactura.Width = 86;
            // 
            // ColumnHeaderNombreCliente
            // 
            this.ColumnHeaderNombreCliente.Text = "Nombre";
            this.ColumnHeaderNombreCliente.Width = 134;
            // 
            // ColumnHeaderApellido1Cliente
            // 
            this.ColumnHeaderApellido1Cliente.Text = "1ºApellido";
            this.ColumnHeaderApellido1Cliente.Width = 161;
            // 
            // ColumnHeaderApellido2Cliente
            // 
            this.ColumnHeaderApellido2Cliente.Text = "2ºApellido";
            this.ColumnHeaderApellido2Cliente.Width = 192;
            // 
            // ColumnHeaderMailCliente
            // 
            this.ColumnHeaderMailCliente.Text = "Correo electrónico";
            this.ColumnHeaderMailCliente.Width = 199;
            // 
            // ColumnHeaderTelefonoCliente
            // 
            this.ColumnHeaderTelefonoCliente.Text = "Teléfono";
            this.ColumnHeaderTelefonoCliente.Width = 135;
            // 
            // ColumnHeaderDireccionCliente
            // 
            this.ColumnHeaderDireccionCliente.Text = "Direccion física";
            this.ColumnHeaderDireccionCliente.Width = 160;
            // 
            // ColumnHeaderComercial
            // 
            this.ColumnHeaderComercial.Text = "Comercial";
            this.ColumnHeaderComercial.Width = 106;
            // 
            // ColumnHeaderPrecioVenta
            // 
            this.ColumnHeaderPrecioVenta.Text = "Total €";
            this.ColumnHeaderPrecioVenta.Width = 112;
            // 
            // ColumnHeaderFechaVenta
            // 
            this.ColumnHeaderFechaVenta.Text = "Fecha de venta";
            this.ColumnHeaderFechaVenta.Width = 140;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(712, 723);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(145, 42);
            this.BotonCerrar.TabIndex = 3;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // LabelHistorico
            // 
            this.LabelHistorico.AutoSize = true;
            this.LabelHistorico.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHistorico.Location = new System.Drawing.Point(47, 224);
            this.LabelHistorico.Name = "LabelHistorico";
            this.LabelHistorico.Size = new System.Drawing.Size(616, 38);
            this.LabelHistorico.TabIndex = 4;
            this.LabelHistorico.Text = "Consultar el historico de las ventas realizadas:";
            // 
            // Registro_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1743, 787);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.ListViewRegistroVentas);
            this.Controls.Add(this.BotonCargarVentas);
            this.Controls.Add(this.LabelHistorico);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registro_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Ventas";
            this.Load += new System.EventHandler(this.Registro_Ventas_Load);
            this.Controls.SetChildIndex(this.LabelLoginLogueado, 0);
            this.Controls.SetChildIndex(this.LabelTextDefecto, 0);
            this.Controls.SetChildIndex(this.LabelFecha, 0);
            this.Controls.SetChildIndex(this.LabelHistorico, 0);
            this.Controls.SetChildIndex(this.BotonCargarVentas, 0);
            this.Controls.SetChildIndex(this.ListViewRegistroVentas, 0);
            this.Controls.SetChildIndex(this.BotonCerrar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonCargarVentas;
        private System.Windows.Forms.ListView ListViewRegistroVentas;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.ColumnHeader ColumnHeaderComercial;
        private System.Windows.Forms.ColumnHeader ColumnHeaderFechaVenta;
        private System.Windows.Forms.ColumnHeader ColumnHeaderNombreCliente;
        private System.Windows.Forms.ColumnHeader ColumnHeaderApellido1Cliente;
        private System.Windows.Forms.ColumnHeader ColumnHeaderApellido2Cliente;
        private System.Windows.Forms.ColumnHeader ColumnHeaderDireccionCliente;
        private System.Windows.Forms.ColumnHeader ColumnHeaderTelefonoCliente;
        private System.Windows.Forms.ColumnHeader ColumnHeaderMailCliente;
        private System.Windows.Forms.ColumnHeader ColumnHeaderPrecioVenta;
        private System.Windows.Forms.Label LabelHistorico;
        internal System.Windows.Forms.ColumnHeader ColumnHeaderNumerFactura;
    }
}