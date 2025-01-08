using SistemaGestionInventario.Modelos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestionInventario
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Productos nuevoProducto = new Productos
            {
                Nombre = textBox_NombreProducto.Text,
                CodigoProducto = Convert.ToInt32(textBox_CodigoProducto.Text),
                CategoriaID = comboBox_CategoriaProducto.Text,
                Precio = decimal.Parse(textBox_PrecioProducto.Text).ToString(),
                Existencia = textBox_ExistenciaProducto.Text,
                ProveedorID = textBox_ProveedorProducto.Text
            };

            AgregarProducto(nuevoProducto);
        }

        private void AgregarProducto(Productos producto)
        {
            using (SqlConnection conn = new Database().GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Productos (CodigoProducto, Nombre, Precio, Existencia, CategoriaID, ProveedorID) " +
                               "VALUES (@CodigoProducto, @Nombre, @Precio, @Existencia, @CategoriaID, @ProveedorID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);
                cmd.Parameters.AddWithValue("@ProveedorID", producto.ProveedorID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
