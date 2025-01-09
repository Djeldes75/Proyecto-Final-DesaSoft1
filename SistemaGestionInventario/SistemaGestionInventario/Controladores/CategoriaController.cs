using SistemaInventario.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaInventario.Controladores
{
    public class CategoriaController
    {
        public static List<Categoria> ObtenerCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM Categorias";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = reader["NombreCategoria"].ToString(),
                        Descripcion = reader["Descripcion"].ToString()
                    };
                    lista.Add(categoria);
                }
            }
            return lista;
        }
    }
}