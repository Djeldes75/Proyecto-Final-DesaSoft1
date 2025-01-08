namespace SistemaGestionInventario.Modelos
{
    public class Proveedores
    {
        public int ProveedorId { get; set; }
        public string NombreEmpresa { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        // Constructor para inicializar el proveedor
        public Proveedores(int proveedorId, string nombreEmpresa, string contacto, string direccion, string telefono)
        {
            ProveedorId = proveedorId;
            NombreEmpresa = nombreEmpresa;
            Contacto = contacto;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
