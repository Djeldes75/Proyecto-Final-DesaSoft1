using SistemaInventario.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaInventario.Controladores
{
    public class ProductoController
    {
        public static List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM Productos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto
                    {
                        ProductoID = (int)reader["ProductoID"],
                        Nombre = reader["Nombre"].ToString(),
                        CodigoProducto = reader["CodigoProducto"].ToString(),
                        CategoriaID = (int)reader["CategoriaID"],
                        Precio = (decimal)reader["Precio"],
                        Existencia = (int)reader["Existencia"],
                        ProveedorID = (int)reader["ProveedorID"]
                    };
                    lista.Add(producto);
                }
            }
            return lista;
        }
    }
}