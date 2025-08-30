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
            btnModificar = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            nPrecio = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblPrecio = new Label();
            lblDesc = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtBuscar = new TextBox();
            gbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nPrecio).BeginInit();
            SuspendLayout();
            // 
            // gbModificar
            // 
            gbModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbModificar.BackColor = Color.White;
            gbModificar.Controls.Add(nPrecio);
            gbModificar.Controls.Add(dtpFecha);
            gbModificar.Controls.Add(lblFecha);
            gbModificar.Controls.Add(lblPrecio);
            gbModificar.Controls.Add(lblDesc);
            gbModificar.Controls.Add(lblCategoria);
            gbModificar.Controls.Add(lblNombre);
            gbModificar.Controls.Add(lblCodigo);
            gbModificar.Controls.Add(textBox3);
            gbModificar.Controls.Add(textBox2);
            gbModificar.Controls.Add(textBox1);
            gbModificar.Controls.Add(txtBuscar);
            gbModificar.Controls.Add(btnModificar);
            gbModificar.Controls.Add(label1);
            gbModificar.Controls.Add(comboBox1);
            gbModificar.Location = new Point(12, 12);
            gbModificar.Name = "gbModificar";
            gbModificar.Size = new Size(332, 363);
            gbModificar.TabIndex = 8;
            gbModificar.TabStop = false;
            gbModificar.Text = "Editar Producto";
            gbModificar.Enter += gbModificar_Enter;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnModificar.BackColor = Color.Purple;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(150, 315);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 42);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "queso", "si" });
            comboBox1.Location = new Point(125, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(55, 29);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 17;
            label1.Text = "Producto";
            label1.Click += label1_Click;
            // 
            // nPrecio
            // 
            nPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nPrecio.Location = new Point(127, 173);
            nPrecio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nPrecio.Name = "nPrecio";
            nPrecio.Size = new Size(100, 23);
            nPrecio.TabIndex = 31;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.Location = new Point(127, 212);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 30;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(57, 215);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 29;
            lblFecha.Text = "Fecha";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(57, 180);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 28;
            lblPrecio.Text = "Precio";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(57, 253);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(69, 15);
            lblDesc.TabIndex = 27;
            lblDesc.Text = "Descripción";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(57, 142);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 26;
            lblCategoria.Text = "Categoría";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(57, 104);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(57, 65);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 24;
            lblCodigo.Text = "Código";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 253);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 52);
            textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 21;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(127, 57);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 20;
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
            ((System.ComponentModel.ISupportInitialize)nPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbModificar;
        private Button btnModificar;
        private NumericUpDown nPrecio;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblPrecio;
        private Label lblDesc;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblCodigo;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txtBuscar;
        private Label label1;
        private ComboBox comboBox1;
    }
}