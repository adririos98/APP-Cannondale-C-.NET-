
namespace Cannondale
{
    partial class ComboBoxHorquillaEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBoxHorquillaEquipos));
            this.BotonTerminar = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBicicleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCuadro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLlantas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHorquillas)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxBicicleta
            // 
            this.PictureBoxBicicleta.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxBicicleta.ErrorImage")));
            this.PictureBoxBicicleta.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxBicicleta.Image")));
            this.PictureBoxBicicleta.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxBicicleta.InitialImage")));
            this.PictureBoxBicicleta.Size = new System.Drawing.Size(319, 180);
            // 
            // ComboBoxCuadro
            // 
            this.ComboBoxCuadro.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCuadro_SelectedIndexChanged);
            // 
            // LabelCuadro
            // 
            this.LabelCuadro.BackColor = System.Drawing.Color.IndianRed;
            this.LabelCuadro.Click += new System.EventHandler(this.LabelCuadro_Click);
            // 
            // ComboBoxColor
            // 
            this.ComboBoxColor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColor_SelectedIndexChanged);
            // 
            // PictureBoxCuadro
            // 
            this.PictureBoxCuadro.Click += new System.EventHandler(this.PictureBoxCuadro_Click);
            // 
            // LabelPrecioCuadro
            // 
            this.LabelPrecioCuadro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // ComboBoxLlantas
            // 
            this.ComboBoxLlantas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLlantas_SelectedIndexChanged);
            // 
            // LabelPrecioColor
            // 
            this.LabelPrecioColor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPrecioColor.Click += new System.EventHandler(this.LabelPrecioColor_Click);
            // 
            // ComboBoxComponentes
            // 
            this.ComboBoxComponentes.Location = new System.Drawing.Point(1534, 66);
            this.ComboBoxComponentes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxComponentes_SelectedIndexChanged);
            // 
            // LabelComponentes
            // 
            this.LabelComponentes.Location = new System.Drawing.Point(1392, 71);
            // 
            // ComboBoxHorquillas
            // 
            this.ComboBoxHorquillas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHorquillas_SelectedIndexChanged);
            // 
            // LabelPrecioLlantas
            // 
            this.LabelPrecioLlantas.Location = new System.Drawing.Point(1083, 70);
            this.LabelPrecioLlantas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxTotal.Size = new System.Drawing.Size(373, 54);
            // 
            // LabelPrecioHorquillas
            // 
            this.LabelPrecioHorquillas.Location = new System.Drawing.Point(1114, 387);
            this.LabelPrecioHorquillas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // LabelPrecioComponentes
            // 
            this.LabelPrecioComponentes.Location = new System.Drawing.Point(1835, 66);
            this.LabelPrecioComponentes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // BotonTerminar
            // 
            this.BotonTerminar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonTerminar.ForeColor = System.Drawing.Color.Black;
            this.BotonTerminar.Location = new System.Drawing.Point(890, 663);
            this.BotonTerminar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonTerminar.Name = "BotonTerminar";
            this.BotonTerminar.Size = new System.Drawing.Size(185, 57);
            this.BotonTerminar.TabIndex = 17;
            this.BotonTerminar.Text = "Siguiente";
            this.BotonTerminar.UseVisualStyleBackColor = true;
            this.BotonTerminar.Click += new System.EventHandler(this.BotonTerminar_Click_1);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(30, 9);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(78, 17);
            this.LabelLogin.TabIndex = 27;
            this.LabelLogin.Text = "LabelLogin";
            this.LabelLogin.Visible = false;
            // 
            // ComboBoxHorquillaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScroll = false;
            this.ClientSize = new System.Drawing.Size(2077, 919);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.BotonTerminar);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ComboBoxHorquillaEquipos";
            this.Load += new System.EventHandler(this.CAADOptimo_Load);
            this.Controls.SetChildIndex(this.LabelPrecioHorquillas, 0);
            this.Controls.SetChildIndex(this.LabelPrecioComponentes, 0);
            this.Controls.SetChildIndex(this.LabelPrecioLlantas, 0);
            this.Controls.SetChildIndex(this.LabelHorquillas, 0);
            this.Controls.SetChildIndex(this.ComboBoxHorquillas, 0);
            this.Controls.SetChildIndex(this.LabelComponentes, 0);
            this.Controls.SetChildIndex(this.ComboBoxComponentes, 0);
            this.Controls.SetChildIndex(this.PictureBoxComponentes, 0);
            this.Controls.SetChildIndex(this.LabelCuadro, 0);
            this.Controls.SetChildIndex(this.ComboBoxCuadro, 0);
            this.Controls.SetChildIndex(this.PictureBoxBicicleta, 0);
            this.Controls.SetChildIndex(this.PictureBoxCuadro, 0);
            this.Controls.SetChildIndex(this.ComboBoxColor, 0);
            this.Controls.SetChildIndex(this.PictureBoxColor, 0);
            this.Controls.SetChildIndex(this.LabelPrecioCuadro, 0);
            this.Controls.SetChildIndex(this.LabelLlantas, 0);
            this.Controls.SetChildIndex(this.ComboBoxLlantas, 0);
            this.Controls.SetChildIndex(this.PictureBoxLlantas, 0);
            this.Controls.SetChildIndex(this.BotonTerminar, 0);
            this.Controls.SetChildIndex(this.LabelLogin, 0);
            this.Controls.SetChildIndex(this.LabelColor, 0);
            this.Controls.SetChildIndex(this.PictureBoxHorquillas, 0);
            this.Controls.SetChildIndex(this.LabelPrecioColor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBicicleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCuadro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLlantas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHorquillas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BotonTerminar;
        private System.Windows.Forms.Label LabelLogin;
    }
}