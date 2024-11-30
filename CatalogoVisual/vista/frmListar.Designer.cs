namespace CatalogoVisual
{
    partial class FrmListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListar));
            lstLista = new ListBox();
            btnVolver = new Button();
            lblListar = new Label();
            cmbOrdenar = new ComboBox();
            SuspendLayout();
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(370, 170);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(516, 404);
            lstLista.TabIndex = 47;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Desktop;
            btnVolver.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Window;
            btnVolver.Location = new Point(530, 596);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(186, 61);
            btnVolver.TabIndex = 45;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // lblListar
            // 
            lblListar.AutoSize = true;
            lblListar.Font = new Font("Bauhaus 93", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListar.Location = new Point(510, 51);
            lblListar.Name = "lblListar";
            lblListar.Size = new Size(227, 96);
            lblListar.TabIndex = 44;
            lblListar.Text = "Listar";
            // 
            // cmbOrdenar
            // 
            cmbOrdenar.BackColor = SystemColors.Window;
            cmbOrdenar.ForeColor = SystemColors.MenuText;
            cmbOrdenar.FormattingEnabled = true;
            cmbOrdenar.Items.AddRange(new object[] { "Título", "Director", "Año" });
            cmbOrdenar.Location = new Point(914, 170);
            cmbOrdenar.Name = "cmbOrdenar";
            cmbOrdenar.Size = new Size(151, 28);
            cmbOrdenar.TabIndex = 48;
            cmbOrdenar.Text = "Ordenar por";
            // 
            // frmListar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 713);
            Controls.Add(cmbOrdenar);
            Controls.Add(lstLista);
            Controls.Add(btnVolver);
            Controls.Add(lblListar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLista;
        private Button btnVolver;
        private Label lblListar;
        private ComboBox cmbOrdenar;
    }
}