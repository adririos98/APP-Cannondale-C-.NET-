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
    public partial class Menu_Coordinador : Menu_Template
    {
        public Menu_Coordinador(string Loginlogueado)
        {
            //Se define tanto el usuario logueado, así como los Menus de alta y baja disponibles para que sean visualizados.
            //Hay que recordar que se esta haciendo uso de Menu_Template para tener un esquema previo.
            InitializeComponent();
            Añadir_trabajadorToolStripMenuItem.Visible = false;
            Eliminar_trabajadorToolStripMenuItem.Visible = false;
            LabelLoginLogueado.Text = Loginlogueado;
        }
    }
}
