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
    public partial class Eliminar_trabajador : Form
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=Cannondale; Integrated Security=SSPI");
        //Elementos que se van a usar.
        string Id_Login,Nombre, Apellidos;
        public Eliminar_trabajador()
        {
            InitializeComponent();
        }
        private void BotonEliminarEmpleado_Click(object sender, EventArgs e)
        {
            string Aviso = "Advertencia";
            string Mensaje = "Si continua, se eliminará el usuario seleccionado.";
            MessageBoxButtons Boton = MessageBoxButtons.YesNo;
            DialogResult fusion = MessageBox.Show(Mensaje, Aviso, Boton, MessageBoxIcon.Warning);
            if (fusion == DialogResult.Yes)
            {
                SqlCommand comandosql = new SqlCommand();
                SqlTransaction mitransaccion;
                //Apertura de la conexión de la BD.
                conexion.Open();
                mitransaccion = conexion.BeginTransaction();
                comandosql.Connection = conexion;
                comandosql.Transaction = mitransaccion;
                try
                {
                    // Eliminar el usuario mediante consulta y posterior commit.
                    comandosql.CommandText = "DELETE from Login WHERE Nombre ='" + LabelResultadoBusquedaNombre.Text + "'";
                    comandosql.ExecuteNonQuery();
                    mitransaccion.Commit();
                    MessageBox.Show("Se ha dado de baja al empleado correctamente.");               
                    this.Close();
                }
                catch
                {
                    //Esto nos permite que si la operación falla en la bd se realiza un rollback para que esos cambios no se guarden.
                    mitransaccion.Rollback();
                }
                //Cierre de la conexión a la BD
                conexion.Close();
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand comandosql = new SqlCommand();
            //Apertura de la conexión de la BD.
            conexion.Open();
            comandosql.Connection = conexion;
            //Comprobar que el texbox de comprobación del nombre del usuario no se encuentra vacio.
            if (TextBoxUserName.Text == "")
            {
                MessageBox.Show("Indique el nombre de usuario del empleado que se desea eliminar.");
            }
            else
            {
                //Consulta para obtener el usuario que se desea localizar.
                comandosql.CommandText = "SELECT Id_Login,Nombre,Apellidos FROM Login WHERE Login='" + TextBoxUserName.Text + "'";
                SqlDataReader DataReader = comandosql.ExecuteReader();

                while (DataReader.Read())
                {
                    //Valores del datareade incorporados.
                    Id_Login = DataReader[0].ToString();
                    Nombre = DataReader.GetString(1);
                    Apellidos = DataReader.GetString(2);
                    LabelResultadoBusquedaNombre.Text = Nombre;
                    LabelResultadoBusquedaApellidos.Text = Apellidos;       
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
                if (LabelResultadoBusquedaNombre.Text == "")
                {
                    //Mensaje para indicar que el usuario no está en la BD.
                    MessageBox.Show("No se encuentra un empleado con el nombre de usuario introducido.");
                }
            }
        }
    }
}
