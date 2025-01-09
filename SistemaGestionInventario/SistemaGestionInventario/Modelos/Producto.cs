namespace SistemaInventario.Modelos
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string CodigoProducto { get; set; }
        public int CategoriaID { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public int ProveedorID { get; set; }
    }
}
