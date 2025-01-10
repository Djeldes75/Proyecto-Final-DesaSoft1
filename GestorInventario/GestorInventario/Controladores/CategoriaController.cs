using SistemaInventario.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaInventario.Controladores
{
    public class CategoriaController
    {
        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM Categorias";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categorias.Add(new Categoria
                    {
                        IdCategoria = int.Parse(reader["IdCategoria"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString()
                    });
                }
            }

            return categorias;
        }

        public void AgregarCategoria(Categoria categoria)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "INSERT INTO Categorias (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarCategoria(Categoria categoria)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "UPDATE Categorias SET Nombre = @Nombre, Descripcion = @Descripcion WHERE IdCategoria = @IdCategoria";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCategoria(int idCategoria)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM Categorias WHERE IdCategoria = @IdCategoria";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}