using SistemaInventario.Controladores;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorInventario.Vistas
{
    public partial class CategoriasForm : Form
    {
        private CategoriaController categoriaController;

        public CategoriasForm()
        {
            InitializeComponent();
            categoriaController = new CategoriaController();
            CargarCategorias();
        }

        private void btnAgregarCat_Click(object sender, System.EventArgs e)
        {
            if (ValidarCampos())
            {
                Categoria nuevaCategoria = new Categoria
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text
                };

                categoriaController.AgregarCategoria(nuevaCategoria);
                MessageBox.Show("Categoría agregada correctamente.");
                CargarCategorias();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción de la categoría es obligatoria.");
                return false;
            }
            return true;
        }

        private void CargarCategorias()
        {
            List<Categoria> categorias = categoriaController.ObtenerCategorias();
            // Add code to load categories into the UI, e.g., a ListView or ComboBox
        }
    }
}
