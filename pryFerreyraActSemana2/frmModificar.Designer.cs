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
            btnEliminar = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            lblDesc = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            gbModificar.SuspendLayout();
            SuspendLayout();
            // 
            // gbModificar
            // 
            gbModificar.Controls.Add(btnEliminar);
            gbModificar.Controls.Add(label1);
            gbModificar.Controls.Add(comboBox1);
            gbModificar.Controls.Add(lblDesc);
            gbModificar.Controls.Add(lblCategoria);
            gbModificar.Controls.Add(lblNombre);
            gbModificar.Controls.Add(lblCodigo);
            gbModificar.Controls.Add(textBox3);
            gbModificar.Controls.Add(textBox2);
            gbModificar.Controls.Add(textBox1);
            gbModificar.Controls.Add(btnAgregar);
            gbModificar.Controls.Add(txtBuscar);
            gbModificar.Location = new Point(235, 50);
            gbModificar.Name = "gbModificar";
            gbModificar.Size = new Size(332, 324);
            gbModificar.TabIndex = 8;
            gbModificar.TabStop = false;
            gbModificar.Text = "Editar Producto";
            gbModificar.Enter += gbModificar_Enter;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(229, 205);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 17;
            label1.Text = "Producto";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "queso", "si" });
            comboBox1.Location = new Point(110, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 16;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(40, 213);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(69, 15);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Descripción";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(40, 175);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categoría";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 134);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(40, 89);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 12;
            lblCodigo.Text = "Código";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 213);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 52);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(229, 242);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Modificar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(110, 86);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 4;
            // 
            // frmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbModificar);
            Name = "frmModificar";
            Text = "frmModificar";
            gbModificar.ResumeLayout(false);
            gbModificar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbModificar;
        private Label lblDesc;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblCodigo;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnEliminar;
    }
}