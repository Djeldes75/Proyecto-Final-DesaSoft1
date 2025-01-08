namespace SistemaGestionInventario.Modelos
{
    public class Productos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public int ProveedorId { get; set; }

        // Constructor para crear un objeto de tipo Producto
        public Productos(int codigo, string nombre, int categoriaId, double precio, int existencia, int proveedorId)
        {
            Codigo = codigo;
            Nombre = nombre;
            CategoriaId = categoriaId;
            Precio = precio;
            Existencia = existencia;
            ProveedorId = proveedorId;
        }
    }
}
