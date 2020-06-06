using MySql.Data.MySqlClient;
using Salchichoneria.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_Salchi.Formularios;

namespace Salchichoneria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBx_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBx.Checked == true)
            {
                if(txtBxPass.PasswordChar == '*')
                {
                    txtBxPass.PasswordChar = '\0';
                }
            }
            else
            {
                txtBxPass.PasswordChar = '*';
            }
        }

        //Con este metodo en el bóton salir, le pregunta al usuario si desea salir de la aplicación
        //esperando la confirmación, finaliza el programa.
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea salir de la aplicación?", "title", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                this.Close();

        }

        //En evento del boton entrar, se manda a llamar el metodo loguear
        private void button1_Click(object sender, EventArgs e)
        {
            loguear(this.txtBxUsuario.Text, this.txtBxPass.Text);
           
        }

        private void loguear(string nomUsuario, string claveUsuario)
        {
            
                    try
                    {
                        //Aqui mandamos a hacer una consulta a la tabla usuarios, en la cual vamos a comprobar el nombre y el perfil que maneja
                        MySqlCommand cmd = new MySqlCommand("SELECT NomUsuario, Perfil FROM Usuarios WHERE NomUsuario=@Usuario AND ClaveUsuario=@Contraseña", Conexion.Conexion.obtenerConexion()); ;
                        cmd.Parameters.AddWithValue("Usuario", nomUsuario);//aquí al campo "usuario" le añadimos lo que el usuario vaya a ingresar al textbox 
                        cmd.Parameters.AddWithValue("Contraseña", claveUsuario);//aquí al campo "Contraseña" le añadimos lo que el usuario vaya a ingresar al textbox
                        cmd.ExecuteNonQuery();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //En este metodo hace una lectura por fila y columna para encontra la columna donde
                        //Está el perfil
                        if(dt.Rows.Count == 1)
                        {
                            this.Hide();
                        //Si es administrador, lo dirige hacia el menu principal para el, que es buscar productos
                            if(dt.Rows[0][1].ToString() == "Administrador")
                            {
                                 BuscarProductos m = new BuscarProductos(dt.Rows[0][0].ToString());
                                    m.Show();
                            }
                         //Si es usuario lo manda a la venta
                            else if(dt.Rows[0][1].ToString() == "Usuario")
                            {
                                 Venta ve = new Venta(dt.Rows[0][0].ToString());
                                 ve.Show();
                            }
                            Conexion.Conexion.obtenerConexion().Close();
                        }
                       else
                        {
                             MessageBox.Show("Usuario y/o Contraseña incorrectos");
                         }
                    }catch (MySqlException)
                    {
                        MessageBox.Show("Ocurrió un error");
                    }
        }
    }
}
