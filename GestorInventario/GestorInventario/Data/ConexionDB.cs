using System.Data.SqlClient;

namespace SistemaInventario.Modelos
{
    public static class ConexionBD
    {
        private static string cadenaConexion = "Data Source=NEWVOID\\GESTORINVENTARIO;Initial Catalog=GestorInventario;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
