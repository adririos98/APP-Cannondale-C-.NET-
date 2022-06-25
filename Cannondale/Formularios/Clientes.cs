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
    public partial class Clientes : Form
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=cannondale; Integrated Security=SSPI");
        //Elementos que se van a usar.
        public string Id_DNI, Nombre, Apellido1, Apellido2, Direccion, Telefono, Mail;
        public Clientes()
        {
            InitializeComponent();
        }
        private void BotonInsertarCliente_Click(object sender, EventArgs e)
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
                //Si los campos se encuentran vacíos sacar el valor de que hay campos por completar.
                if (TextBoxDNI.Text == "" || TextBoxNombre.Text == "" || TextBoxApellido1.Text == "" || TextBoxApellido2.Text == "" || TextBoxDireccion.Text == "" || TextBoxTelefono.Text == "")
                { 
                    MessageBox.Show("Hay campos incompletos."); 
                }
                //Por el contrario realizar lo siguiente:
                else
                {
                    //Consulta para obtener todos los valores necesarios para registrarlos en el apartado de clientes (Requisito necesario en la práctica.)
                    comandosql.CommandText = "INSERT into Clientes (Id_DNI,Nombre,Apellido1,Apellido2,Direccion,Telefono,Mail) values ('" + TextBoxDNI.Text+ "','" +TextBoxNombre.Text+ "','" +TextBoxApellido1.Text+ "','" +TextBoxApellido2.Text+ "','" +TextBoxDireccion.Text+ "','" +TextBoxTelefono.Text+ "','" +TextBoxMail.Text+ "')";                    
                    comandosql.ExecuteNonQuery();
                    mitransaccion.Commit();                    
                    MessageBox.Show("Se ha agregado el nuevo cliente sin problemas.");
                    //Valores de los textbox recogidos pasados a variable.
                    Id_DNI = TextBoxDNI.Text;
                    Nombre = TextBoxNombre.Text;
                    Apellido1 = TextBoxApellido1.Text;
                    Apellido2 = TextBoxApellido2.Text;
                    Direccion = TextBoxDireccion.Text;
                    Telefono = TextBoxTelefono.Text;
                    Mail = TextBoxMail.Text;
                    this.Close();
                }
            }
            catch 
            { 
                mitransaccion.Rollback();
            }
            conexion.Close();  
         }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            //Cerrar aplicación
            this.Close();
        }
    }
}
