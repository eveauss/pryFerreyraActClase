namespace pryFerreyraActSemana2
{
    partial class frmGestion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbGestion = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            gbGestion.SuspendLayout();
            SuspendLayout();
            // 
            // gbGestion
            // 
            gbGestion.Controls.Add(btnEliminar);
            gbGestion.Controls.Add(btnModificar);
            gbGestion.Controls.Add(btnAgregar);
            gbGestion.Location = new Point(126, 60);
            gbGestion.Name = "gbGestion";
            gbGestion.Size = new Size(347, 274);
            gbGestion.TabIndex = 6;
            gbGestion.TabStop = false;
            gbGestion.Text = "Gestión de Inventario";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(136, 164);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 48);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(136, 110);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 48);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(136, 56);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 48);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 449);
            Controls.Add(gbGestion);
            Name = "frmGestion";
            Text = "Gestión de inventario";
            gbGestion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbGestion;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}
