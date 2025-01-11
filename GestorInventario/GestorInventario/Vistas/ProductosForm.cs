using SistemaInventario.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorInventario.Vistas
{
    public partial class ProductosForm : Form
    {
        private ProductoController productoController;

        public ProductosForm()
        {
            InitializeComponent();
            productoController = new ProductoController();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            // Lista de categorías de laptops gaming
            List<string> categoriasGaming = new List<string>
            {
                "Alienware",
                "ASUS ROG",
                "MSI",
                "HP",
                "Razer",
                "Lenovo"
            };

            // Asignar la lista de laptops al ComboBox
            comboBoxCategorias.DataSource = categoriasGaming;

            //Lista de proveedores:
            List<string> proveedores = new List<string>
            {
                "Hytel Tech. S.L",
                "Global Partners",
                "Micro Center - Aoka",
                "D & I - Esports ",
                "Trevor Phillips Industries",
                "StarForge Systems"
            };

            // Asignar la lista de proveedores al ComboBox
            comboBoxProveedores.DataSource = proveedores;

            // Cargar los productos al iniciar el formulario
            CargarProductos();
        }

        private void CargarProductos()
        {
            // Obtener los productos desde el controlador
            List<Producto> productos = productoController.ObtenerProductos();

            // Configurar el DataGridView con los productos obtenidos
            dataGridViewProductos.DataSource = null;  // Limpiar cualquier fuente anterior
            dataGridViewProductos.DataSource = productos;  // Asignar los nuevos productos
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Capturar los datos del formulario
            string nombre = txtNombreProducto.Text;
            decimal precio = numericUpDownPrecio.Value;
            int IDcategoria = (int)comboBoxCategorias.SelectedValue;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre del producto.");
                return;
            }

            // Crear el objeto Producto
            Producto nuevoProducto = new Producto
            {
                Nombre = nombre,
                Precio = precio,
                IdCategoria = IDcategoria
            };

            // Llamar al controlador para agregar el producto
            productoController.AgregarProducto(nuevoProducto);

            // Recargar los productos en el DataGridView
            CargarProductos();

            // Limpiar los campos del formulario
            txtNombreProducto.Clear();
            numericUpDownPrecio.Value = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si se seleccionó un producto
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                // Obtener el producto seleccionado
                Producto productoSeleccionado = (Producto)dataGridViewProductos.SelectedRows[0].DataBoundItem;

                // Cargar los datos del producto en los controles del formulario
                txtNombreProducto.Text = productoSeleccionado.Nombre;
                numericUpDownPrecio.Value = productoSeleccionado.Precio;
                comboBoxCategorias.SelectedValue = productoSeleccionado.IdCategoria;

                // Cambiar el texto del botón a "Guardar Cambios"
                btnAgregar.Text = "Guardar Cambios";

                // Asignar la acción del botón para guardar los cambios
                btnAgregar.Click -= btnAgregar_Click;
                btnAgregar.Click += (s, args) => GuardarCambios(productoSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.");
            }
        }

        private void GuardarCambios(Producto producto)
        {
            // Actualizar los datos del producto con los valores del formulario
            producto.Nombre = txtNombreProducto.Text;
            producto.Precio = numericUpDownPrecio.Value;
            producto.IdCategoria = (int)comboBoxCategorias.SelectedValue;

            // Llamar al controlador para guardar los cambios
            productoController.EditarProducto(producto);

            // Recargar los productos
            CargarProductos();

            // Limpiar los campos del formulario y restaurar el botón a "Agregar"
            txtNombreProducto.Clear();
            numericUpDownPrecio.Value = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click -= (s, args) => GuardarCambios(producto);
            btnAgregar.Click += btnAgregar_Click;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se seleccionó un producto
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                // Obtener el producto seleccionado
                Producto productoSeleccionado = (Producto)dataGridViewProductos.SelectedRows[0].DataBoundItem;

                // Confirmar la eliminación
                var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Llamar al controlador para eliminar el producto
                    productoController.EliminarProducto(productoSeleccionado.CodigoProducto);

                    // Recargar los productos
                    CargarProductos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }

    }
}
