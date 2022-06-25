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
    public partial class Form_Acceso_Inicio : Form
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=cannondale; Integrated Security=SSPI");
        // Definición de la carpeta donde se encuentra las imagenes que van a ser empleadas.
        readonly string RutaFotos = @"..\..\Imagenes\";
        public Form_Acceso_Inicio()
        {
            InitializeComponent();
        }

        public void Login(string Login,string password)
        {
            //Control de excepciones incorporado para tener un control de error.
            try
            {
                //Abrir conexión de la BD.
                conexion.Open();
                //Consulta de usuario y pass para iniciar la conexión y realizar login.
                SqlCommand comandos = new SqlCommand("SELECT Nombre,Tipo_Login FROM Login WHERE Login=@Login AND Password=@pass",conexion);
                //En las siguientes 2 lineas se consigue comparar los datos de la BD con lo recogido en los textbox.
                comandos.Parameters.AddWithValue("Login", Login);          
                comandos.Parameters.AddWithValue("pass", password);             
                SqlDataAdapter DatosApdatador = new SqlDataAdapter(comandos);
                //Creación de DatosTabla para albergar los datos de la tabla.
                DataTable DatosTabla = new DataTable();
                //Cargamos los datos en el DatosTabla con el dataapdater definido anteriormente.
                DatosApdatador.Fill(DatosTabla);
                /*Se genera un condicional para ver si hay datos existentes ya.

                AYUDA: https://www.youtube.com/watch?v=dPJe14ul5ks
                https://rjcodeadvance.com/cap-2-login-logout-y-mostrar-datos-del-usuario-validaciones-con-arquitectura-en-capas-poo-c-y-mysql-nivel-intermedio/
                https://docs.microsoft.com/es-es/dotnet/api/system.web.ui.webcontrols.login?view=netframework-4.8
                */
                if (DatosTabla.Rows.Count==1) 
                {
                    this.Hide();
                    //En función del rol se abre un formulario u otro.
                    //Apartado para el usuario con tipo de rol de Administrador.
                    if (DatosTabla.Rows[0][1].ToString() == "Administrador")
                    {
                        new Menu_Administradores(Login).Show();  
                    }
                    //Apartado para el usuario con tipo de rol de Ventas.
                    else if (DatosTabla.Rows[0][1].ToString() == "Ventas")
                    {
                        new Menu_Ventas(Login).Show();                        
                    }
                    //Apartado para el usuario con tipo de rol de Coordinador de sala.
                    else if (DatosTabla.Rows[0][1].ToString() == "Coordinador de sala")
                    {
                        new Menu_Coordinador(Login).Show();
                    }
                }
                else
                {
                    //Mensaje de error en caso de que el usuario o contraseña no sea correcto (No sea encontrado en la BD)
                    MessageBox.Show("El usuario o la contraseña introducida es incorrecto");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                //Pase lo que pase que se cierre la conexión a la BD.
                conexion.Close();
            }

        }
        private void Acceso_Inicio_Load(object sender, EventArgs e)
        {
            PictureBoxLogin.Image = Image.FromFile(RutaFotos + "cannondalelogo.png"); //Carfamos logo
        }

       
        private void BotonIniciarSesion_Click(object sender, EventArgs e)
        {
            // En el boton de iniciar sesion, al pulsar se llama a la función de Login. Se pasa por parametro el campo del text de user y de la pass.
            Login(TextBoxLogin.Text, TextBoxPassword.Text);
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LabelPass_Click(object sender, EventArgs e)
        {
        }
    }
}
