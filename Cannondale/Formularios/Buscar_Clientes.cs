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
    public partial class Buscar_Clientes : Form
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=Cannondale; Integrated Security=SSPI");
        //Elementos que se van a usar.
        public string Id_DNI, Nombre, Apellido1, Apellido2, Direccion, Telefono, Mail;

        private void BotonAñadir_Click(object sender, EventArgs e)
        {
            //Comprobar si el DNI existe.
            if (LabelResultadoBusqueda.Text == "")
            {
                MessageBox.Show("El DNI introducido no corresponde a ningún cliente de la BD");
            }
            else
            {
                this.Close();
            }
        }
       
        public Buscar_Clientes()
        {
            InitializeComponent();
        }

        private void BotonBuscarCliente_Click(object sender, EventArgs e)
        {
            SqlCommand comandosql = new SqlCommand();            
            conexion.Open();            
            comandosql.Connection = conexion;
                //Condicional para comprobar si el textbox del DNI se encuentra vacío.
                if (TextBoxDNI.Text == "")
                {
                    MessageBox.Show("Indique el DNI del cliente.");
                }
                else
                {
                //Consulta para obtener todos los valores necesarios para registrarlos en el apartado de ventas (Requisito necesario en la práctica.)
                comandosql.CommandText = "SELECT Id_DNI,Nombre,Apellido1,Apellido2,Direccion,Telefono,Mail FROM Clientes WHERE Id_DNI='"+TextBoxDNI.Text +"'";
                SqlDataReader DataReader = comandosql.ExecuteReader();                
               
                while (DataReader.Read())
                {
                    //Valores de los datareader recogidos pasados a variable.
                    //Cada número es la posición en la que se encuentra.
                    Id_DNI = DataReader.GetString(0);
                    Nombre=DataReader.GetString(1);
                    Apellido1 = DataReader.GetString(2);
                    Apellido2 = DataReader.GetString(3);
                    Direccion = DataReader.GetString(4);
                    Telefono = DataReader.GetString(5);
                    Mail = DataReader.GetString(6);
                    //Mostrar los datos en la ventana (formulario) mostrado.
                    LabelResultadoBusqueda.Text = Nombre+" "+ Apellido1+" "+ Apellido2;                    
                }
                DataReader.Close();
                conexion.Close();
            }   
        }
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
