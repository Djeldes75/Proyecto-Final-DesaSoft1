using SistemaGestionInventario.Data;
using SistemaGestionInventario.Modelos;

namespace SistemaGestionInventario.Controladores
{
    public class ControladorCategoria
    {
        private DatabaseHelper dbHelper = new DatabaseHelper(); // Instancia para manejar la conexión

        public List<Categorias> ObtenerCategorias()
        {
            List<Categorias> categorias = new List<Categorias>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT * FROM Categorias";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categorias.Add(new Categorias(
                        int.Parse(reader["CategoriaId"].ToString()),
                        reader["NombreCategoria"].ToString(),
                        reader["Descripcion"].ToString()
                    ));
                }
            }

            return categorias;
        }

        public void AgregarCategoria(Categorias categoria)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "INSERT INTO Categorias (NombreCategoria, Descripcion) " +
                               "VALUES (@NombreCategoria, @Descripcion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Categorias ObtenerCategoriaPorId(int categoriaId)
        {
            Categorias categoria = null;

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT * FROM Categorias WHERE CategoriaId = @CategoriaId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    categoria = new Categorias(
                        int.Parse(reader["CategoriaId"].ToString()),
                        reader["NombreCategoria"].ToString(),
                        reader["Descripcion"].ToString()
                    );
                }
            }

            return categoria;
        }

        public void EditarCategoria(Categorias categoria)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "UPDATE Categorias SET " +
                               "NombreCategoria = @NombreCategoria, " +
                               "Descripcion = @Descripcion " +
                               "WHERE CategoriaId = @CategoriaId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoriaId", categoria.CategoriaId);
                cmd.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCategoria(int categoriaId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "DELETE FROM Categorias WHERE CategoriaId = @CategoriaId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
