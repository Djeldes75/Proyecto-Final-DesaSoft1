using System.Data.SqlClient;

public class Database
{
    private readonly string connectionString = "data source=NewVoid\\GESTORINVENTARIO;initial catalog=GestorInventario;trusted_connection=true";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
