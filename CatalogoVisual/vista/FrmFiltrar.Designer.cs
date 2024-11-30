namespace CatalogoVisual
{
    partial class FrmFiltrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltrar));
            btnFiltrar = new Button();
            btnCancelar = new Button();
            txtYear = new TextBox();
            lblYear = new Label();
            txtDirector = new TextBox();
            lblDirector = new Label();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            lblFiltrar = new Label();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = SystemColors.Desktop;
            btnFiltrar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = SystemColors.Window;
            btnFiltrar.Location = new Point(663, 606);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(186, 61);
            btnFiltrar.TabIndex = 25;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(413, 606);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(186, 61);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtYear
            // 
            txtYear.BackColor = SystemColors.ActiveBorder;
            txtYear.Location = new Point(663, 444);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(151, 27);
            txtYear.TabIndex = 21;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Bauhaus 93", 25F);
            lblYear.Location = new Point(426, 435);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(91, 48);
            lblYear.TabIndex = 20;
            lblYear.Text = "Año";
            // 
            // txtDirector
            // 
            txtDirector.BackColor = SystemColors.ActiveBorder;
            txtDirector.Location = new Point(663, 358);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(151, 27);
            txtDirector.TabIndex = 19;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Bauhaus 93", 25F);
            lblDirector.Location = new Point(426, 348);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(173, 48);
            lblDirector.TabIndex = 18;
            lblDirector.Text = "Director";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.ActiveBorder;
            txtTitulo.Location = new Point(663, 272);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(151, 27);
            txtTitulo.TabIndex = 17;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bauhaus 93", 25F);
            lblTitulo.Location = new Point(426, 263);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 48);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Titulo";
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Bauhaus 93", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiltrar.Location = new Point(512, 46);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(259, 96);
            lblFiltrar.TabIndex = 13;
            lblFiltrar.Text = "Filtrar";
            // 
            // FrmFiltrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 713);
            Controls.Add(btnFiltrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtDirector);
            Controls.Add(lblDirector);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblFiltrar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FrmFiltrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private Button btnCancelar;
        private TextBox txtCambiante;
        private Label lblCambiante;
        private TextBox txtYear;
        private Label lblYear;
        private TextBox txtDirector;
        private Label lblDirector;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private Label lblFiltrar;
    }
}