using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cannondale
{
    public partial class Menu_Ventas : Menu_Template
    {
        public Menu_Ventas(string Loginlogueado)
        {
            //Es importante definir esto, sin ello no recogue los datos.
            InitializeComponent();
            ToolStripMenuItemAdministracion.Visible = false;              
            LabelLoginLogueado.Text = Loginlogueado;       
        }
    }
}
