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
    public partial class Synapse : Template
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=cannondale; Integrated Security=SSPI");
        // Definición de la carpeta donde se encuentra las imagenes que van a ser empleadas.
        readonly string RutaFotos = @"..\..\Imagenes\";     
        public Synapse()
        {
            InitializeComponent();
        }

        //Metodo encargado de cargar todos los datos de la página especializada para Synapse con los datos recogidos de la bbdd (Cuadros)
        public void Cargar_Datos_Cuadro() 
        {
            conexion.Open();
            SqlCommand comandos = new SqlCommand("SELECT Id_Cuadro,Tipo_Cuadro,Precio_Cuadro FROM Cuadros WHERE Modelo_Bicicleta='Synapse'", conexion);
            SqlDataAdapter DatosApdatador = new SqlDataAdapter(comandos);
            //Creación de DatosTabla para albergar los datos de la tabla.
            DataTable DatosTabla = new DataTable();
            //Cargamos los datos en el DatosTabla con el dataapdater definido anteriormente.
            DatosApdatador.Fill(DatosTabla);
            //Cierre conexión a la BD.
            conexion.Close();
            //Se indica el valor del ComboBox cargado con los datos de DatosTabla, estos datos han sido recogidos de la BD.
            ComboBoxCuadro.DataSource = DatosTabla; 
            ComboBoxCuadro.ValueMember = "Id_Cuadro";
            ComboBoxCuadro.DisplayMember = "Tipo_Cuadro"; 
        }
        //Metodo encargado de cargar todos los datos de la página especializada para CAAD Optimo con los datos recogidos de la bbdd (Color)
        public void Cargar_Datos_Color()
        {
            conexion.Open();
            SqlCommand comandos = new SqlCommand("SELECT Id_Color,Tipo_Color,Precio_Color FROM Colores", conexion);
            SqlDataAdapter DatosApdatador = new SqlDataAdapter(comandos);
            //Creación de DatosTabla para albergar los datos de la tabla.
            DataTable DatosTabla = new DataTable();
            //Cargamos los datos en el DatosTabla con el dataapdater definido anteriormente.
            DatosApdatador.Fill(DatosTabla);
            //Cierre conexión a la BD.
            conexion.Close();
            //Se indica el valor del ComboBox cargado con los datos de DatosTabla, estos datos han sido recogidos de la BD.
            ComboBoxColor.DataSource = DatosTabla;
            ComboBoxColor.ValueMember = "Id_Color";
            ComboBoxColor.DisplayMember = "Tipo_Color";
        }
        //Metodo encargado de cargar todos los datos de la página especializada para CAAD Optimo con los datos recogidos de la bbdd (Llantas)
        public void Cargar_Datos_Llantas()
        {
            conexion.Open();
            SqlCommand comandos = new SqlCommand("SELECT Id_Llanta,Tipo_Llanta FROM Llantas", conexion);
            SqlDataAdapter DatosApdatador = new SqlDataAdapter(comandos);
            //Creación de DatosTabla para albergar los datos de la tabla.
            DataTable DatosTabla = new DataTable();
            //Cargamos los datos en el DatosTabla con el dataapdater definido anteriormente.
            DatosApdatador.Fill(DatosTabla);
            //Cierre conexión a la BD.
            conexion.Close();
            //Se indica el valor del ComboBox cargado con los datos de DatosTabla, estos datos han sido recogidos de la BD.
            ComboBoxLlantas.DataSource = DatosTabla;
            ComboBoxLlantas.ValueMember = "Id_Llanta";
            ComboBoxLlantas.DisplayMember = "Tipo_Llanta";
        }
        //Metodo encargado de cargar todos los datos de la página especializada para CAAD Optimo con los datos recogidos de la bbdd (Horquillas)
        public void Cargar_Datos_Horquillas()
        {
            conexion.Open();
            SqlCommand comandos = new SqlCommand("SELECT Id_Horquilla,Tipo_Horquilla FROM Horquillas", conexion);
            SqlDataAdapter DatosApdatador = new SqlDataAdapter(comandos);
            //Creación de DatosTabla para albergar los datos de la tabla.
            DataTable DatosTabla = new DataTable();
            //Cargamos los datos en el DatosTabla con el dataapdater definido anteriormente.
            DatosApdatador.Fill(DatosTabla);
            //Cierre conexión a la BD.
            conexion.Close();
            //Se indica el valor del ComboBox cargado con los datos de DatosTabla, estos datos han sido recogidos de la BD.
            ComboBoxHorquillas.DataSource = DatosTabla;
            ComboBoxHorquillas.ValueMember = "Id_Horquilla";
            ComboBoxHorquillas.DisplayMember = "Tipo_Horquilla";            
        }
        //Metodo encargado de cargar todos los datos de la página especializada para CAAD Optimo con los datos recogidos de la bbdd (Componentes)
        public void Cargar_Datos_Componentes()
        {
            conexion.Open();
            SqlCommand comandos = new SqlCommand("SELECT Id_Componente,Tipo_Componente FROM Componentes", conexion);
            SqlDataAdapter DatosApdatador = new SqlDataAdapter(comandos);
            //Creación de DatosTabla para albergar los datos de la tabla.
            DataTable DatosTabla = new DataTable();
            //Cargamos los datos en el DatosTabla con el dataapdater definido anteriormente.
            DatosApdatador.Fill(DatosTabla);
            //Cierre conexión a la BD.
            conexion.Close();
            //Se indica el valor del ComboBox cargado con los datos de DatosTabla, estos datos han sido recogidos de la BD.
            ComboBoxComponentes.DataSource = DatosTabla;
            ComboBoxComponentes.ValueMember = "Id_Componente";
            ComboBoxComponentes.DisplayMember = "Tipo_Componente";
        }

        //Metodo encargado de cargar todos los datos de la página especializada para CAAD Optimo con los datos recogidos de la bbdd (Usuario registrado en la app)
        public void Cargar_Login_Login()
        {
            SqlCommand cmd = new SqlCommand();
            conexion.Open();
            cmd.Connection = conexion;
            //Consulta para obtener el usuario logueado.
            cmd.CommandText = "SELECT Nombre_Login_conectado FROM Registro_Login ";
            SqlDataReader DataReader = cmd.ExecuteReader();
            string getdato;
            while (DataReader.Read())
            {
                //Se carga en getdato el valor para traspasarlo a la etiqueta definida de LabelLogin.
                getdato = DataReader.GetString(0);
                LabelLogin.Text = getdato;
            }
            //Cierre tanto del DataReader como de la conexión a la BD.
            DataReader.Close();
            conexion.Close();
        }

        //Metodo encargado de vaciar el login.
        public void Vaciar_Tabla_Login()
        {
            SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=cannondale; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandText = "DELETE FROM Registro_Login ";
            cmd.ExecuteNonQuery();
            //Cierre conexión a la BD.
            conexion.Close();
        }

        private void Synapse_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Cuadro();
            Cargar_Datos_Color();
            Cargar_Datos_Llantas();
            Cargar_Login_Login();
            Cargar_Datos_Horquillas();
            Cargar_Datos_Componentes();
            Vaciar_Tabla_Login();
        }

        private void ComboBoxCuadro_SelectedIndexChanged(object sender, EventArgs e)
        {
                //Parte para la definición del tipo de Cuadro
                if (ComboBoxCuadro.Text == "Synapse Carbon 1 RLE")
                {
                    //Parte de la imagen del cuadro (PictureBox)
                    PictureBoxCuadro.Image = Image.FromFile(RutaFotos + "Carbono.jpg");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Cuadro FROM Cuadros WHERE Tipo_Cuadro='Synapse Carbon 1 RLE'";
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    string getdato;
                    while (DataReader.Read())
                    {
                        //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                        getdato = DataReader.GetString(0);
                        LabelPrecioCuadro.Text = getdato;
                    }
                    //Cierre tanto del DataReader como de la conexión a la BD.
                    DataReader.Close();
                    conexion.Close();
                }
                if (ComboBoxCuadro.Text == "Synapse Carbon LTD RLE")
                {
                    //Parte de la imagen del cuadro (PictureBox)
                    PictureBoxCuadro.Image = Image.FromFile(RutaFotos + "Carbono.jpg");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Cuadro FROM Cuadros WHERE Tipo_Cuadro='Synapse Carbon LTD RLE'";
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    string getdato;
                    while (DataReader.Read())
                    {
                       //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                        getdato = DataReader.GetString(0);
                        LabelPrecioCuadro.Text = getdato;
                    }
                    //Cierre tanto del DataReader como de la conexión a la BD.
                    DataReader.Close();
                    conexion.Close();
                }
                if (ComboBoxCuadro.Text == "Synapse Carbon 2 RLE")
                {
                    //Parte de la imagen del cuadro (PictureBox)
                    PictureBoxCuadro.Image = Image.FromFile(RutaFotos + "Carbono.jpg");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Cuadro FROM Cuadros WHERE Tipo_Cuadro='Synapse Carbon 2 RLE'";
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    string getdato;
                    while (DataReader.Read())
                    {
                        //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                        getdato = DataReader.GetString(0);
                        LabelPrecioCuadro.Text = getdato;
                    }
                    //Cierre tanto del DataReader como de la conexión a la BD.
                    DataReader.Close();
                    conexion.Close();
                }
            if (ComboBoxCuadro.Text == "Synapse Carbon 2 RL")
                {
                    PictureBoxCuadro.Image = Image.FromFile(RutaFotos + "Carbono.jpg");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Cuadro FROM Cuadros WHERE Tipo_Cuadro='Synapse Carbon 2 RL'";
                   SqlDataReader DataReader = cmd.ExecuteReader();
                   string getdato;
                   while (DataReader.Read())
                   {
                      //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                     getdato = DataReader.GetString(0);
                     LabelPrecioCuadro.Text = getdato;
                 }
                 //Cierre tanto del DataReader como de la conexión a la BD.
                  DataReader.Close();
                  conexion.Close();
               }
            if (ComboBoxCuadro.Text == "Synapse Carbon 3 L")
                {
                    PictureBoxCuadro.Image = Image.FromFile(RutaFotos + "Carbono.jpg");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Cuadro FROM Cuadros WHERE Tipo_Cuadro='Synapse Carbon 3 L'";
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    string getdato;
                    while (DataReader.Read())
                    {
                       //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                       getdato = DataReader.GetString(0);
                       LabelPrecioCuadro.Text = getdato;
                    }
                  //Cierre tanto del DataReader como de la conexión a la BD.
                   DataReader.Close();
                  conexion.Close();
                }
        }

        private void ComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (ComboBoxColor.Text == "Apilne")
                {
                    //Imagen de color y alternativa en el modelo de bici.
                    PictureBoxColor.Image = Image.FromFile(RutaFotos + "Alpine.JPG");
                    PictureBoxBicicleta.Image = Image.FromFile(RutaFotos + "Sypnase_Alpine.jpg");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Color FROM Colores WHERE Tipo_Color='Apilne'";
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    string getdato;
                    while (DataReader.Read())
                    {
                        //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                        getdato = DataReader.GetString(0);
                        LabelPrecioColor.Text = getdato;
                    }
                    //Cierre tanto del DataReader como de la conexión a la BD.
                    DataReader.Close();
                    conexion.Close();
                }
            if (ComboBoxColor.Text == "Blanco")
                {
                    //Imagen de color y alternativa en el modelo de bici.
                    PictureBoxColor.Image = Image.FromFile(RutaFotos + "Blanco.JPG");
                    PictureBoxBicicleta.Image = Image.FromFile(RutaFotos + "Sypnase_Blanco.jpg");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Color FROM Colores WHERE Tipo_Color='Blanco'";
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    string getdato;
                    while (DataReader.Read())
                    {
                        //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                        getdato = DataReader.GetString(0);
                        LabelPrecioColor.Text = getdato;
                    }
                    //Cierre tanto del DataReader como de la conexión a la BD.
                    DataReader.Close();
                    conexion.Close();
                }
            if (ComboBoxColor.Text == "Gris")
                {
                    //Imagen de color y alternativa en el modelo de bici.
                    PictureBoxColor.Image = Image.FromFile(RutaFotos + "Gray.JPG");
                    PictureBoxBicicleta.Image = Image.FromFile(RutaFotos + "Sypnase_Gray.jpg");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Color FROM Colores WHERE Tipo_Color='Gris'";
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    string getdato;
                    while (DataReader.Read())
                    {
                        //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                        getdato = DataReader.GetString(0);
                        LabelPrecioColor.Text = getdato;
                    }
                    //Cierre tanto del DataReader como de la conexión a la BD.
                    DataReader.Close();
                    conexion.Close();
                }
            if (ComboBoxColor.Text == "Rojo")
                {
                    //Imagen de color y alternativa en el modelo de bici.
                    PictureBoxColor.Image = Image.FromFile(RutaFotos + "Rojo.JPG");
                    PictureBoxBicicleta.Image = Image.FromFile(RutaFotos + "Sypnase_Rojo.JPG");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Color FROM Colores WHERE Tipo_Color='Rojo'";
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    string getdato;
                    while (DataReader.Read())
                    {
                        //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                        getdato = DataReader.GetString(0);
                        LabelPrecioColor.Text = getdato;
                    }
                    //Cierre tanto del DataReader como de la conexión a la BD.
                    DataReader.Close();
                    conexion.Close();
                }
            if (ComboBoxColor.Text == "Negro")
                {
                    //Imagen de color y alternativa en el modelo de bici.
                    PictureBoxColor.Image = Image.FromFile(RutaFotos + "Negro.JPG");
                    PictureBoxBicicleta.Image = Image.FromFile(RutaFotos + "Synapse_Negro.JPG");
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Precio_Color FROM Colores WHERE Tipo_Color='Negro'";
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    string getdato;
                    while (DataReader.Read())
                    {
                        //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                        getdato = DataReader.GetString(0);
                        LabelPrecioColor.Text = getdato;
                    }
                    //Cierre tanto del DataReader como de la conexión a la BD.
                    DataReader.Close();
                    conexion.Close();
                }
        }

        private void ComboBoxLlantas_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (ComboBoxLlantas.Text == "Cubierta")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxLlantas.Image = Image.FromFile(RutaFotos + "Cubierta.JPG");           
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Llanta FROM Llantas WHERE Tipo_Llanta='Cubierta'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioLlantas.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
            if (ComboBoxLlantas.Text == "Tubular")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxLlantas.Image = Image.FromFile(RutaFotos + "Tubulares.JPG");        
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Llanta FROM Llantas WHERE Tipo_Llanta='Tubular'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioLlantas.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
            if (ComboBoxLlantas.Text == "Tubeless")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxLlantas.Image = Image.FromFile(RutaFotos + "Tubeless.JPG");
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Llanta FROM Llantas WHERE Tipo_Llanta='Tubeless'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioLlantas.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
            if (ComboBoxLlantas.Text == "TPI")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxLlantas.Image = Image.FromFile(RutaFotos + "TPI.JPG");
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Llanta FROM Llantas WHERE Tipo_Llanta='TPI'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioLlantas.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
        }

        private void ComboBoxHorquillas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHorquillas.Text == "Modelo Basic")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxHorquillas.Image = Image.FromFile(RutaFotos + "Horquilla_Basic.JPG");
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Horquilla FROM Horquillas WHERE Tipo_Horquilla='Modelo Basic'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioHorquillas.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
            if (ComboBoxHorquillas.Text == "Modelo Basic Sin Rosca")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxHorquillas.Image = Image.FromFile(RutaFotos + "Horquilla_Basic_sin_rosca.JPG");
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Horquilla FROM Horquillas WHERE Tipo_Horquilla='Modelo Basic Sin Rosca'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioHorquillas.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
            if (ComboBoxHorquillas.Text == "Modelo Medium")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxHorquillas.Image = Image.FromFile(RutaFotos + "Horquilla_Medium.JPG");            
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Horquilla FROM Horquillas WHERE Tipo_Horquilla='Modelo Medium'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioHorquillas.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
            if (ComboBoxHorquillas.Text == "Modelo PRO")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxHorquillas.Image = Image.FromFile(RutaFotos + "Horquilla_Pro_con_suspension.JPG");
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Horquilla FROM Horquillas WHERE Tipo_Horquilla='Modelo PRO'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioHorquillas.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
        }

        private void ComboBoxComponentes_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (ComboBoxComponentes.Text == "Sillin")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxComponentes.Image = Image.FromFile(RutaFotos + "Sillin.JPG");            
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Componente FROM Componentes WHERE Tipo_Componente='Sillin'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de LabelLogin.
                    getdato = DataReader.GetString(0);
                    LabelPrecioComponentes.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }

            if (ComboBoxComponentes.Text == "Manillar")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxComponentes.Image = Image.FromFile(RutaFotos + "Manillar.JPG");      
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Componente FROM Componentes WHERE Tipo_Componente='Manillar'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioComponentes.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
            if (ComboBoxComponentes.Text == "Potencia")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxComponentes.Image = Image.FromFile(RutaFotos + "Potencia.JPG");
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Componente FROM Componentes WHERE Tipo_Componente='Potencia'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioComponentes.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
            if (ComboBoxComponentes.Text == "Pedales")
            {
                //Parte de la imagen del cuadro (PictureBox)
                PictureBoxComponentes.Image = Image.FromFile(RutaFotos + "Pedales.jpg");
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT Precio_Componente FROM Componentes WHERE Tipo_Componente='Pedales'";
                SqlDataReader DataReader = cmd.ExecuteReader();
                string getdato;
                while (DataReader.Read())
                {
                    //Se carga en getdato el valor para traspasarlo a la etiqueta definida de Label
                    getdato = DataReader.GetString(0);
                    LabelPrecioComponentes.Text = getdato;
                }
                //Cierre tanto del DataReader como de la conexión a la BD.
                DataReader.Close();
                conexion.Close();
            }
        }

        private void BotonTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Lo incorporamos en un cvontrol de excepciones para controlar obviamente los posibles errores.
                Factura_CAADOptimo Formulario = new Factura_CAADOptimo(LabelLogin.Text, LabelPrecioCuadro.Text, LabelPrecioColor.Text, LabelPrecioLlantas.Text, LabelPrecioHorquillas.Text, LabelPrecioComponentes.Text, ComboBoxCuadro.Text, ComboBoxColor.Text, ComboBoxLlantas.Text, ComboBoxHorquillas.Text, ComboBoxComponentes.Text);
                //Incorporar el formularío en el padre para que aparezca dentro de el y además se muestra con el ShowDialog.
                Formulario.Dock = DockStyle.Fill;
                Formulario.ShowDialog();  
            }
            catch (System.ArgumentException)
            {

            }
        }

        private void PictureBoxCuadro_Click(object sender, EventArgs e)
        {

        }
    }
}