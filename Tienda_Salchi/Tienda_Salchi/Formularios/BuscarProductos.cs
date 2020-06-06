using MySql.Data.MySqlClient;
using Salchichoneria.Conexion;
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

namespace Tienda_Salchi.Formularios
{
    public partial class BuscarProductos : Form
    {
        public BuscarProductos(string nombre)
        {
            InitializeComponent();
            lblMensajeadmi.Text = nombre;
        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleVenta d = new DetalleVenta();
            d.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.Show();
        }
    }
}
