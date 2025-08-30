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
            lblDesc = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            lblPrecio = new Label();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            nPrecio = new NumericUpDown();
            gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nPrecio).BeginInit();
            SuspendLayout();
            // 
            // gbAgregar
            // 
            gbAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAgregar.BackColor = Color.White;
            gbAgregar.Controls.Add(nPrecio);
            gbAgregar.Controls.Add(dtpFecha);
            gbAgregar.Controls.Add(lblFecha);
            gbAgregar.Controls.Add(lblPrecio);
            gbAgregar.Controls.Add(lblDesc);
            gbAgregar.Controls.Add(lblCategoria);
            gbAgregar.Controls.Add(lblNombre);
            gbAgregar.Controls.Add(lblCodigo);
            gbAgregar.Controls.Add(textBox3);
            gbAgregar.Controls.Add(textBox2);
            gbAgregar.Controls.Add(textBox1);
            gbAgregar.Controls.Add(btnAgregar);
            gbAgregar.Controls.Add(txtBuscar);
            gbAgregar.Location = new Point(12, 12);
            gbAgregar.Name = "gbAgregar";
            gbAgregar.Size = new Size(332, 324);
            gbAgregar.TabIndex = 7;
            gbAgregar.TabStop = false;
            gbAgregar.Text = "Registrar Producto";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(71, 223);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(69, 15);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Descripción";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(71, 112);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categoría";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(71, 74);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(71, 35);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 12;
            lblCodigo.Text = "Código";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 223);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 52);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Purple;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(166, 281);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(141, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(71, 150);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 16;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(71, 185);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 17;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.Location = new Point(141, 182);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 18;
            // 
            // nPrecio
            // 
            nPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nPrecio.Location = new Point(141, 143);
            nPrecio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nPrecio.Name = "nPrecio";
            nPrecio.Size = new Size(100, 23);
            nPrecio.TabIndex = 19;
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
            ((System.ComponentModel.ISupportInitialize)nPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAgregar;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Label lblDesc;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblFecha;
        private Label lblPrecio;
        private NumericUpDown nPrecio;
        private DateTimePicker dtpFecha;
    }
}