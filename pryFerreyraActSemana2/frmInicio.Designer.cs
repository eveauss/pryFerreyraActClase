namespace pryFerreyraActSemana2
{
    partial class frmInicio
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
            gbMain = new GroupBox();
            lblMain = new Label();
            btnIngresar = new Button();
            groupBox1 = new GroupBox();
            lblVer = new Label();
            gbMain.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbMain
            // 
            gbMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbMain.BackColor = Color.White;
            gbMain.Controls.Add(lblMain);
            gbMain.Controls.Add(btnIngresar);
            gbMain.Location = new Point(19, 22);
            gbMain.Name = "gbMain";
            gbMain.Size = new Size(574, 282);
            gbMain.TabIndex = 6;
            gbMain.TabStop = false;
            gbMain.Enter += gbMain_Enter;
            // 
            // lblMain
            // 
            lblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMain.Location = new Point(79, 85);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(438, 37);
            lblMain.TabIndex = 8;
            lblMain.Text = "Sistema de gestión de inventario";
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIngresar.BackColor = Color.Purple;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(206, 175);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(163, 48);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Purple;
            groupBox1.Controls.Add(gbMain);
            groupBox1.Location = new Point(115, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 322);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // lblVer
            // 
            lblVer.AutoSize = true;
            lblVer.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVer.ForeColor = Color.White;
            lblVer.Location = new Point(784, 427);
            lblVer.Name = "lblVer";
            lblVer.Size = new Size(59, 13);
            lblVer.TabIndex = 9;
            lblVer.Text = "Versión 1.0";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(855, 449);
            Controls.Add(lblVer);
            Controls.Add(groupBox1);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de inventario";
            gbMain.ResumeLayout(false);
            gbMain.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbMain;
        private Button btnIngresar;
        private GroupBox groupBox1;
        private Label lblMain;
        private Label lblVer;
    }
}
