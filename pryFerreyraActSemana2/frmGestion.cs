using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFerreyraInventario
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private List<Producto> listaProductos = new List<Producto>();



        private void frmGestion_Load(object sender, EventArgs e)
        {
            listaProductos.Add(new Producto
            {
                Codigo = "P001",
                Nombre = "Teclado Gamer",
                Categoria = "Periféricos",
                Precio = 15000,
                Stock = 15,
                Fecha = new DateTime(2025, 1, 15),
                Dsc = "Teclado mecánico RGB retroiluminado",
                
            });

            listaProductos.Add(new Producto
            {
                Codigo = "P002",
                Nombre = "Mouse Inalámbrico",
                Categoria = "Periféricos",
                Precio = 8500,
                Stock = 30,
                Fecha = new DateTime(2025, 2, 3),
                Dsc = "Mouse inalámbrico 1600dpi",
                
            });

            listaProductos.Add(new Producto
            {
                Codigo = "P003",
                Nombre = "Monitor 24''",
                Categoria = "Pantallas",
                Precio = 95000,
                Stock = 7,
                Fecha = new DateTime(2025, 2, 10),
                Dsc = "Monitor LED Full HD 24 pulgadas",
                
            });

            listaProductos.Add(new Producto
            {
                Codigo = "P004",
                Nombre = "Notebook HP",
                Categoria = "Computadoras",
                Precio = 520000,
                Stock = 5,
                Fecha = new DateTime(2025, 3, 1),
                Dsc = "Notebook HP 15.6'' con Windows 11",
                
            });

            listaProductos.Add(new Producto
            {
                Codigo = "P005",
                Nombre = "Impresora Multifunción",
                Categoria = "Periféricos",
                Precio = 78000,
                Stock = 3,
                Fecha = new DateTime(2025, 3, 10),
                Dsc = "Impresora multifunción Wi-Fi",
                
            });

            // Mostrar datos en el DataGridView
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            // Creamos el formulario de reportes
            frmReportes frm = new frmReportes();

            // Le pasamos la lista de productos actual
            frm.ListaProductos = listaProductos;

            // Mostramos el formulario como ventana modal
            frm.Show();
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
