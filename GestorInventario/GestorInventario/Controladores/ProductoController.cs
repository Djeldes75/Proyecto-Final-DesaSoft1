using SistemaInventario.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaInventario.Controladores
{
    public class ProductoController
    {
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM Productos";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        CodigoProducto = reader["CodigoProducto"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        IdCategoria = int.Parse(reader["IdCategoria"].ToString()),
                        Precio = decimal.Parse(reader["Precio"].ToString()),
                        Existencia = int.Parse(reader["Existencia"].ToString()),
                        IdProveedor = int.Parse(reader["IdProveedor"].ToString())
                    });
                }
            }

            return productos;
        }

        public void AgregarProducto(Producto producto)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "INSERT INTO Productos (CodigoProducto, Nombre, IdCategoria, Precio, Existencia, IdProveedor) " +
                               "VALUES (@CodigoProducto, @Nombre, @IdCategoria, @Precio, @Existencia, @IdProveedor)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.Parameters.AddWithValue("@IdProveedor", producto.IdProveedor);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarProducto(Producto producto)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "UPDATE Productos SET Nombre = @Nombre, IdCategoria = @IdCategoria, Precio = @Precio, Existencia = @Existencia, IdProveedor = @IdProveedor WHERE CodigoProducto = @CodigoProducto";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.Parameters.AddWithValue("@IdProveedor", producto.IdProveedor);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(string codigoProducto)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM Productos WHERE CodigoProducto = @CodigoProducto";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}