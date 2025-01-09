using System.Data.SqlClient;

public class Conexion
{
    private readonly string connectionString = "Data Source = NEWVOID\\GESTORINVENTARIO; Initial Catalog = GestorInventario; Integrated Security = True; Trust Server Certificate=True";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}

