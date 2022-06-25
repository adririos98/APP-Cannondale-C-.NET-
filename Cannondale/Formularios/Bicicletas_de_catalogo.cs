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

    public partial class Bicicletas_de_catalogo : Form
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=cannondale; Integrated Security=SSPI");
        //Elementos que se van a usar.
        public string Tipo_Cuadro, Precio_Cuadro, Tipo_Color, Precio_Color, Tipo_Llanta, Precio_Llanta, Tipo_Horquilla, Precio_Horquilla, Tipo_Componente, Precio_Componente;

        private void DataGridCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LabelModelo_Click(object sender, EventArgs e)
        {

        }

        public Bicicletas_de_catalogo()
        {
            InitializeComponent();
        }
        private void ComboBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CAAD Optimo Basic Acero
            DataGridCatalogo.Rows.Clear();
            if (ComboBoxModelo.Text == "CAAD Optimo Basic Acero")
            {
                SqlCommand comandosql = new SqlCommand();
                //Apertura de la conexión de la BD.
                conexion.Open();
                comandosql.Connection = conexion;
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Cuadro,Precio_Cuadro FROM Cuadros WHERE Tipo_Cuadro='100A Acero'";
                SqlDataReader DataReaderCuadro = comandosql.ExecuteReader();
                while (DataReaderCuadro.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Cuadro = DataReaderCuadro.GetString(0);
                    Precio_Cuadro = DataReaderCuadro.GetString(1);                    
                }
                //Cierre tanto del DataReader.
                DataReaderCuadro.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Color,Precio_Color FROM Colores WHERE Tipo_Color='Negro'";
                SqlDataReader DataReaderColor = comandosql.ExecuteReader();
                while (DataReaderColor.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Color = DataReaderColor.GetString(0);
                    Precio_Color = DataReaderColor.GetString(1);
                }                
                DataReaderColor.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Llanta,Precio_Llanta FROM Llantas WHERE Tipo_Llanta='Tubular'";
                SqlDataReader DataReaderLlantas = comandosql.ExecuteReader();
                while (DataReaderLlantas.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Llanta = DataReaderLlantas.GetString(0);
                    Precio_Llanta = DataReaderLlantas.GetString(1);
                }
                DataReaderLlantas.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Horquilla,Precio_Horquilla FROM Horquillas WHERE Tipo_Horquilla='Modelo Basic'";
                SqlDataReader DataReaderHorquillas = comandosql.ExecuteReader();
                while (DataReaderHorquillas.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Horquilla = DataReaderHorquillas.GetString(0);
                    Precio_Horquilla = DataReaderHorquillas.GetString(1);
                }                
                DataReaderHorquillas.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Componente,Precio_Componente FROM Componentes WHERE Tipo_Componente='Pedales'";
                SqlDataReader DataReaderComponentes = comandosql.ExecuteReader();
                while (DataReaderComponentes.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Componente = DataReaderComponentes.GetString(0);
                    Precio_Componente = DataReaderComponentes.GetString(1);
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReaderComponentes.Close();
                conexion.Close();
            }
            
            //CAAD Optimo Titanio Plus
            if (ComboBoxModelo.Text == "CAAD Optimo Titanio Plus")
            {
                //Apertura de la conexión de la BD.
                SqlCommand comandosql = new SqlCommand();
                conexion.Open();
                comandosql.Connection = conexion;
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Cuadro,Precio_Cuadro FROM Cuadros WHERE Tipo_Cuadro='200T Titanio Plus'";
                SqlDataReader DataReaderCuadro = comandosql.ExecuteReader();
                while (DataReaderCuadro.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Cuadro = DataReaderCuadro.GetString(0);
                    Precio_Cuadro = DataReaderCuadro.GetString(1);

                }
                DataReaderCuadro.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Color,Precio_Color FROM Colores WHERE Tipo_Color='Negro'";
                SqlDataReader DataReaderColor = comandosql.ExecuteReader();
                while (DataReaderColor.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Color = DataReaderColor.GetString(0);
                    Precio_Color = DataReaderColor.GetString(1);
                }
                DataReaderColor.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Llanta,Precio_Llanta FROM Llantas WHERE Tipo_Llanta='Tubeless'";
                SqlDataReader DataReaderLlantas = comandosql.ExecuteReader();
                while (DataReaderLlantas.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Llanta = DataReaderLlantas.GetString(0);
                    Precio_Llanta = DataReaderLlantas.GetString(1);
                }
                DataReaderLlantas.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Horquilla,Precio_Horquilla FROM Horquillas WHERE Tipo_Horquilla='Modelo Basic'";
                SqlDataReader DataReaderHorquillas = comandosql.ExecuteReader();
                while (DataReaderHorquillas.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Horquilla = DataReaderHorquillas.GetString(0);
                    Precio_Horquilla = DataReaderHorquillas.GetString(1);
                }
                DataReaderHorquillas.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Componente,Precio_Componente FROM Componentes WHERE Tipo_Componente='Manillar'";
                SqlDataReader DataReaderComponentes = comandosql.ExecuteReader();
                while (DataReaderComponentes.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Componente = DataReaderComponentes.GetString(0);
                    Precio_Componente = DataReaderComponentes.GetString(1);
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReaderComponentes.Close();
                conexion.Close();
            }

            // Synapse Carbon PRO
            if (ComboBoxModelo.Text == "Synapse Carbon PRO")
            {
                //Apertura de la conexión de la BD.
                SqlCommand comandosql = new SqlCommand();
                conexion.Open();
                comandosql.Connection = conexion;
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Cuadro,Precio_Cuadro FROM Cuadros WHERE Tipo_Cuadro='Synapse Carbon LTD RLE'";
                SqlDataReader DataReaderCuadro = comandosql.ExecuteReader();
                while (DataReaderCuadro.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Cuadro = DataReaderCuadro.GetString(0);
                    Precio_Cuadro = DataReaderCuadro.GetString(1);
                }
                DataReaderCuadro.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Color,Precio_Color FROM Colores WHERE Tipo_Color='Blanco'";
                SqlDataReader DataReaderColor = comandosql.ExecuteReader();
                while (DataReaderColor.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Color = DataReaderColor.GetString(0);
                    Precio_Color = DataReaderColor.GetString(1);
                }
                DataReaderColor.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Llanta,Precio_Llanta FROM Llantas WHERE Tipo_Llanta='TPI'";
                SqlDataReader DataReaderLlantas = comandosql.ExecuteReader();
                while (DataReaderLlantas.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Llanta = DataReaderLlantas.GetString(0);
                    Precio_Llanta = DataReaderLlantas.GetString(1);
                }
                DataReaderLlantas.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Horquilla,Precio_Horquilla FROM Horquillas WHERE Tipo_Horquilla='Modelo PRO'";
                SqlDataReader DataReaderHorquillas = comandosql.ExecuteReader();
                while (DataReaderHorquillas.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Horquilla = DataReaderHorquillas.GetString(0);
                    Precio_Horquilla = DataReaderHorquillas.GetString(1);
                }
                DataReaderHorquillas.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Componente,Precio_Componente FROM Componentes WHERE Tipo_Componente='Sillin'";
                SqlDataReader DataReaderComponentes = comandosql.ExecuteReader();
                while (DataReaderComponentes.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Componente = DataReaderComponentes.GetString(0);
                    Precio_Componente = DataReaderComponentes.GetString(1);
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReaderComponentes.Close();
                conexion.Close();
            }

            // Synapse Carbon Basic
            if (ComboBoxModelo.Text == "Synapse Carbon Basic")
            {
                //Apertura de la conexión de la BD.
                SqlCommand comandosql = new SqlCommand();
                conexion.Open();
                comandosql.Connection = conexion;
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Cuadro,Precio_Cuadro FROM Cuadros WHERE Tipo_Cuadro='Synapse Carbon 2 RLE'";
                SqlDataReader DataReaderCuadro = comandosql.ExecuteReader();
                while (DataReaderCuadro.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Cuadro = DataReaderCuadro.GetString(0);
                    Precio_Cuadro = DataReaderCuadro.GetString(1);
                }
                DataReaderCuadro.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Color,Precio_Color FROM Colores WHERE Tipo_Color='Rojo'";
                SqlDataReader DataReaderColor = comandosql.ExecuteReader();
                while (DataReaderColor.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Color = DataReaderColor.GetString(0);
                    Precio_Color = DataReaderColor.GetString(1);
                }
                DataReaderColor.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Llanta,Precio_Llanta FROM Llantas WHERE Tipo_Llanta='Tubular'";
                SqlDataReader DataReaderLlantas = comandosql.ExecuteReader();
                while (DataReaderLlantas.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Llanta = DataReaderLlantas.GetString(0);
                    Precio_Llanta = DataReaderLlantas.GetString(1);
                }
                DataReaderLlantas.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Horquilla,Precio_Horquilla FROM Horquillas WHERE Tipo_Horquilla='Modelo Basic'";
                SqlDataReader DataReaderHorquillas = comandosql.ExecuteReader();
                while (DataReaderHorquillas.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Horquilla = DataReaderHorquillas.GetString(0);
                    Precio_Horquilla = DataReaderHorquillas.GetString(1);
                }
                DataReaderHorquillas.Close();
                //Consulta
                comandosql.CommandText = "SELECT Tipo_Componente,Precio_Componente FROM Componentes WHERE Tipo_Componente='Sillin'";
                SqlDataReader DataReaderComponentes = comandosql.ExecuteReader();
                while (DataReaderComponentes.Read())
                {
                    //Paso de valor en la variables de los tipos 0 y 1.
                    Tipo_Componente = DataReaderComponentes.GetString(0);
                    Precio_Componente = DataReaderComponentes.GetString(1);
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReaderComponentes.Close();
                conexion.Close();
            }

            //Añadir los valores de cada tipo.
            DataGridCatalogo.BackgroundColor = Color.Khaki;
            DataGridCatalogo.Rows.Add(Tipo_Cuadro, Precio_Cuadro);
            DataGridCatalogo.Rows.Add(Tipo_Color, Precio_Color);
            DataGridCatalogo.Rows.Add(Tipo_Llanta, Precio_Llanta);
            DataGridCatalogo.Rows.Add(Tipo_Horquilla, Precio_Horquilla);
            DataGridCatalogo.Rows.Add(Tipo_Componente, Precio_Componente);
            //Necesario para el formateo de color.
            foreach (DataGridViewRow row in DataGridCatalogo.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                }

        }
        private void BotonContinuar_Click(object sender, EventArgs e)
        {
            //Contro de excepciones para controlar los errores.
            try
            {
                //Apertura del formulario para la factura de CAADOptimo
                Factura_CAADOptimo Formulario = new Factura_CAADOptimo(LabelLogin.Text, Precio_Cuadro, Precio_Color, Precio_Llanta, Precio_Horquilla,Precio_Componente, Tipo_Cuadro, Tipo_Color, Tipo_Llanta, Tipo_Horquilla, Tipo_Componente);
                Formulario.ShowDialog();    
            }
            catch (System.ArgumentException)
            {
            }
        }
        public void Cargar_Login_Login()
        {
            //Apertura de la conexión de la BD.
            SqlCommand cmd = new SqlCommand();
            conexion.Open();
            cmd.Connection = conexion;
            //Consulta
            cmd.CommandText = "SELECT Nombre_Login_conectado FROM Registro_Login ";
            SqlDataReader DataReader = cmd.ExecuteReader();
            string getdato;
            while (DataReader.Read())
            {
                //Paso de valor en la variables de los tipos de getdato.
                getdato = DataReader.GetString(0);
                LabelLogin.Text = getdato;               
            }
            //Cierre tanto del DataReader como de la conexión a la BD.
            DataReader.Close();          
            conexion.Close();
        }
    }
}

