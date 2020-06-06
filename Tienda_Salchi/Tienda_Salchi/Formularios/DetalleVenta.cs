using MySql.Data.MySqlClient;
using Salchichoneria.Conexion;
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
    public partial class DetalleVenta : Form
    {
        public DetalleVenta()
        {
            InitializeComponent();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            VerDetalle();
        }

        private void VerDetalle()
        {

            string consulta = "SELECT Cliente,Nombre,Categoria,Descripcion,Precio,Cantidad,Total FROM Venta ";
            MySqlConnection conexion = Conexion.obtenerConexion();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conexion);//conectar a la base de datos para hacer la consulta
            

            DataSet ds = new DataSet();
            mda.Fill(ds);
            GridDetalle.DataSource = ds.Tables[0];
            conexion.Close();
        }
    }
}
