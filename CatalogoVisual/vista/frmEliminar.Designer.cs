namespace CatalogoVisual
{
    partial class FrmEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminar));
            btnEliminar = new Button();
            btnCancelar = new Button();
            txtYear = new TextBox();
            lblYear = new Label();
            txtDirector = new TextBox();
            lblDirector = new Label();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            lblEliminar = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Desktop;
            btnEliminar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.Window;
            btnEliminar.Location = new Point(692, 603);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 61);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(442, 603);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(186, 61);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtYear
            // 
            txtYear.BackColor = SystemColors.ActiveBorder;
            txtYear.Location = new Point(692, 417);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(151, 27);
            txtYear.TabIndex = 34;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Bauhaus 93", 25F);
            lblYear.Location = new Point(455, 408);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(91, 48);
            lblYear.TabIndex = 33;
            lblYear.Text = "Año";
            // 
            // txtDirector
            // 
            txtDirector.BackColor = SystemColors.ActiveBorder;
            txtDirector.Location = new Point(692, 331);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(151, 27);
            txtDirector.TabIndex = 32;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Bauhaus 93", 25F);
            lblDirector.Location = new Point(455, 321);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(173, 48);
            lblDirector.TabIndex = 31;
            lblDirector.Text = "Director";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.ActiveBorder;
            txtTitulo.Location = new Point(692, 245);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(151, 27);
            txtTitulo.TabIndex = 30;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bauhaus 93", 25F);
            lblTitulo.Location = new Point(455, 236);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 48);
            lblTitulo.TabIndex = 29;
            lblTitulo.Text = "Titulo";
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.Font = new Font("Bauhaus 93", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminar.Location = new Point(489, 49);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(338, 96);
            lblEliminar.TabIndex = 26;
            lblEliminar.Text = "Eliminar";
            // 
            // FrmEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 713);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtDirector);
            Controls.Add(lblDirector);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblEliminar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnCancelar;
        private TextBox txtYear;
        private Label lblYear;
        private TextBox txtDirector;
        private Label lblDirector;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private Label lblEliminar;
    }
}