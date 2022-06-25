
namespace Cannondale
{
    partial class Menu_Administradores
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
            // LabelLoginLogueado
            // 
            this.LabelLoginLogueado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelLoginLogueado.Size = new System.Drawing.Size(628, 42);
            // 
            // LabelFecha
            // 
            this.LabelFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelFecha.Size = new System.Drawing.Size(197, 37);
            // 
            // Menu_Administradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1334, 693);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu_Administradores";
            this.Text = "Menu_Administradores";
            this.Load += new System.EventHandler(this.Menu_Administradores_Load);
            this.Controls.SetChildIndex(this.LabelTextDefecto, 0);
            this.Controls.SetChildIndex(this.LabelFecha, 0);
            this.Controls.SetChildIndex(this.LabelLoginLogueado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}