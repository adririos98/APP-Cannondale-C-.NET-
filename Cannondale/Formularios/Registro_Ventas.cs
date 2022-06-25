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
    public partial class Registro_Ventas : Menu_Template
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=cannondale; Integrated Security=SSPI");
        public string varglobalLoginlogueado;
        public Registro_Ventas()
        {
            InitializeComponent();

        }
        private void Registro_Ventas_Load(object sender, EventArgs e)
        {
         
        }
        private void BotonCargarVentas_Click(object sender, EventArgs e)
        {
            ListViewRegistroVentas.Items.Clear();
            SqlCommand comandosql = new SqlCommand();
            //Apertura de la conexión de la BD.
            conexion.Open();
            comandosql.Connection = conexion;
            //Consulta para obtener todos los valores necesarios para registrarlos en el apartado de ventas (Requisito necesario en la práctica.)
            comandosql.CommandText = "SELECT Id_Factura,Vendedor,Nombre_Cliente,Apellido1_Cliente,Apellido2_Cliente,Direccion_Cliente,Telefono_Cliente,Mail_Cliente,Fecha_Venta,Precio_Venta FROM Registro_Ventas";
            SqlDataReader DataReader = comandosql.ExecuteReader();
            //Elementos que se van a usar.
            string IdFactura, Vendedor, Nombre, Apellido1, Apellido2, Direccion, Telefono, Mail, Fecha, Total;     
            ListViewItem milista;
            //Bucle para que recorra todo el DataReader
            while (DataReader.Read())
            {
                //Parte para la obtención de los datos.
                IdFactura = DataReader[0].ToString();                
                Vendedor = DataReader.GetString(1);
                Nombre = DataReader.GetString(2);
                Apellido1 = DataReader.GetString(3);
                Apellido2 = DataReader.GetString(4);
                Direccion = DataReader.GetString(5);
                Telefono = DataReader.GetString(6);
                Mail = DataReader.GetString(7);
                Fecha = DataReader.GetString(8);
                Total = DataReader.GetString(9);
                
                //Parte donde se agregan los componentes.
                milista = ListViewRegistroVentas.Items.Add(IdFactura);
                milista.SubItems.Add(Nombre);
                milista.SubItems.Add(Apellido1);
                milista.SubItems.Add(Apellido2);
                milista.SubItems.Add(Mail);
                milista.SubItems.Add(Telefono);
                milista.SubItems.Add(Direccion);
                milista.SubItems.Add(Vendedor);
                milista.SubItems.Add(Total);
                milista.SubItems.Add(Fecha);
                
            }
            //Cierre tanto del DataReader como de la conexión a la BD.
            DataReader.Close();
            conexion.Close();
        }
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelLoginLogueado_Click(object sender, EventArgs e)
        {

        }
    }
}