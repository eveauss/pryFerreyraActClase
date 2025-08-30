namespace pryFerreyraInventario
{
    partial class frmAgregar
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
            gbAgregar = new GroupBox();
            btnAgregar = new Button();
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
            txtCodigo = new TextBox();
            gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // gbAgregar
            // 
            gbAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAgregar.BackColor = Color.White;
            gbAgregar.Controls.Add(nudStock);
            gbAgregar.Controls.Add(lblStock);
            gbAgregar.Controls.Add(nudPrecio);
            gbAgregar.Controls.Add(dtpFecha);
            gbAgregar.Controls.Add(lblFecha);
            gbAgregar.Controls.Add(lblPrecio);
            gbAgregar.Controls.Add(lblDesc);
            gbAgregar.Controls.Add(lblCategoria);
            gbAgregar.Controls.Add(lblNombre);
            gbAgregar.Controls.Add(lblCodigo);
            gbAgregar.Controls.Add(txtDsc);
            gbAgregar.Controls.Add(txtCategoria);
            gbAgregar.Controls.Add(txtNombre);
            gbAgregar.Controls.Add(txtCodigo);
            gbAgregar.Controls.Add(btnAgregar);
            gbAgregar.Location = new Point(12, 12);
            gbAgregar.Name = "gbAgregar";
            gbAgregar.Size = new Size(332, 324);
            gbAgregar.TabIndex = 7;
            gbAgregar.TabStop = false;
            gbAgregar.Text = "Registrar Producto";
            gbAgregar.Enter += gbAgregar_Enter;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Purple;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(166, 297);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // nudStock
            // 
            nudStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudStock.Location = new Point(141, 158);
            nudStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(100, 23);
            nudStock.TabIndex = 50;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(71, 165);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 49;
            lblStock.Text = "Stock";
            // 
            // nudPrecio
            // 
            nudPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudPrecio.Location = new Point(141, 123);
            nudPrecio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(100, 23);
            nudPrecio.TabIndex = 48;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.Location = new Point(141, 194);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 47;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(71, 197);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 46;
            lblFecha.Text = "Fecha";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(71, 130);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 45;
            lblPrecio.Text = "Precio";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(71, 232);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(69, 15);
            lblDesc.TabIndex = 44;
            lblDesc.Text = "Descripción";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(71, 94);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 43;
            lblCategoria.Text = "Categoría";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(71, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(71, 23);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 41;
            lblCodigo.Text = "Código";
            // 
            // txtDsc
            // 
            txtDsc.Location = new Point(141, 232);
            txtDsc.Multiline = true;
            txtDsc.Name = "txtDsc";
            txtDsc.Size = new Size(100, 52);
            txtDsc.TabIndex = 40;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(141, 86);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 39;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 38;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(141, 15);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 37;
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Purple;
            ClientSize = new Size(357, 353);
            Controls.Add(gbAgregar);
            Name = "frmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregar";
            WindowState = FormWindowState.Minimized;
            gbAgregar.ResumeLayout(false);
            gbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAgregar;
        private Button btnAgregar;
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
        private TextBox txtCodigo;
    }
}