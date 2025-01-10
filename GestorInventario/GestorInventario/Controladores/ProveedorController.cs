using SistemaInventario.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaInventario.Controladores
{
    public class ProveedorController
    {
        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();

            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM Proveedores";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    proveedores.Add(new Proveedor
                    {
                        IdProveedor = int.Parse(reader["IdProveedor"].ToString()),
                        NombreEmpresa = reader["NombreEmpresa"].ToString(),
                        Contacto = reader["Contacto"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString()
                    });
                }
            }

            return proveedores;
        }

        public void AgregarProveedor(Proveedor proveedor)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "INSERT INTO Proveedores (NombreEmpresa, Contacto, Direccion, Telefono) " +
                               "VALUES (@NombreEmpresa, @Contacto, @Direccion, @Telefono)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreEmpresa", proveedor.NombreEmpresa);
                cmd.Parameters.AddWithValue("@Contacto", proveedor.Contacto);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarProveedor(Proveedor proveedor)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "UPDATE Proveedores SET NombreEmpresa = @NombreEmpresa, Contacto = @Contacto, Direccion = @Direccion, Telefono = @Telefono WHERE IdProveedor = @IdProveedor";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
                cmd.Parameters.AddWithValue("@NombreEmpresa", proveedor.NombreEmpresa);
                cmd.Parameters.AddWithValue("@Contacto", proveedor.Contacto);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProveedor(int idProveedor)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM Proveedores WHERE IdProveedor = @IdProveedor";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}