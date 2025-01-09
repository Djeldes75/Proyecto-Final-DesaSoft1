using SistemaInventario.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaInventario.Controladores
{
    public class ProveedorController
    {
        public static List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM Proveedores";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Proveedor proveedor = new Proveedor
                    {
                        ProveedorID = (int)reader["ProveedorID"],
                        NombreEmpresa = reader["NombreEmpresa"].ToString(),
                        Contacto = reader["Contacto"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString()
                    };
                    lista.Add(proveedor);
                }
            }
            return lista;
        }
    }
}