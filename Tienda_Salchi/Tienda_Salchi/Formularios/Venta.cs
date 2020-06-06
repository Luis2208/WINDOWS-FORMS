using MySql.Data.MySqlClient;
using Salchichoneria.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Types;

namespace Tienda_Salchi.Formularios
{
    public partial class Venta : Form
    {
        MySqlConnection ms = Conexion.obtenerConexion();
        MySqlCommand comando;
        MySqlDataAdapter data;
        DataTable table;
        double subtotal = 0;
        
        public Venta(string nombre)
        {
            InitializeComponent();
            lblMensaje.Text = nombre;
            
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            //cboBxCategoria.SelectedIndex = ;
            TxtBxCantidad.Text = "";
            txtBxEnlace.Text = "";
            textBox1.Text = "";
            txtBxCa.Text = "";
            //lbltot.Text = "";
        }
        public DataTable getData(string consulta)
        {
            comando = new MySqlCommand(consulta,Conexion.obtenerConexion());
            data = new MySqlDataAdapter(comando);
            table = new DataTable();
            data.Fill(table);
            return table;
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            label1.Text= DateTime.Now.Date.ToString().Substring(0, 10);//Este label, tiene contenida la fecha
            labelhora.Text = DateTime.Now.ToString("hh:mm:ss");//Este label tiene contenida la hora
            VerContactos();//aquí se carga los productos, el metodo se llama verContactos()pero carga los productos. 
            Random rm = new Random();//Esta instancia, permite gener numeros aleatorios que será el de los clientes
            txtBxcliente.Text = Convert.ToString(rm.Next(0, 1000));//Aquí se manda a mostrar en el textBox
         

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Este codigo es para leer la imagen, pero tuve problemas con el picture box, que no me quitaba la imagen
        //seleccionar otra, que decidí retirarlo
        /*private string LeerImagen()
        {
            string path = "";
            string Consulta = "SELECT Imagen FROM producto";
            MySqlCommand my = new MySql.Data.MySqlClient.MySqlCommand(Consulta, Conexion.obtenerConexion());
            try
            {
                MySqlDataReader rd = my.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    MemoryStream ms = new MemoryStream((byte[])rd["Imagen"]);
                    Bitmap b = new Bitmap(ms);
                    pictureBox1.Image = b;
                }
                else
                {
                    MessageBox.Show("No se encontró imagen");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
            return path;
        }*/
        private void VerContactos()
        {

            string consulta = "SELECT CodigoProducto,Nombre,Categoria,Precio,Cantidad,Descripcion FROM producto ";
            MySqlConnection conexion = Conexion.obtenerConexion();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conexion);//conectar a la base de datos para hacer la consulta
           

            DataSet ds = new DataSet();
            mda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();
        }

        //Este evento del Keypress es para que cuando el usuario teclee el codigo del producto que desea vender,
        //simplemente ingrese el numero y presione enter para que la información se pase a los textbox que solo tienen
        //el metodo lectura, es por eso que no se pueden manipular ninguno. 
        private void txtbxMosBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                bool ban = false;
                string consultaBD = "SELECT * FROM producto WHERE CodigoProducto=" + txtbxMosBus.Text;
                MySqlDataAdapter mda = new MySqlDataAdapter(consultaBD, Conexion.obtenerConexion());
                //LeerImagen();

                DataSet ds = new DataSet();
                mda.Fill(ds, "producto");
                foreach (DataRow renglon in ds.Tables[0].Rows)
                {
                    if (renglon["CodigoProducto"].ToString() == txtbxMosBus.Text)
                    {
                        textBox1.Text = renglon["CodigoProducto"].ToString();
                        txtNombre.Text = renglon["Nombre"].ToString();
                        cboBxCategoria.Text = renglon["Categoria"].ToString();
                        txtPrecio.Text = renglon["Precio"].ToString();
                        TxtBxCantidad.Text = renglon["Cantidad"].ToString();
                        txtBxEnlace.Text = renglon["Descripcion"].ToString();

                        ban = true;
                    }

                }
                if (!ban)
                {
                    System.Windows.Forms.MessageBox.Show("El registro no existre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerContactos();
                    dataGridView1.Refresh();
                }
            
        }
        }

      
        //Este metodo es el del boton "agregar" una vez que se seleccionó la el producto a llevar, hay que ingresar la cantidad
        //que se quiere de ese producto y despues presionar el boton agregar para que haga los calculos necesarios
        //y llenar la otra tabla que tiene las columnas ya definidas, e ir sumando la columna de total y mostrarla en
        //el label debajo de la tabla
        private void button1_Click_1(object sender, EventArgs e)
        {
            int can;
            double resp, precio;
            double total = 0;
            can = int.Parse(txtBxCa.Text);
            precio = double.Parse(txtPrecio.Text);
            resp = can * precio;
            total = total + resp;
            dataGridViewVenta.Rows.Add(txtBxcliente.Text, txtNombre.Text, cboBxCategoria.Text,txtBxEnlace.Text, txtPrecio.Text, txtBxCa.Text, total );
            double calcular = 0;
            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {
                calcular += Convert.ToDouble(row.Cells["Column6"].Value);
            }
            lbltot.Text = Convert.ToString(calcular);
            limpiar();
            
        }



        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Pronto" + "," + lblMensaje.Text);
            Application.Exit();
        }

        //Este evento del boton "Eliminar" permite eliminar una fila del datagrid, y restal del total a pagar
        //esa cantidad que ya se esta suprimiendo al momento de quitar el producto. 
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewVenta.SelectedRows)
            {
                dataGridViewVenta.Rows.RemoveAt(item.Index);

            }
            double calcular = 0;
            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {
                calcular += Convert.ToDouble(row.Cells["Column6"].Value);
            }
            lbltot.Text = Convert.ToString(calcular);
        }

        //Este evento del boton "comprar" permite insertar la tabla donde se agregan los productos que se lleva el cliente 
        //a la tabla de la base de datos llamada venta
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand agregar = new MySqlCommand("INSERT INTO Venta VALUES(?Cliente, ?Nombre, ?Categoria, ?Descripcion, ?Precio, ?Cantidad, ?Total)", Conexion.obtenerConexion());

            try
            {   //este foreach hace el barrido de filas y columnas para llevar a cabo la insercion. 
                foreach(DataGridViewRow row in dataGridViewVenta.Rows)
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.Add("?Cliente", MySqlDbType.Int16).Value = Convert.ToString(row.Cells["Column7"].Value);
                    agregar.Parameters.Add("?Nombre", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["Column1"].Value);
                    agregar.Parameters.Add("?Categoria", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["Column2"].Value);
                    agregar.Parameters.Add("?Descripcion", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["Column4"].Value);
                    agregar.Parameters.Add("?Precio", MySqlDbType.Decimal).Value = Convert.ToString(row.Cells["Column3"].Value);
                    agregar.Parameters.Add("?Cantidad", MySqlDbType.Int16).Value = Convert.ToString(row.Cells["Column5"].Value);
                    agregar.Parameters.AddWithValue("Total", lbltot.Text);

                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Datos Agregados correctamente");
                    dataGridViewVenta.Rows.Clear();
                    limpiar();
                    
                }
                lbltot.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos");
                Conexion.obtenerConexion().Close();
            }
            
        }
    }
}
