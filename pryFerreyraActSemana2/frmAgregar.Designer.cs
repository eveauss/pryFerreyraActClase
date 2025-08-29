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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            lblDesc = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            gbAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // gbAgregar
            // 
            gbAgregar.Controls.Add(lblDesc);
            gbAgregar.Controls.Add(lblCategoria);
            gbAgregar.Controls.Add(lblNombre);
            gbAgregar.Controls.Add(lblCodigo);
            gbAgregar.Controls.Add(textBox3);
            gbAgregar.Controls.Add(textBox2);
            gbAgregar.Controls.Add(textBox1);
            gbAgregar.Controls.Add(btnAgregar);
            gbAgregar.Controls.Add(txtBuscar);
            gbAgregar.Location = new Point(245, 51);
            gbAgregar.Name = "gbAgregar";
            gbAgregar.Size = new Size(332, 324);
            gbAgregar.TabIndex = 7;
            gbAgregar.TabStop = false;
            gbAgregar.Text = "Registrar Producto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 173);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 52);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(165, 247);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(140, 46);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 4;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(70, 173);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(69, 15);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Descripción";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(70, 135);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categoría";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(70, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(70, 49);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 12;
            lblCodigo.Text = "Código";
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbAgregar);
            Name = "frmAgregar";
            Text = "frmAgregar";
            gbAgregar.ResumeLayout(false);
            gbAgregar.PerformLayout();
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
    }
}