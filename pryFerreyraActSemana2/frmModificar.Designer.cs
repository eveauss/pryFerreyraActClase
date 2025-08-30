namespace pryFerreyraInventario
{
    partial class frmModificar
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
            gbModificar = new GroupBox();
            nudStock = new NumericUpDown();
            lblStock = new Label();
            nudPrecio = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblPrecio = new Label();
            lblDesc = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            txtDsc = new TextBox();
            txtCategoria = new TextBox();
            txtNombre = new TextBox();
            btnModificar = new Button();
            txtCodigo = new TextBox();
            gbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // gbModificar
            // 
            gbModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbModificar.BackColor = Color.White;
            gbModificar.Controls.Add(nudStock);
            gbModificar.Controls.Add(lblStock);
            gbModificar.Controls.Add(nudPrecio);
            gbModificar.Controls.Add(dtpFecha);
            gbModificar.Controls.Add(lblFecha);
            gbModificar.Controls.Add(lblPrecio);
            gbModificar.Controls.Add(lblDesc);
            gbModificar.Controls.Add(lblCategoria);
            gbModificar.Controls.Add(lblNombre);
            gbModificar.Controls.Add(lblCodigo);
            gbModificar.Controls.Add(txtDsc);
            gbModificar.Controls.Add(txtCategoria);
            gbModificar.Controls.Add(txtNombre);
            gbModificar.Controls.Add(btnModificar);
            gbModificar.Controls.Add(txtCodigo);
            gbModificar.Location = new Point(12, 12);
            gbModificar.Name = "gbModificar";
            gbModificar.Size = new Size(332, 363);
            gbModificar.TabIndex = 8;
            gbModificar.TabStop = false;
            gbModificar.Text = "Editar Producto";
            gbModificar.Enter += gbModificar_Enter;
            // 
            // nudStock
            // 
            nudStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudStock.Location = new Point(151, 175);
            nudStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(100, 23);
            nudStock.TabIndex = 36;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(81, 182);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 35;
            lblStock.Text = "Stock";
            // 
            // nudPrecio
            // 
            nudPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudPrecio.Location = new Point(151, 140);
            nudPrecio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(100, 23);
            nudPrecio.TabIndex = 34;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.Location = new Point(151, 211);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 33;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(81, 214);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 32;
            lblFecha.Text = "Fecha";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(81, 147);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 31;
            lblPrecio.Text = "Precio";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(81, 249);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(69, 15);
            lblDesc.TabIndex = 30;
            lblDesc.Text = "Descripción";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(81, 111);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 29;
            lblCategoria.Text = "Categoría";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(81, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 28;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(81, 40);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 27;
            lblCodigo.Text = "Código";
            // 
            // txtDsc
            // 
            txtDsc.Location = new Point(151, 249);
            txtDsc.Multiline = true;
            txtDsc.Name = "txtDsc";
            txtDsc.Size = new Size(100, 52);
            txtDsc.TabIndex = 26;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(151, 103);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 24;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Purple;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(176, 307);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(151, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 23;
            // 
            // frmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Purple;
            ClientSize = new Size(357, 382);
            Controls.Add(gbModificar);
            Name = "frmModificar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmModificar";
            WindowState = FormWindowState.Minimized;
            gbModificar.ResumeLayout(false);
            gbModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbModificar;
        private NumericUpDown nudStock;
        private Label lblStock;
        private NumericUpDown nudPrecio;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblPrecio;
        private Label lblDesc;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblCodigo;
        private TextBox txtDsc;
        private TextBox txtCategoria;
        private TextBox txtNombre;
        private Button btnModificar;
        private TextBox txtCodigo;
    }
}