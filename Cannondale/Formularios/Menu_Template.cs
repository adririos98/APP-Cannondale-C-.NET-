using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cannondale
{
    public partial class Menu_Template : Form
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=cannondale; Integrated Security=SSPI");
        public Menu_Template()
        {
            //Se inicializa el formulario y el valor de la etiquta Fecha.
            InitializeComponent();
            LabelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); 
        }
                
        private void CAADOptimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Apartado para la definición de la llamada al formulario de CAADOptimo
            SqlCommand comandosql = new SqlCommand();
            //Apertura de la conexión de la BD.
            SqlTransaction mitransaccion;
            conexion.Open();
            mitransaccion = conexion.BeginTransaction();
            comandosql.Connection = conexion;
            comandosql.Transaction = mitransaccion;
            //Consulta para obtener todos los valores necesarios para registrarlos en el apartado de login (Requisito necesario en la práctica.)
            comandosql.CommandText = "INSERT into Registro_Login (Nombre_Login_conectado) values ('" + LabelLoginLogueado.Text+"')";
            comandosql.ExecuteNonQuery();
            mitransaccion.Commit();
            conexion.Close();
            ComboBoxHorquillaEquipos formulario = new ComboBoxHorquillaEquipos();
            formulario.MdiParent = this;
            //Añadimos al formulario padre el hijo, esto también se realizo en el login y por supuesto, mostramos ese formulario
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
        
        private void Añadir_trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Añadir_trabajador FormularioAlta = new Añadir_trabajador();
            FormularioAlta.ShowDialog();
        }

        private void RegistroVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Ventas Registro = new Registro_Ventas();
            Registro.ShowDialog();
        }

        private void ToolStripMenuItemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ToolStripMenuItemSynapse_Click(object sender, EventArgs e)
        {
            //Apartado para la definición de la llamada al formulario de Synapse
            SqlCommand comandosql = new SqlCommand();
            //Apertura de la conexión de la BD.
            SqlTransaction mitransaccion;
            conexion.Open();
            mitransaccion = conexion.BeginTransaction();
            comandosql.Connection = conexion;
            comandosql.Transaction = mitransaccion;
            //Consulta para obtener todos los valores necesarios para registrarlos en el apartado de login (Requisito necesario en la práctica.)
            comandosql.CommandText = "INSERT into Registro_Login (Nombre_Login_conectado) values ('" + LabelLoginLogueado.Text + "')";
            comandosql.ExecuteNonQuery();
            mitransaccion.Commit();
            conexion.Close();
            Synapse formulario = new Synapse();
            formulario.MdiParent = this;
            //Añadimos al formulario padre el hijo, esto también se realizo en el login y por supuesto, mostramos ese formulario
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
        private void ToolStripMenuItemCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Acceso_Inicio Login = new Form_Acceso_Inicio();
            Login.ShowDialog();
        }
        private void Eliminar_trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar_trabajador FormBaja = new Eliminar_trabajador();
            FormBaja.ShowDialog();
        }
        private void ToolStripMenuItemBicicletasCatalogo_Click(object sender, EventArgs e)
        {
            //Apartado para la definición de la llamada al formulario de biciletas de catalogo
            Bicicletas_de_catalogo CatalogoFormulario = new Bicicletas_de_catalogo();
            CatalogoFormulario.MdiParent = this;
            //Añadimos al formulario padre el hijo, esto también se realizo en el login y por supuesto, mostramos ese formulario
            CatalogoFormulario.Dock = DockStyle.Fill;
            CatalogoFormulario.Show();
        }

        private void LabelTextDefecto_Click(object sender, EventArgs e)
        {

        }
    }
}

