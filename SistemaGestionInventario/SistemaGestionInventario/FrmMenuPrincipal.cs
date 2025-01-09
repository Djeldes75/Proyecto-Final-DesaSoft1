using System.Windows.Forms;

namespace SistemaGestionInventario
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.Show();
        }

        private void consultarInventarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmConsultas frmConsultas = new FrmConsultas();
            frmConsultas.Show();
        }

        private void reporteDeStockBajoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmReporteStockBajo frmReporteStockBajo = new FrmReporteStockBajo();
            frmReporteStockBajo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
