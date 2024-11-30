namespace CatalogoVisual
{
    partial class FrmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlta));
            lblAltas = new Label();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblDirector = new Label();
            txtDirector = new TextBox();
            lblYear = new Label();
            txtYear = new TextBox();
            lblCambiante = new Label();
            txtCambiante = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            pctAv = new PictureBox();
            lblHint = new Label();
            ((System.ComponentModel.ISupportInitialize)pctAv).BeginInit();
            SuspendLayout();
            // 
            // lblAltas
            // 
            lblAltas.AutoSize = true;
            lblAltas.Font = new Font("Bauhaus 93", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltas.Location = new Point(549, 34);
            lblAltas.Name = "lblAltas";
            lblAltas.Size = new Size(222, 96);
            lblAltas.TabIndex = 0;
            lblAltas.Text = "Altas";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Bauhaus 93", 25F);
            lblTipo.Location = new Point(558, 165);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(101, 48);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = SystemColors.ActiveBorder;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Serie", "Pelicula" });
            cmbTipo.Location = new Point(795, 175);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 2;
            cmbTipo.Text = "Seleccione";
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bauhaus 93", 25F);
            lblTitulo.Location = new Point(558, 254);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 48);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo";
            lblTitulo.Visible = false;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.ActiveBorder;
            txtTitulo.Location = new Point(795, 263);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(151, 27);
            txtTitulo.TabIndex = 4;
            txtTitulo.Visible = false;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Bauhaus 93", 25F);
            lblDirector.Location = new Point(558, 339);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(173, 48);
            lblDirector.TabIndex = 5;
            lblDirector.Text = "Director";
            lblDirector.Visible = false;
            // 
            // txtDirector
            // 
            txtDirector.BackColor = SystemColors.ActiveBorder;
            txtDirector.Location = new Point(795, 349);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(151, 27);
            txtDirector.TabIndex = 6;
            txtDirector.Visible = false;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Bauhaus 93", 25F);
            lblYear.Location = new Point(558, 426);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(91, 48);
            lblYear.TabIndex = 7;
            lblYear.Text = "Año";
            lblYear.Visible = false;
            // 
            // txtYear
            // 
            txtYear.BackColor = SystemColors.ActiveBorder;
            txtYear.Location = new Point(795, 435);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(151, 27);
            txtYear.TabIndex = 8;
            txtYear.Visible = false;
            // 
            // lblCambiante
            // 
            lblCambiante.AutoSize = true;
            lblCambiante.Font = new Font("Bauhaus 93", 25F);
            lblCambiante.Location = new Point(558, 508);
            lblCambiante.Name = "lblCambiante";
            lblCambiante.Size = new Size(31, 48);
            lblCambiante.TabIndex = 9;
            lblCambiante.Text = " ";
            // 
            // txtCambiante
            // 
            txtCambiante.BackColor = SystemColors.ActiveBorder;
            txtCambiante.Location = new Point(795, 517);
            txtCambiante.Name = "txtCambiante";
            txtCambiante.Size = new Size(151, 27);
            txtCambiante.TabIndex = 10;
            txtCambiante.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(450, 594);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(186, 61);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Desktop;
            btnGuardar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(700, 594);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(186, 61);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pctAv
            // 
            pctAv.BackgroundImage = Properties.Resources.rollo;
            pctAv.BackgroundImageLayout = ImageLayout.Stretch;
            pctAv.Location = new Point(190, 175);
            pctAv.Name = "pctAv";
            pctAv.Size = new Size(297, 381);
            pctAv.TabIndex = 13;
            pctAv.TabStop = false;
            pctAv.Visible = false;
            pctAv.Click += pctAv_Click;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Location = new Point(182, 152);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(305, 20);
            lblHint.TabIndex = 14;
            lblHint.Text = "Pulse sobre la imagen para agregar un cartel";
            lblHint.Visible = false;
            // 
            // FrmAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 713);
            Controls.Add(lblHint);
            Controls.Add(pctAv);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtCambiante);
            Controls.Add(lblCambiante);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtDirector);
            Controls.Add(lblDirector);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lblAltas);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Altas";
            ((System.ComponentModel.ISupportInitialize)pctAv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltas;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblDirector;
        private TextBox txtDirector;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblCambiante;
        private TextBox txtCambiante;
        public static Button btnCancelar;
        private Button btnGuardar;
        private PictureBox pctAv;
        private Label lblHint;
    }
}