using SistemaGestionInventario.Modelos;

namespace SistemaGestionInventario.Data
{
    public class DatabaseHelper
    {
        // Cadena de conexión a la base de datos
        private string connectionString = @"Server=DESKTOP-AJ97NT6\MSSQLSERVER01;Database=GESTORINVENTARIO;Trusted_Connection=True;";

        // Obtener conexión con la base de datos
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Probar la conexión a la base de datos
        public bool ProbarConexion()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Agregar un producto
        public void AgregarProducto(Productos producto)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "INSERT INTO Productos (Codigo, Nombre, CategoriaId, Precio, Existencia, ProveedorId) " +
                               "VALUES (@Codigo, @Nombre, @CategoriaId, @Precio, @Existencia, @ProveedorId)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Codigo", producto.Codigo);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Existencia", producto.Existencia);
                command.Parameters.AddWithValue("@ProveedorId", producto.ProveedorId);

                command.ExecuteNonQuery();
            }
        }

        // Obtener todos los productos
        public List<Productos> ObtenerProductos()
        {
            List<Productos> productos = new List<Productos>();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Productos";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Productos(
                        int.Parse(reader["Codigo"].ToString()),
                        reader["Nombre"].ToString(),
                        int.Parse(reader["CategoriaId"].ToString()),
                        double.Parse(reader["Precio"].ToString()),
                        int.Parse(reader["Existencia"].ToString()),
                        int.Parse(reader["ProveedorId"].ToString())
                    ));
                }
            }

            return productos;
        }

        // Agregar una categoría
        public void AgregarCategoria(Categorias categoria)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "INSERT INTO Categorias (CategoriaId, NombreCategoria, Descripcion) " +
                               "VALUES (@CategoriaId, @NombreCategoria, @Descripcion)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CategoriaId", categoria.CategoriaId);
                command.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
                command.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                command.ExecuteNonQuery();
            }
        }
    }
}