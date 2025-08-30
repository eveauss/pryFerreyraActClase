namespace pryFerreyraInventario
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartInventario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Inventario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)chartInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Inventario).BeginInit();
            SuspendLayout();
            // 
            // chartInventario
            // 
            chartInventario.BackColor = Color.Purple;
            chartInventario.Dock = DockStyle.Fill;
            chartInventario.Location = new Point(0, 0);
            chartInventario.Name = "chartInventario";
            chartInventario.Size = new Size(300, 300);
            chartInventario.TabIndex = 0;
            // 
            // Inventario
            // 
            Inventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Inventario.BackColor = Color.Purple;
            chartArea1.Name = "ChartArea1";
            Inventario.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            Inventario.Legends.Add(legend1);
            Inventario.Location = new Point(27, 32);
            Inventario.Name = "Inventario";
            Inventario.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            Inventario.Series.Add(series1);
            Inventario.Size = new Size(749, 406);
            Inventario.TabIndex = 0;
            Inventario.Text = "chartInventario";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVolver.BackColor = Color.Purple;
            btnVolver.BackgroundImageLayout = ImageLayout.None;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(27, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 29);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "<<";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(Inventario);
            Name = "frmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            Load += frmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)chartInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)Inventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventario;
        private System.Windows.Forms.DataVisualization.Charting.Chart Inventario;
        private Button btnVolver;
    }
}