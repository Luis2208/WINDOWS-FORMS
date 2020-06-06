using MySql.Data.MySqlClient;
using Salchichoneria.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Salchi.Formularios
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }


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


        private void VerUsuarios()
        {

            string consulta = "SELECT * FROM Usuarios";
            MySqlConnection conexion = Conexion.obtenerConexion();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conexion);//conectar a la base de datos para hacer la consulta

            DataSet ds = new DataSet();
            mda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();

        }

        void inhabilitar()
        {
            txtBxNombre.Enabled = false;
            txtBxApe.Enabled = false;
            txtBxCiudad.Enabled = false;
            txtBxCorreo.Enabled = false;
            mkdTxtBxNumero.Enabled = false;
            cboBxPerfil.Enabled = false;
            txtBxContra.Enabled = false;
            txtBoxBuscar.Enabled = false;

            btnSave.Enabled = false;
            bttnBuscar.Enabled = false;
            bttnEditar.Enabled = false;
            bttnEliminar.Enabled = false;
        }

        void habilitar()
        {
            txtBxNombre.Enabled = true;
            txtBxApe.Enabled = true;
            txtBxCiudad.Enabled = true;
            txtBxCorreo.Enabled = true;
            mkdTxtBxNumero.Enabled = true;
            cboBxPerfil.Enabled = true;
            txtBxContra.Enabled = true;
            txtBoxBuscar.Enabled = true;

            btnSave.Enabled = true;
            bttnBuscar.Enabled = true;
            bttnEditar.Enabled = true;
            bttnEliminar.Enabled = true;
        }

        public void limpiar()
        {
            txtBxNombre.Text ="";
            txtBxApe.Text = "";
            txtBxCiudad.Text = "";
            txtBxCorreo.Text = "";
            mkdTxtBxNumero.Text = "";
            cboBxPerfil.SelectedIndex = 0;
            txtBxContra.Text = "";
        }

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBxNombre.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un Nombre");
                txtBxNombre.Focus();
                return;
            }
            if (txtBxApe.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar Apellidos");
                txtBxApe.Focus();
                return;
            }
            if (txtBxCiudad.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar una Ciudad");
                txtBxApe.Focus();
                return;
            }
            if (txtBxCorreo.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un correo electronico");
                txtBxCorreo.Focus();
                return;
            }
            if (txtBxContra.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar una contraseña");
                txtBxContra.Focus();
                return;
            }
            if (cboBxPerfil.Text.Length == 0)
            {
                MessageBox.Show("Debes seleccionar un Perfil");
                cboBxPerfil.Focus();
                return;
            }
          
            try
            {
              
                string consultaBD = "INSERT INTO Usuarios(NomUsuario,ApeUsuario,CiudUsuario,Correo,Telefono,ClaveUsuario,Perfil) VALUES('" + txtBxNombre.Text + "','" + txtBxApe.Text + "','" + txtBxCiudad.Text + "','" + txtBxCorreo.Text + "','" + mkdTxtBxNumero.Text + "','" + txtBxContra.Text + "','" + cboBxPerfil.Text +"')";
                MySqlCommand mc = new MySql.Data.MySqlClient.MySqlCommand(consultaBD, Conexion.obtenerConexion());
                mc.ExecuteNonQuery();

                Conexion.obtenerConexion().Close();
                txtBxNombre.Text = "";
                txtBxApe.Text = "";
                txtBxCiudad.Text = "";
                txtBxCorreo.Text = "";
                mkdTxtBxNumero.Text = "";
                cboBxPerfil.SelectedIndex = 0;
                txtBxContra.Text = "";

                VerUsuarios();
                dataGridView1.Refresh();
                inhabilitar();
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            inhabilitar();
            VerUsuarios();
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            bool ban = false;
            string consultaBD = "SELECT * FROM Usuarios WHERE CodUsuario=" + txtBoxBuscar.Text;
            MySqlDataAdapter mda = new MySqlDataAdapter(consultaBD, Conexion.obtenerConexion());
           

            DataSet ds = new DataSet();
            mda.Fill(ds, "Usuarios");
            foreach (DataRow renglon in ds.Tables[0].Rows)
            {
                if (renglon["CodUsuario"].ToString() == txtBoxBuscar.Text)
                {
                    txtBxNombre.Text = renglon["NomUsuario"].ToString();
                    txtBxApe.Text = renglon["ApeUsuario"].ToString();
                    txtBxCiudad.Text = renglon["CiudUsuario"].ToString();
                    txtBxCorreo.Text = renglon["Correo"].ToString();
                    mkdTxtBxNumero.Text = renglon["Telefono"].ToString();
                    txtBxContra.Text = renglon["ClaveUsuario"].ToString();
                    cboBxPerfil.Text = renglon["Perfil"].ToString();
                    ban = true;
                }

            }
            if (!ban)
            {
                System.Windows.Forms.MessageBox.Show("El registro no existre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VerUsuarios();
                dataGridView1.Refresh();
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            bool ban = false;
            string consultaBD = "SELECT * FROM Usuarios";
            MySqlDataAdapter mda = new MySqlDataAdapter(consultaBD, Conexion.obtenerConexion());

            DataSet ds = new DataSet();
            mda.Fill(ds, "Usuarios");
            foreach (DataRow renglon in ds.Tables[0].Rows)
            {
                if (renglon["CodUsuario"].ToString() == txtBoxBuscar.Text)
                {
                    ban = true;
                }

            }
            if (ban)
            {
                consultaBD = "DELETE FROM Usuarios WHERE CodUsuario=" + txtBoxBuscar.Text;
                MySqlCommand mc = new MySqlCommand(consultaBD, Conexion.obtenerConexion());
                mc.ExecuteNonQuery();
                Conexion.obtenerConexion().Close();
                VerUsuarios();
                limpiar();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("El registro no existe");
                VerUsuarios();
                limpiar();
            }
        }

        private void bttnEditar_Click(object sender, EventArgs e)
        {
            string consultaBD = "UPDATE Usuarios SET NomUsuario='" + txtBxNombre.Text + "', ApeUsuario='" + txtBxApe.Text + "', CiudUsuario='" + txtBxCiudad.Text + "', Correo='" + txtBxCorreo.Text + "', Telefono='" + mkdTxtBxNumero.Text + "', ClaveUsuario='" + txtBxContra.Text + "', Perfil='" + cboBxPerfil.Text + "' WHERE CodUsuario=" + txtBoxBuscar.Text;
            MySqlCommand mc = new MySqlCommand(consultaBD, Conexion.obtenerConexion()); 
            mc.ExecuteNonQuery();
            Conexion.obtenerConexion().Close();
            VerUsuarios();
            limpiar();
            MessageBox.Show("El registro se actualizo correctamente");
        }

        private void txtBxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            email_bien_escrito(txtBxCorreo.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtBxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtBxApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtBxCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
    }
}
