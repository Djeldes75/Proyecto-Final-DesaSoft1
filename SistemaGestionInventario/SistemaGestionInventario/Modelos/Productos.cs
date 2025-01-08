namespace SistemaGestionInventario.Modelos
{
    public class Productos
    {
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string CategoriaID { get; set; }
        public string Precio { get; set; }
        public string Existencia { get; set; }
        public string ProveedorID { get; set; }
    }
}
