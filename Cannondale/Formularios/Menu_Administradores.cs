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
    public partial class Menu_Administradores : Menu_Template
        
    {
        public string varglobalLoginlogueado;
        public Menu_Administradores(string Loginlogueado)
        {
            //Se define tanto el usuario logueado, así como los Menus de alta y baja disponibles para que sean visualizados.
            //Hay que recordar que se esta haciendo uso de Menu_Template para tener un esquema previo.
            InitializeComponent();          
            varglobalLoginlogueado = Loginlogueado;       
            LabelLoginLogueado.Text = varglobalLoginlogueado;
        }

        private void Menu_Administradores_Load(object sender, EventArgs e)
        {

        }
    }
}
