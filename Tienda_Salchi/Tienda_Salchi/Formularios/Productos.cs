using MySql.Data.MySqlClient;
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


namespace Salchichoneria.Formularios
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        //Este metodo es para hacer el llenado del datagrid view.
        private void VerContactos()
        {

            string consulta = "SELECT CodigoProducto,Nombre,Categoria,Precio,Cantidad,Descripcion FROM producto ";
            MySqlConnection conexion = Conexion.Conexion.obtenerConexion();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conexion);//conectar a la base de datos para hacer la consulta

            DataSet ds = new DataSet();
            mda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();

        }
        //Este metodo permite limpiar los textbox, label cuando se presiona el evento de cualquier boton. 
        public void limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            comboBox1.SelectedIndex = 0;
            TxtBxCantidad.Text = "";
            txtBxEnlace.Text = "";
        }
        //Este metodo inhabilita los botones cuando termina una accion,  
        void inhabilitar()
        {
            txtNombre.Enabled = false;
            comboBox1.Enabled = false;
            txtPrecio.Enabled = false;
            TxtBxCantidad.Enabled = false;
            txtBxEnlace.Enabled = false;
;
            btnSave.Enabled = false;
            bttnBuscar.Enabled = false;
            bttnEditar.Enabled = false;
            bttnEliminar.Enabled = false;
        }
        //Este meto habilita los botones, este metodo se manda a llamar en el boton de "Nuevo"
        void habilitar()
        {
            txtNombre.Enabled = true;
            comboBox1.Enabled = true;
            txtPrecio.Enabled = true;
            TxtBxCantidad.Enabled = true;
            txtBxEnlace.Enabled = true;

            btnSave.Enabled = true;
            bttnBuscar.Enabled = true;
            bttnEditar.Enabled = true;
            bttnEliminar.Enabled = true;
        }
        //Este metodo permite que aquellos textbox que solo se deba ingresar letras, unicamente lo permita así
        //si el usuario teclea numeros, la aplicacion le manda una ventana emergente, y este metodo se manda a llamar
        //en el evento "keyPress" de los textbox. 
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Letras");
            }
        }
        //Este metodo permite que aquellos textbox que solo se deba ingresar numeros, unicamente lo permita así
        //si el usuario teclea letras, la aplicacion le manda una ventana emergente, y este metodo se manda a llamar
        //en el evento "keyPress" de los textbox
        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }
        //Este metodo permite que aquellos textbox que solo se deba ingresar numeros con punto decimal, unicamente lo permita así
        //si el usuario teclea letras, la aplicacion le manda una ventana emergente, y este metodo se manda a llamar
        //en el evento "keyPress" de los textbox
        public static void NumerosDecimales(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo numeros o numeros con punto decimal");
            }
        }
        //Este metedo era para el bóton "examinar" con ese metodo se seleccionaba una imagen desde la carpeta de archivos
        //de la computadora.
       /* private string CargarImagen()
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg; *.png *.gif)| *.jpg; *.png; *.gif";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                dialog.Title = "Seleccionar archivo";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
             
                    pictureBox1.Image = Image.FromFile(dialog.FileName);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            return imageLocation = "";
        }*/
        //Con este metodo se leí la imagen aparte desde la base de datos, productos.
        //por ser la ultima columna, pero ya se excepcion
        /*private string LeerImagen()
        {
            string path = "";
            string Consulta = "SELECT Imagen FROM producto";
            MySqlCommand my = new MySql.Data.MySqlClient.MySqlCommand(Consulta, Conexion.Conexion.obtenerConexion());
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

        /* A Este Metodo no le hagas Caso.
        private string GurdarImagen()
        {
            string g = "";
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlConnection connection = Conexion.Conexion.obtenerConexion();
           

            try
            {
                MySqlCommand comando = new MySqlCommand("INSERT INTO foto (Nombre, Imagen) VALUES('" + txtBxEnlace.Text + "',@Imagen)",connection);

                comando.Parameters.AddWithValue("Imagen", img);
                comando.ExecuteNonQuery();
                MessageBox.Show("Imagen guardada");


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar imagen", ex.Message);
            }

            return g;
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {   //Estos if, asegurar que el bóton de guardar no se pueda presionar antes, si en los textbox 
            //aín no se ha ingresado información. 
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un nombre del producto");
                txtNombre.Focus();
                return;
            }
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Debes seleccionar una categoria");
                comboBox1.Focus();
                return;
            }
            if (txtPrecio.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un precio para el producto");
                txtPrecio.Focus();
                return;
            }
            if (TxtBxCantidad.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar una cantidad");
                txtPrecio.Focus();
                return;
            }
            if (txtBxEnlace.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar una descripción para el producto");
                txtBxEnlace.Focus();
                return;
            }
            
    
            

            //Este metodo es donde se insertan los valores a la tabla producto, siempre va en un try/catch para evitar  
            //error en la compilacion
            try
            {
                //MemoryStream ms = new MemoryStream();
                //pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                //byte[] img = ms.ToArray();                                                                                                                                                                                                                                                           
                                                                                                                                                                                                                                                                                            
                string consultaBD = "INSERT INTO producto(Nombre,Categoria,Precio,Cantidad,Descripcion) VALUES('" + txtNombre.Text + "','" + comboBox1.Text + "','" + txtPrecio.Text + "','" + TxtBxCantidad.Text + "','" + txtBxEnlace.Text+"')";
                MySqlCommand mc = new MySql.Data.MySqlClient.MySqlCommand(consultaBD,  Conexion.Conexion.obtenerConexion());
                //mc.Parameters.AddWithValue("Imagen", img);
                mc.ExecuteNonQuery();
                
                //una vez insertada la información se debe cerrar la conexion. 
                Conexion.Conexion.obtenerConexion().Close();
                //Esto permite limpiar los textbox de la informacion que se ingreso, aquí también se puede manda a llamar
                //El metodo limpiar();
                txtNombre.Text = "";
                txtPrecio.Text = "";
                comboBox1.SelectedIndex = 0;
                TxtBxCantidad.Text = "";
                txtBxEnlace.Text = "";
                VerContactos();
                dataGridView1.Refresh();//Esto metodo del datagrid, permite que se actualice cada que se ingresa un dato
                inhabilitar();
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Este metodo es el de la página del from que se esta utilizando en este momento, es el metodo que controla
        //el form en si al cargarlo, por eso tiene los metodos, para cuando se ingrese por primera vez, el form cargue la
        //información
        private void Productos_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            VerContactos();
            inhabilitar();
        }

        //El boton buscar, permite hacer la busqueda del producto de acuerdo a lo que se haya ingresado en el 
        //textbox buscar.
        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            bool ban = false;
            string consultaBD = "SELECT * FROM producto WHERE CodigoProducto=" + txtbxMosBus.Text;
            MySqlDataAdapter mda = new MySqlDataAdapter(consultaBD, Conexion.Conexion.obtenerConexion());
            //LeerImagen();

            //se declara un dataSet, que permitira laa busqueda por el gridView, para despues cargar la informacion
            //en los textbox.
            DataSet ds = new DataSet();
            mda.Fill(ds, "producto");
            foreach (DataRow renglon in ds.Tables[0].Rows)
            {
                if (renglon["CodigoProducto"].ToString() == txtbxMosBus.Text)
                {
                    txtNombre.Text = renglon["Nombre"].ToString();
                    comboBox1.Text = renglon["Categoria"].ToString();
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

        //Boton "Nuevo" que habilitara todo lo démas contenido en la ventana. 
        private void bttNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        //En el boton eliminar se realiza una busqueda primera en la tabla producto,  más no en la aplicacion
        //en la aplicación basta con solo seleccionar una fila en el gridView, y presionar el boton "eliminar"
        //para borrar el registro. 
        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            bool ban = false;
            string consultaBD = "SELECT * FROM producto";
            MySqlDataAdapter mda = new MySqlDataAdapter(consultaBD, Conexion.Conexion.obtenerConexion());

            DataSet ds = new DataSet();
            mda.Fill(ds, "producto");
            foreach (DataRow renglon in ds.Tables[0].Rows)
            {
                if (renglon["CodigoProducto"].ToString() == txtbxMosBus.Text)
                {
                    ban = true;
                }

            }
            if (ban)
            {
                consultaBD = "DELETE FROM producto WHERE CodigoProducto=" + txtbxMosBus.Text;
                MySqlCommand mc = new MySqlCommand(consultaBD, Conexion.Conexion.obtenerConexion());
                mc.ExecuteNonQuery();
                Conexion.Conexion.obtenerConexion().Close();
                VerContactos();
                limpiar();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("El registro no existe");
                VerContactos();
                limpiar();
            }
        }

        //El boton de "editar" en la aplicacion si necesita primero de haber realizado la busqueda, para que se cargue la
        //información en los textbox. 
        private void bttnEditar_Click(object sender, EventArgs e)
        {
            /*MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();*/

            string consultaBD = "UPDATE producto SET Nombre='" + txtNombre.Text + "', Categoria='" + comboBox1.Text + "', Precio='" + txtPrecio.Text + "', Cantidad='" + TxtBxCantidad.Text + "', Descripcion='" + txtBxEnlace.Text + "' WHERE CodigoProducto=" + txtbxMosBus.Text;
            MySqlCommand mc = new MySqlCommand(consultaBD, Conexion.Conexion.obtenerConexion());
            //mc.Parameters.AddWithValue("Imagen", img);
            mc.ExecuteNonQuery();
            Conexion.Conexion.obtenerConexion().Close();
            VerContactos();
            limpiar();
            inhabilitar();
            MessageBox.Show("El registro se actualizo correctamente");
        }

        //Todos son los eventos de los textbox,en estos se mandan a llamar los metodos que controlan
        //el ingreso de solo letras, numeros y numeros decimales. 
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumerosDecimales(e);
        }

        private void TxtBxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtBxEnlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtbxMosBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}

