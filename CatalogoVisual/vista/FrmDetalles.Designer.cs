namespace CatalogoVisual.vista
{
    partial class FrmDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalles));
            lblYear = new Label();
            lblDirector = new Label();
            lblTitulo = new Label();
            pctCartel = new PictureBox();
            lblAdicional = new Label();
            lblTituloMostrado = new Label();
            lblDirectorMostrado = new Label();
            lblYearMostrado = new Label();
            lblAdicionalMostrado = new Label();
            ((System.ComponentModel.ISupportInitialize)pctCartel).BeginInit();
            SuspendLayout();
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Bauhaus 93", 14F);
            lblYear.Location = new Point(278, 217);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(52, 28);
            lblYear.TabIndex = 17;
            lblYear.Text = "Año";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Bauhaus 93", 14F);
            lblDirector.Location = new Point(278, 131);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(100, 28);
            lblDirector.TabIndex = 16;
            lblDirector.Text = "Director";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bauhaus 93", 14F);
            lblTitulo.Location = new Point(278, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(72, 28);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Titulo";
            // 
            // pctCartel
            // 
            pctCartel.BackgroundImage = Properties.Resources.rollo;
            pctCartel.BackgroundImageLayout = ImageLayout.Stretch;
            pctCartel.InitialImage = (Image)resources.GetObject("pctCartel.InitialImage");
            pctCartel.Location = new Point(44, 95);
            pctCartel.Name = "pctCartel";
            pctCartel.Size = new Size(190, 252);
            pctCartel.TabIndex = 14;
            pctCartel.TabStop = false;
            // 
            // lblAdicional
            // 
            lblAdicional.AutoSize = true;
            lblAdicional.Font = new Font("Bauhaus 93", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdicional.Location = new Point(278, 307);
            lblAdicional.Name = "lblAdicional";
            lblAdicional.Size = new Size(114, 28);
            lblAdicional.TabIndex = 18;
            lblAdicional.Text = "Adicional";
            // 
            // lblTituloMostrado
            // 
            lblTituloMostrado.AutoSize = true;
            lblTituloMostrado.Location = new Point(278, 95);
            lblTituloMostrado.Name = "lblTituloMostrado";
            lblTituloMostrado.Size = new Size(47, 20);
            lblTituloMostrado.TabIndex = 19;
            lblTituloMostrado.Text = "Titulo";
            // 
            // lblDirectorMostrado
            // 
            lblDirectorMostrado.AutoSize = true;
            lblDirectorMostrado.Location = new Point(278, 177);
            lblDirectorMostrado.Name = "lblDirectorMostrado";
            lblDirectorMostrado.Size = new Size(63, 20);
            lblDirectorMostrado.TabIndex = 20;
            lblDirectorMostrado.Text = "Director";
            // 
            // lblYearMostrado
            // 
            lblYearMostrado.AutoSize = true;
            lblYearMostrado.Location = new Point(278, 260);
            lblYearMostrado.Name = "lblYearMostrado";
            lblYearMostrado.Size = new Size(36, 20);
            lblYearMostrado.TabIndex = 21;
            lblYearMostrado.Text = "Año";
            // 
            // lblAdicionalMostrado
            // 
            lblAdicionalMostrado.AutoSize = true;
            lblAdicionalMostrado.Location = new Point(278, 353);
            lblAdicionalMostrado.Name = "lblAdicionalMostrado";
            lblAdicionalMostrado.Size = new Size(72, 20);
            lblAdicionalMostrado.TabIndex = 22;
            lblAdicionalMostrado.Text = "Adicional";
            // 
            // FrmDetalles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(622, 433);
            Controls.Add(lblAdicionalMostrado);
            Controls.Add(lblYearMostrado);
            Controls.Add(lblDirectorMostrado);
            Controls.Add(lblTituloMostrado);
            Controls.Add(lblAdicional);
            Controls.Add(lblYear);
            Controls.Add(lblDirector);
            Controls.Add(lblTitulo);
            Controls.Add(pctCartel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDetalles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)pctCartel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYear;
        private Label lblDirector;
        private Label lblTitulo;
        private PictureBox pctCartel;
        private Label lblAdicional;
        private Label lblTituloMostrado;
        private Label lblDirectorMostrado;
        private Label lblYearMostrado;
        private Label lblAdicionalMostrado;
    }
}