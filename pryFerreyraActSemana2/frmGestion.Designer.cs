namespace pryFerreyraInventario
{
    partial class frmGestion
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
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Dsc = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.Purple;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Categoria, Precio, Fecha, Dsc });
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(69, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 345);
            dataGridView1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.BackgroundImage = Properties.Resources.icons8_buscar_50;
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.Location = new Point(270, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(24, 24);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.ForeColor = SystemColors.ScrollBar;
            txtBuscar.Location = new Point(71, 28);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(195, 23);
            txtBuscar.TabIndex = 3;
            txtBuscar.Text = "Nombre o código";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Purple;
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(366, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Purple;
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(483, 27);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(113, 29);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Purple;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(600, 27);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoría";
            Categoria.Name = "Categoria";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Dsc
            // 
            Dsc.HeaderText = "Descripción";
            Dsc.Name = "Dsc";
            // 
            // frmGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Name = "frmGestion";
            Text = "Gestión";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Dsc;
    }
}