using GestorInventario.Vistas;
using System.Windows.Forms;

namespace GestorInventario
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CategoriasForm categoriasForm = new CategoriasForm();
            categoriasForm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ProveedoresForm proveedoresForm = new ProveedoresForm();
            proveedoresForm.Show();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
