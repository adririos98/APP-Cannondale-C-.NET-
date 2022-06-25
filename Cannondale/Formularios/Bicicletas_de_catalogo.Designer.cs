
namespace Cannondale
{
    partial class Bicicletas_de_catalogo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelModelo = new System.Windows.Forms.Label();
            this.ComboBoxModelo = new System.Windows.Forms.ComboBox();
            this.DataGridCatalogo = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.BotonContinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelModelo
            // 
            this.LabelModelo.AutoSize = true;
            this.LabelModelo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModelo.ForeColor = System.Drawing.Color.Black;
            this.LabelModelo.Location = new System.Drawing.Point(12, 36);
            this.LabelModelo.Name = "LabelModelo";
            this.LabelModelo.Size = new System.Drawing.Size(640, 41);
            this.LabelModelo.TabIndex = 0;
            this.LabelModelo.Text = "Seleccionar el modelo de bicicleta de catálogo:";
            this.LabelModelo.Click += new System.EventHandler(this.LabelModelo_Click);
            // 
            // ComboBoxModelo
            // 
            this.ComboBoxModelo.FormattingEnabled = true;
            this.ComboBoxModelo.Items.AddRange(new object[] {
            "CAAD Optimo Basic Acero",
            "CAAD Optimo Titanio Plus",
            "Synapse Carbon PRO",
            "Synapse Carbon Basic"});
            this.ComboBoxModelo.Location = new System.Drawing.Point(19, 107);
            this.ComboBoxModelo.Name = "ComboBoxModelo";
            this.ComboBoxModelo.Size = new System.Drawing.Size(360, 36);
            this.ComboBoxModelo.TabIndex = 1;
            this.ComboBoxModelo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModelo_SelectedIndexChanged);
            // 
            // DataGridCatalogo
            // 
            this.DataGridCatalogo.AllowUserToAddRows = false;
            this.DataGridCatalogo.AllowUserToDeleteRows = false;
            this.DataGridCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.DataGridCatalogo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridCatalogo.BackgroundColor = System.Drawing.Color.Khaki;
            this.DataGridCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridCatalogo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataGridCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCatalogo.ColumnHeadersHeight = 38;
            this.DataGridCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Precio});
            this.DataGridCatalogo.EnableHeadersVisualStyles = false;
            this.DataGridCatalogo.GridColor = System.Drawing.Color.DarkOrange;
            this.DataGridCatalogo.Location = new System.Drawing.Point(12, 185);
            this.DataGridCatalogo.MultiSelect = false;
            this.DataGridCatalogo.Name = "DataGridCatalogo";
            this.DataGridCatalogo.ReadOnly = true;
            this.DataGridCatalogo.RowHeadersVisible = false;
            this.DataGridCatalogo.RowHeadersWidth = 261;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            this.DataGridCatalogo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridCatalogo.Size = new System.Drawing.Size(1280, 265);
            this.DataGridCatalogo.TabIndex = 31;
            this.DataGridCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCatalogo_CellContentClick);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descripcion.HeaderText = "Descripcion del producto";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio.HeaderText = "Precio en €";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(59, 24);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(0, 28);
            this.LabelLogin.TabIndex = 32;
            this.LabelLogin.Visible = false;
            // 
            // BotonContinuar
            // 
            this.BotonContinuar.Location = new System.Drawing.Point(953, 109);
            this.BotonContinuar.Name = "BotonContinuar";
            this.BotonContinuar.Size = new System.Drawing.Size(246, 34);
            this.BotonContinuar.TabIndex = 33;
            this.BotonContinuar.Text = "Siguiente";
            this.BotonContinuar.UseVisualStyleBackColor = true;
            this.BotonContinuar.Click += new System.EventHandler(this.BotonContinuar_Click);
            // 
            // Bicicletas_de_catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1324, 749);
            this.Controls.Add(this.BotonContinuar);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.DataGridCatalogo);
            this.Controls.Add(this.ComboBoxModelo);
            this.Controls.Add(this.LabelModelo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bicicletas_de_catalogo";
            this.Text = "Bicicletas_de_catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelModelo;
        private System.Windows.Forms.ComboBox ComboBoxModelo;
        private System.Windows.Forms.DataGridView DataGridCatalogo;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Button BotonContinuar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}