using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//Estas librerias es necesaria para trabajar con el excel de la factura
using Excel = Microsoft.Office.Interop.Excel; 
using System.Reflection;
//Librerias para el color.
using System.Drawing;

namespace Cannondale
{
    public partial class Factura_CAADOptimo :ComboBoxHorquillaEquipos
    {
        //Definición de la conectividad a la base de datos, en este caso le he llamado cannondale por el nombre de la aplicación.
        readonly SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=cannondale; Integrated Security=SSPI");                                      
        readonly private string varglobalLoginlogueado, varglobalvalorCuadro, varglobalvalorColor, varglobalvalorLlantas, varglobalvalorHorquillas,varglobalvalorComponentes, varglobalcomboCuadro, varglobalcomboColor, varglobalcomboLlantas, varglobalcomboHorquillas,varglobalcomboComponentes;
        public string totaldatagrid;
        public Factura_CAADOptimo(string valorLoginlogueado,string valorCuadro,string valorColor,string valorLlantas,string valorHorquillas,string valorComponentes,string comboCuadro,string comboColor,string comboLlantas,string comboHorquillas,string comboComponentes)
        {
            //Cargar variables globales con los valores recogidos.
            InitializeComponent();
            LabelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            varglobalvalorCuadro = valorCuadro;
            varglobalvalorColor = valorColor;
            varglobalvalorLlantas = valorLlantas;
            varglobalvalorHorquillas = valorHorquillas;
            varglobalvalorComponentes = valorComponentes;
            varglobalcomboCuadro = comboCuadro;
            varglobalcomboColor = comboColor;
            varglobalcomboLlantas = comboLlantas;
            varglobalcomboHorquillas = comboHorquillas;
            varglobalcomboComponentes = comboComponentes;
            varglobalLoginlogueado = valorLoginlogueado;
        }       
        public void Registrar_Venta()
        {
            SqlCommand comandosql = new SqlCommand();
            SqlTransaction mitransaccion;
            //Apertura de la conexión de la BD.
            conexion.Open();
            mitransaccion = conexion.BeginTransaction();
            comandosql.Connection = conexion;
            comandosql.Transaction = mitransaccion;
            //Consulta para obtener todos los valores necesarios para registrarlos en el apartado de ventas (Requisito necesario en la práctica.)
            comandosql.CommandText = "INSERT into Registro_Ventas (Vendedor,Nombre_Cliente,Apellido1_Cliente,Apellido2_Cliente,Direccion_Cliente,Telefono_Cliente,Mail_Cliente,Fecha_venta,Precio_Venta) values ('" + LabelLoginLogueado.Text + "','" + TextBoxNombre.Text + "','" + TextBoxApellido1.Text + "','" + TextBoxApellido2.Text + "','" + TextBoxDireccion.Text + "','" + TextBoxTelefono.Text + "','" + TextBoxMail.Text + "','" + LabelFecha.Text + "','" +totaldatagrid + "')";
            comandosql.ExecuteNonQuery();
            mitransaccion.Commit();
            //Cierre de la conexión a la BD.
            this.Close();                
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Se cargan valores con las variables definidas anteriormente.
            LabelLoginLogueado.Text = varglobalLoginlogueado;
            DataGridFactura.BackgroundColor = Color.Khaki;
            DataGridFactura.Rows.Add(varglobalcomboCuadro, varglobalvalorCuadro);
            DataGridFactura.Rows.Add(varglobalcomboColor, varglobalvalorColor);
            DataGridFactura.Rows.Add(varglobalcomboLlantas, varglobalvalorLlantas);
            DataGridFactura.Rows.Add(varglobalcomboHorquillas, varglobalvalorHorquillas);
            DataGridFactura.Rows.Add(varglobalcomboComponentes, varglobalvalorComponentes);
            int suma = 0;
            //Se incorpora un foreach para recorrer el datagrid que alberga los datos de factura para mostrarlos posteriormente en un excell.
            foreach (DataGridViewRow fila in DataGridFactura.Rows)
            {
                //Condicional para comprobar si hay algún campo que se encuentre vacio.
                if (fila.Cells["Precio"].Value != null)
                {
                    //Conversión de los valores para proceder a la suma total.
                    var valor = Convert.ToInt32(fila.Cells["Precio"].Value);
                    suma += valor;
                }                
            }
            // Se agrega la suma total realizada anteriormente al datagrid.
            DataGridFactura.Rows.Add("Total", suma);
            //Se preparada el dato para incorporarlo en la bd.
            totaldatagrid = Convert.ToString(suma);
            //Necesario para el formateo de color.
            foreach (DataGridViewRow row in DataGridFactura.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Khaki;
            }
        }
        private void ToolStripMenuItemCAADOptimo_Click(object sender, EventArgs e)
        {
            SqlCommand comandosql = new SqlCommand();
            SqlTransaction mitransaccion;
            //Apertura de la conexión de la BD.
            conexion.Open();
            mitransaccion = conexion.BeginTransaction();
            comandosql.Connection = conexion;
            comandosql.Transaction = mitransaccion;
            //Consulta para obtener todos los valores necesarios para registrarlos en el apartado de login (Requisito necesario en la práctica.)
            comandosql.CommandText = "INSERT into Registro_Login (Nombre_Login_conectado) values ('" + LabelLoginLogueado.Text + "')";
            comandosql.ExecuteNonQuery();
            mitransaccion.Commit();
            conexion.Close();
            ComboBoxHorquillaEquipos formulario = new ComboBoxHorquillaEquipos();
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BotonNuevoCliente_Click(object sender, EventArgs e)
        {
            //Llamada a un formualrio para agregar clientes y además que lo muestre. 
            Clientes FormularioCliente = new Clientes();
            FormularioCliente.ShowDialog();
            //Se cargan valores con las variables definidas anteriormente.
            TextBoxDNI.Text = FormularioCliente.Id_DNI;
            TextBoxNombre.Text = FormularioCliente.Nombre;
            TextBoxApellido1.Text = FormularioCliente.Apellido1;
            TextBoxApellido2.Text = FormularioCliente.Apellido2;
            TextBoxDireccion.Text = FormularioCliente.Direccion;
            TextBoxTelefono.Text = FormularioCliente.Telefono;
            TextBoxMail.Text = FormularioCliente.Mail;
        }
        private void BotonBuscarCliente_Click(object sender, EventArgs e)
        {
            //Llamada a un formualrio para buscar clientes y además que lo muestre. 
            Buscar_Clientes Buscar = new Buscar_Clientes();
            Buscar.ShowDialog();
            //Se cargan valores con las variables definidas anteriormente.
            TextBoxDNI.Text = Buscar.Id_DNI;
            TextBoxNombre.Text = Buscar.Nombre;
            TextBoxApellido1.Text = Buscar.Apellido1;
            TextBoxApellido2.Text = Buscar.Apellido2;
            TextBoxDireccion.Text = Buscar.Direccion;
            TextBoxTelefono.Text = Buscar.Telefono;
            TextBoxMail.Text = Buscar.Mail;            
        }
        private void BotonFinalizarCompra_Click(object sender, EventArgs e)
        {
            Registrar_Venta();
            if (TextBoxDNI.Text == "")
            {
                MessageBox.Show("Agregue los datos necesarios del cliente");
            }
            else
            {
                MessageBox.Show("La compra se ha realizado correctamente");
                //Generación de la aplicación de excel que se va a hacer uso de ella.
                Excel.Application ObjetoExcel = new Excel.Application();
                //Deshabilitamos la visibilidad del excell con false.
                ObjetoExcel.Visible = false; 
                //Generamos un excell
                Excel.Workbook ObjetoLibro = ObjetoExcel.Workbooks.Add(Missing.Value);
                //En esta Tarea se ha trabajado sobre una hoja. Abrimos la hoja.
                Excel.Worksheet ObjetoHoja = (Microsoft.Office.Interop.Excel.Worksheet)ObjetoLibro.Worksheets.get_Item(1);


                //Imagen logo en factura.
                //Ayuda: https://social.msdn.microsoft.com/Forums/es-ES/ef176b87-cdb1-4b24-adc9-f269866a87ee/insertar-imagen-a-excel-desde-c?forum=vcses
                Microsoft.Office.Interop.Excel.Range Rango;
                Rango = (Microsoft.Office.Interop.Excel.Range)ObjetoHoja.get_Range("B1", "B2");
                Rango.Select();//Me marca esta linea el error.

                Microsoft.Office.Interop.Excel.Pictures oPictures = (Microsoft.Office.Interop.Excel.Pictures)ObjetoHoja.Pictures(System.Reflection.Missing.Value);

                ObjetoHoja.Shapes.AddPicture(@"C:\Users\AdriRios98\source\repos\PracticaFinalCannondale\Cannondale\Imagenes\cannondalelogo.png",
                Microsoft.Office.Core.MsoTriState.msoFalse,
                Microsoft.Office.Core.MsoTriState.msoCTrue,
                float.Parse(Rango.Left.ToString()), float.Parse(Rango.Top.ToString()),
                float.Parse(Rango.Width.ToString()), float.Parse(Rango.Height.ToString()));
                try
                {
                    //Bucle para recorrer las filas, primero se deben contar para saber cual es el máximo.
                    for (int i = 0; i < DataGridFactura.Rows.Count; i++)
                    {
                        //Localizar la ubicación de la fila en la que nos encontramos en la iteración anterior del bucle.
                        DataGridViewRow fila = DataGridFactura.Rows[i];
                        //útlimo for para localizar esta vez la columna (fila x columna)
                        for (int j = 0; j < fila.Cells.Count; j++)
                        {
                            //Agregar los datos que se desean incorporar en el excel y así tener una factura.
                            ObjetoExcel.Columns.ColumnWidth = 30;
                            ObjetoExcel.Cells[1,1] = "Factura simplificada Cannondale";
                            ObjetoExcel.Cells[2,1] = "Datos del comprador";
                            ObjetoExcel.Cells[3,1] = "Nombre: " + TextBoxNombre.Text;
                            ObjetoExcel.Cells[3,2] = "Apellidos: " + TextBoxApellido1.Text + " " + TextBoxApellido2.Text;
                            ObjetoExcel.Cells[4,1] = "DNI: " + TextBoxDNI.Text;
                            ObjetoExcel.Cells[4,2] = "Dirección: "+TextBoxDireccion.Text;
                            ObjetoExcel.Cells[6,1] = "Tipo de componente";
                            ObjetoExcel.Cells[6,2] = "Precio de cada componente en €";
                            //Añadir colores.
                            //AYUDA: https://www.csharp-console-examples.com/winform/set-background-color-in-excel-cell-using-c/
                            ObjetoExcel.Cells[1,1].Interior.Color = Excel.XlRgbColor.rgbIndianRed;
                            ObjetoExcel.Cells[1,2].Interior.Color = Excel.XlRgbColor.rgbIndianRed;
                            ObjetoExcel.Cells[2,1].Interior.Color = Excel.XlRgbColor.rgbIndianRed;
                            ObjetoExcel.Cells[2,2].Interior.Color = Excel.XlRgbColor.rgbIndianRed;
                            ObjetoExcel.Cells[3,1].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[3,2].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[4,1].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[4,2].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[6,1].Interior.Color = Excel.XlRgbColor.rgbIndianRed;
                            ObjetoExcel.Cells[6,2].Interior.Color = Excel.XlRgbColor.rgbIndianRed;
                            ObjetoExcel.Cells[7,1].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[7,2].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[8,1].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[8,2].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[9,1].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[9,2].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[10,1].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[10,2].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[11,1].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[11,2].Interior.Color = Excel.XlRgbColor.rgbAqua;
                            ObjetoExcel.Cells[12,1].Interior.Color = Excel.XlRgbColor.rgbOrange;
                            ObjetoExcel.Cells[12,2].Interior.Color = Excel.XlRgbColor.rgbOrange;
                            // Esto es importante debido a problemas que ha dado durante el desarrollo de este proyecto
                            // El indice del datagrid es un valor menos que el que aparece en el excel, para solucionar el problema
                            // Se ha decidido sumar uno y así todo encaje.
                            ObjetoExcel.Cells[i + 7,j + 1] = fila.Cells[j].Value;
                        }
                    //Ahora si habilitamos que el excel se visualice.
                     ObjetoExcel.Visible = true;
                    }
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                }
                //Cierre de todo el proceso.
                this.Close();
            }
        }
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            //Cierre de la aplicación.
            this.Close();
        }
    }
}
