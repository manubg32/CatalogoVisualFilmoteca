namespace CatalogoVisual
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            pctFilmoteca = new PictureBox();
            btnAltas = new Button();
            btnFiltrar = new Button();
            btnEliminar = new Button();
            lblCopy = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            pctCartel = new PictureBox();
            btnDetalles = new Button();
            lblTitulo = new Label();
            lblDirector = new Label();
            lblYear = new Label();
            lblTituloMostrado = new Label();
            lblDirectorMostrado = new Label();
            lblYearMostrado = new Label();
            cmbOrdenar = new ComboBox();
            lblElemento = new Label();
            ((System.ComponentModel.ISupportInitialize)pctFilmoteca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctCartel).BeginInit();
            SuspendLayout();
            // 
            // pctFilmoteca
            // 
            pctFilmoteca.Image = (Image)resources.GetObject("pctFilmoteca.Image");
            pctFilmoteca.Location = new Point(67, 21);
            pctFilmoteca.Name = "pctFilmoteca";
            pctFilmoteca.Size = new Size(1128, 162);
            pctFilmoteca.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFilmoteca.TabIndex = 0;
            pctFilmoteca.TabStop = false;
            // 
            // btnAltas
            // 
            btnAltas.AutoSize = true;
            btnAltas.BackColor = Color.Black;
            btnAltas.Font = new Font("Bauhaus 93", 20F);
            btnAltas.ForeColor = Color.White;
            btnAltas.Location = new Point(249, 607);
            btnAltas.Name = "btnAltas";
            btnAltas.Size = new Size(247, 51);
            btnAltas.TabIndex = 1;
            btnAltas.Text = "Alta";
            btnAltas.UseVisualStyleBackColor = false;
            btnAltas.Click += btnAltas_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.AutoSize = true;
            btnFiltrar.BackColor = Color.Black;
            btnFiltrar.Font = new Font("Bauhaus 93", 20F);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(502, 607);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(247, 51);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.BackColor = Color.Black;
            btnEliminar.Font = new Font("Bauhaus 93", 20F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(755, 607);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(247, 51);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblCopy
            // 
            lblCopy.AutoSize = true;
            lblCopy.Font = new Font("Bauhaus 93", 9F);
            lblCopy.Location = new Point(1026, 673);
            lblCopy.Name = "lblCopy";
            lblCopy.Size = new Size(169, 16);
            lblCopy.TabIndex = 5;
            lblCopy.Text = "Manuel Borrero. © 2024";
            lblCopy.Click += lblCopy_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.Black;
            btnSiguiente.Font = new Font("Bauhaus 93", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.Window;
            btnSiguiente.Location = new Point(1078, 306);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(90, 135);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.Black;
            btnAnterior.Font = new Font("Bauhaus 93", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = SystemColors.Window;
            btnAnterior.Location = new Point(95, 306);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(90, 135);
            btnAnterior.TabIndex = 7;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // pctCartel
            // 
            pctCartel.BackgroundImage = Properties.Resources.rollo;
            pctCartel.BackgroundImageLayout = ImageLayout.Stretch;
            pctCartel.InitialImage = (Image)resources.GetObject("pctCartel.InitialImage");
            pctCartel.Location = new Point(205, 219);
            pctCartel.Name = "pctCartel";
            pctCartel.Size = new Size(276, 363);
            pctCartel.TabIndex = 8;
            pctCartel.TabStop = false;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.Black;
            btnDetalles.ForeColor = SystemColors.Window;
            btnDetalles.Location = new Point(908, 553);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(94, 29);
            btnDetalles.TabIndex = 9;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bauhaus 93", 18F);
            lblTitulo.Location = new Point(502, 283);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(110, 34);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Titulo: ";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Bauhaus 93", 18F);
            lblDirector.Location = new Point(502, 385);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(138, 34);
            lblDirector.TabIndex = 12;
            lblDirector.Text = "Director:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Bauhaus 93", 18F);
            lblYear.Location = new Point(502, 494);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(77, 34);
            lblYear.TabIndex = 13;
            lblYear.Text = "Año:";
            // 
            // lblTituloMostrado
            // 
            lblTituloMostrado.AutoSize = true;
            lblTituloMostrado.Font = new Font("Segoe UI", 14F);
            lblTituloMostrado.Location = new Point(618, 285);
            lblTituloMostrado.Name = "lblTituloMostrado";
            lblTituloMostrado.Size = new Size(0, 32);
            lblTituloMostrado.TabIndex = 14;
            // 
            // lblDirectorMostrado
            // 
            lblDirectorMostrado.AutoSize = true;
            lblDirectorMostrado.Font = new Font("Segoe UI", 14F);
            lblDirectorMostrado.Location = new Point(646, 387);
            lblDirectorMostrado.Name = "lblDirectorMostrado";
            lblDirectorMostrado.Size = new Size(0, 32);
            lblDirectorMostrado.TabIndex = 15;
            // 
            // lblYearMostrado
            // 
            lblYearMostrado.AutoSize = true;
            lblYearMostrado.Font = new Font("Segoe UI", 14F);
            lblYearMostrado.Location = new Point(585, 496);
            lblYearMostrado.Name = "lblYearMostrado";
            lblYearMostrado.Size = new Size(0, 32);
            lblYearMostrado.TabIndex = 16;
            // 
            // cmbOrdenar
            // 
            cmbOrdenar.BackColor = SystemColors.MenuText;
            cmbOrdenar.ForeColor = SystemColors.Window;
            cmbOrdenar.FormattingEnabled = true;
            cmbOrdenar.Items.AddRange(new object[] { "Titulo", "Director", "Año" });
            cmbOrdenar.Location = new Point(906, 236);
            cmbOrdenar.Name = "cmbOrdenar";
            cmbOrdenar.Size = new Size(96, 28);
            cmbOrdenar.TabIndex = 17;
            cmbOrdenar.Text = "Ordenar";
            cmbOrdenar.SelectedIndexChanged += cmbOrdenar_SelectedIndexChanged;
            // 
            // lblElemento
            // 
            lblElemento.AutoSize = true;
            lblElemento.Location = new Point(646, 210);
            lblElemento.Name = "lblElemento";
            lblElemento.Size = new Size(72, 20);
            lblElemento.TabIndex = 18;
            lblElemento.Text = "Elemento";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 713);
            Controls.Add(lblElemento);
            Controls.Add(cmbOrdenar);
            Controls.Add(lblYearMostrado);
            Controls.Add(lblDirectorMostrado);
            Controls.Add(lblTituloMostrado);
            Controls.Add(lblYear);
            Controls.Add(lblDirector);
            Controls.Add(lblTitulo);
            Controls.Add(btnDetalles);
            Controls.Add(pctCartel);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(lblCopy);
            Controls.Add(btnEliminar);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAltas);
            Controls.Add(pctFilmoteca);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filmoteca";
            ((System.ComponentModel.ISupportInitialize)pctFilmoteca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctCartel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctFilmoteca;
        private Button btnAltas;
        private Button btnFiltrar;
        private Button btnEliminar;
        private Label lblCopy;
        private Button btnSiguiente;
        private Button btnAnterior;
        private PictureBox pctCartel;
        private Button btnDetalles;
        private Label lblTitulo;
        private Label lblDirector;
        private Label lblYear;
        private Label lblTituloMostrado;
        private Label lblDirectorMostrado;
        private Label lblYearMostrado;
        private ComboBox cmbOrdenar;
        private Label lblElemento;
    }
}
