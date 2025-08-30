using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace pryFerreyraInventario
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        public List<Producto> ListaProductos { get; set; }


        private void CargarGrafico(List<Producto> productos)
        {
            chartInventario.Series.Clear();
            chartInventario.ChartAreas.Clear();

            var chartArea = new ChartArea();
            chartInventario.ChartAreas.Add(chartArea);

            var serie = new Series("Stock Disponible");
            serie.ChartType = SeriesChartType.Column; // Columnas
            serie.Color = Color.DodgerBlue;
            serie.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            foreach (var p in productos)
            {
                serie.Points.AddXY(p.Nombre, p.Stock);
            }

            chartInventario.Series.Add(serie);

            // Título del gráfico
            chartInventario.Titles.Clear();
            chartInventario.Titles.Add("Reporte de Inventario");
            chartInventario.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Mostrar valores arriba de cada columna
            serie.IsValueShownAsLabel = true;
        }




        private void frmReportes_Load(object sender, EventArgs e)
        {
            if (ListaProductos != null && ListaProductos.Count > 0)
            {
                CargarGrafico(ListaProductos);
            }
            else
            {
                MessageBox.Show("No hay productos para mostrar en el reporte.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmGestion frm = new frmGestion();
            frm.Show();
            frm.Close();
        }
    }

}

