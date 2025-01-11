using System.Data.SqlClient;

namespace SistemaInventario.Modelos
{
    public static class ConexionBD
    {
        // Cadena de conexión actualizada, eliminando el parámetro 'Trust Server Certificate' si no es necesario
        private static string cadenaConexion = "Data Source=NEWVOID\\GESTORINVENTARIO;Initial Catalog=GestorInventario;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        // Si necesitas usar 'Trust Server Certificate', asegúrate de que tu proveedor lo soporte o desactívalo si no es necesario
        // private static string cadenaConexion = "Data Source=NEWVOID\\GESTORINVENTARIO;Initial Catalog=GestorInventario;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"; 

        public static SqlConnection ObtenerConexion()
        {
            // Verifica que la cadena de conexión sea válida
            return new SqlConnection(cadenaConexion);
        }
    }
}
