
namespace Cannondale
{
    partial class Menu_Ventas
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
            this.SuspendLayout();
            // 
            // LabelFecha
            // 
            this.LabelFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelFecha.Size = new System.Drawing.Size(276, 44);
            // 
            // Menu_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Menu_Ventas";
            this.Text = "Menu_Ventas";
            this.Controls.SetChildIndex(this.LabelTextDefecto, 0);
            this.Controls.SetChildIndex(this.LabelFecha, 0);
            this.Controls.SetChildIndex(this.LabelLoginLogueado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}