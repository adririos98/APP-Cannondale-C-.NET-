
namespace Cannondale
{
    partial class Synapse
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
            this.LabelLogin = new System.Windows.Forms.Label();
            this.BotonTerminar = new System.Windows.Forms.Button();
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
            this.PictureBoxBicicleta.Image = global::Cannondale.Properties.Resources.Synapse_Inicio;
            this.PictureBoxBicicleta.Margin = new System.Windows.Forms.Padding(5);
            this.PictureBoxBicicleta.Size = new System.Drawing.Size(320, 180);
            // 
            // ComboBoxCuadro
            // 
            this.ComboBoxCuadro.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCuadro_SelectedIndexChanged);
            // 
            // ComboBoxColor
            // 
            this.ComboBoxColor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColor_SelectedIndexChanged);
            // 
            // PictureBoxCuadro
            // 
            this.PictureBoxCuadro.Click += new System.EventHandler(this.PictureBoxCuadro_Click);
            // 
            // ComboBoxLlantas
            // 
            this.ComboBoxLlantas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLlantas_SelectedIndexChanged);
            // 
            // ComboBoxComponentes
            // 
            this.ComboBoxComponentes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxComponentes_SelectedIndexChanged);
            // 
            // ComboBoxHorquillas
            // 
            this.ComboBoxHorquillas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHorquillas_SelectedIndexChanged);
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxTotal.Size = new System.Drawing.Size(373, 54);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(16, 30);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(78, 17);
            this.LabelLogin.TabIndex = 29;
            this.LabelLogin.Text = "LabelLogin";
            this.LabelLogin.Visible = false;
            // 
            // BotonTerminar
            // 
            this.BotonTerminar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonTerminar.ForeColor = System.Drawing.Color.Black;
            this.BotonTerminar.Location = new System.Drawing.Point(862, 655);
            this.BotonTerminar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonTerminar.Name = "BotonTerminar";
            this.BotonTerminar.Size = new System.Drawing.Size(213, 63);
            this.BotonTerminar.TabIndex = 30;
            this.BotonTerminar.Text = "Siguiente";
            this.BotonTerminar.UseVisualStyleBackColor = true;
            this.BotonTerminar.Click += new System.EventHandler(this.BotonTerminar_Click);
            // 
            // Synapse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 970);
            this.Controls.Add(this.BotonTerminar);
            this.Controls.Add(this.LabelLogin);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Synapse";
            this.Text = "Synapse";
            this.Load += new System.EventHandler(this.Synapse_Load);
            this.Controls.SetChildIndex(this.LabelCuadro, 0);
            this.Controls.SetChildIndex(this.ComboBoxCuadro, 0);
            this.Controls.SetChildIndex(this.PictureBoxBicicleta, 0);
            this.Controls.SetChildIndex(this.PictureBoxCuadro, 0);
            this.Controls.SetChildIndex(this.LabelColor, 0);
            this.Controls.SetChildIndex(this.ComboBoxColor, 0);
            this.Controls.SetChildIndex(this.PictureBoxColor, 0);
            this.Controls.SetChildIndex(this.LabelPrecioCuadro, 0);
            this.Controls.SetChildIndex(this.LabelLlantas, 0);
            this.Controls.SetChildIndex(this.ComboBoxLlantas, 0);
            this.Controls.SetChildIndex(this.PictureBoxLlantas, 0);
            this.Controls.SetChildIndex(this.LabelPrecioColor, 0);
            this.Controls.SetChildIndex(this.LabelHorquillas, 0);
            this.Controls.SetChildIndex(this.ComboBoxHorquillas, 0);
            this.Controls.SetChildIndex(this.PictureBoxHorquillas, 0);
            this.Controls.SetChildIndex(this.LabelComponentes, 0);
            this.Controls.SetChildIndex(this.ComboBoxComponentes, 0);
            this.Controls.SetChildIndex(this.PictureBoxComponentes, 0);
            this.Controls.SetChildIndex(this.LabelPrecioLlantas, 0);
            this.Controls.SetChildIndex(this.LabelPrecioHorquillas, 0);
            this.Controls.SetChildIndex(this.LabelPrecioComponentes, 0);
            this.Controls.SetChildIndex(this.LabelLogin, 0);
            this.Controls.SetChildIndex(this.BotonTerminar, 0);
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

        private System.Windows.Forms.Label LabelLogin;
        public System.Windows.Forms.Button BotonTerminar;
    }
}