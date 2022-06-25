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
    public partial class Añadir_trabajador : Form
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=Cannondale; Integrated Security=SSPI");
        public Añadir_trabajador()
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
                //Comprobar si los textbox de datos se encuentran vacíos.
                if (TextBoxLogin.Text == "" || TextBoxPassword.Text == ""|| TextBoxPassword2.Text== "" || TextBoxNombre.Text == "" || TextBoxApellidos.Text == "" || ComboBoxTipo_Login.Text == "") //Confirmamos que no hay campos vacios
                {
                    MessageBox.Show("Uno o varios campos se encuentran vacíon","Advertencia");
                }
                else
                {
                    //Verificar si las contraseñas coinciden.
                    if (TextBoxPassword.Text != TextBoxPassword2.Text)
                    {
                        MessageBox.Show("La contraseña introducida no se repite");
                    }
                    else
                    {
                        //Insertar los datos en la BD y realizar el commiteo.
                        comandosql.CommandText = "INSERT into Login (Login,Password,Nombre,Apellidos,Tipo_Login) values ('" + TextBoxLogin.Text + "','" + TextBoxPassword.Text + "','" + TextBoxNombre.Text + "','" + TextBoxApellidos.Text + "','" + ComboBoxTipo_Login.Text + "')";
                        comandosql.ExecuteNonQuery();
                        mitransaccion.Commit();
                        MessageBox.Show("Se ha dado de alta al nuevo empleado correctamente.");               
                        this.Close();
                    }
                }
            }
            catch
            {
                //Este paso también se realizará en la baja, esto nos permite que si la operación falla en la bd se realiza un rollback para que esos cambios no se guarden.
                mitransaccion.Rollback();
            }
            //Cierre de la conexión a la BD
            conexion.Close();
        }
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
