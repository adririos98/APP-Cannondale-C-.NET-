
namespace Cannondale
{
    partial class Eliminar_trabajador
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
            this.LabelNick = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.LabelResultadoBusquedaNombre = new System.Windows.Forms.Label();
            this.LabelResultadoBusquedaApellidos = new System.Windows.Forms.Label();
            this.BotonEliminarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNick
            // 
            this.LabelNick.AutoSize = true;
            this.LabelNick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNick.Location = new System.Drawing.Point(34, 30);
            this.LabelNick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNick.Name = "LabelNick";
            this.LabelNick.Size = new System.Drawing.Size(186, 28);
            this.LabelNick.TabIndex = 0;
            this.LabelNick.Text = "Nombre trabajador:";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserName.Location = new System.Drawing.Point(243, 30);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(268, 34);
            this.TextBoxUserName.TabIndex = 1;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscar.Location = new System.Drawing.Point(538, 30);
            this.BotonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(124, 35);
            this.BotonBuscar.TabIndex = 2;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // LabelResultadoBusquedaNombre
            // 
            this.LabelResultadoBusquedaNombre.AutoSize = true;
            this.LabelResultadoBusquedaNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultadoBusquedaNombre.Location = new System.Drawing.Point(77, 153);
            this.LabelResultadoBusquedaNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelResultadoBusquedaNombre.Name = "LabelResultadoBusquedaNombre";
            this.LabelResultadoBusquedaNombre.Size = new System.Drawing.Size(0, 32);
            this.LabelResultadoBusquedaNombre.TabIndex = 3;
            // 
            // LabelResultadoBusquedaApellidos
            // 
            this.LabelResultadoBusquedaApellidos.AutoSize = true;
            this.LabelResultadoBusquedaApellidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultadoBusquedaApellidos.Location = new System.Drawing.Point(151, 153);
            this.LabelResultadoBusquedaApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelResultadoBusquedaApellidos.Name = "LabelResultadoBusquedaApellidos";
            this.LabelResultadoBusquedaApellidos.Size = new System.Drawing.Size(0, 32);
            this.LabelResultadoBusquedaApellidos.TabIndex = 4;
            // 
            // BotonEliminarEmpleado
            // 
            this.BotonEliminarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarEmpleado.Location = new System.Drawing.Point(710, 30);
            this.BotonEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.BotonEliminarEmpleado.Name = "BotonEliminarEmpleado";
            this.BotonEliminarEmpleado.Size = new System.Drawing.Size(123, 35);
            this.BotonEliminarEmpleado.TabIndex = 5;
            this.BotonEliminarEmpleado.Text = "Eliminar";
            this.BotonEliminarEmpleado.UseVisualStyleBackColor = true;
            this.BotonEliminarEmpleado.Click += new System.EventHandler(this.BotonEliminarEmpleado_Click);
            // 
            // Eliminar_trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(904, 164);
            this.Controls.Add(this.BotonEliminarEmpleado);
            this.Controls.Add(this.LabelResultadoBusquedaApellidos);
            this.Controls.Add(this.LabelResultadoBusquedaNombre);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.LabelNick);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Eliminar_trabajador";
            this.Text = "Eliminar un empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNick;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Label LabelResultadoBusquedaNombre;
        private System.Windows.Forms.Label LabelResultadoBusquedaApellidos;
        private System.Windows.Forms.Button BotonEliminarEmpleado;
    }
}