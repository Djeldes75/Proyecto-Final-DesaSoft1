namespace SistemaGestionInventario.Modelos
{
    public class Categorias
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        // Constructor para inicializar la categoría
        public Categorias(int categoriaId, string nombreCategoria, string descripcion)
        {
            CategoriaId = categoriaId;
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
        }
    }
}

