namespace CatalogoVisual
{
    partial class FrmActualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizar));
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtCambiante = new TextBox();
            lblCambiante = new Label();
            txtYear = new TextBox();
            lblYear = new Label();
            txtDirector = new TextBox();
            lblDirector = new Label();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            lblActualizar = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Desktop;
            btnGuardar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(663, 606);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(186, 61);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(413, 606);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(186, 61);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtCambiante
            // 
            txtCambiante.BackColor = SystemColors.ActiveBorder;
            txtCambiante.Location = new Point(671, 461);
            txtCambiante.Name = "txtCambiante";
            txtCambiante.Size = new Size(151, 27);
            txtCambiante.TabIndex = 21;
            txtCambiante.Visible = false;
            // 
            // lblCambiante
            // 
            lblCambiante.AutoSize = true;
            lblCambiante.Font = new Font("Bauhaus 93", 25F);
            lblCambiante.Location = new Point(434, 452);
            lblCambiante.Name = "lblCambiante";
            lblCambiante.Size = new Size(31, 48);
            lblCambiante.TabIndex = 20;
            lblCambiante.Text = " ";
            // 
            // txtYear
            // 
            txtYear.BackColor = SystemColors.ActiveBorder;
            txtYear.Location = new Point(671, 379);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(151, 27);
            txtYear.TabIndex = 19;
            txtYear.Visible = false;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Bauhaus 93", 25F);
            lblYear.Location = new Point(434, 370);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(91, 48);
            lblYear.TabIndex = 18;
            lblYear.Text = "Año";
            lblYear.Visible = false;
            // 
            // txtDirector
            // 
            txtDirector.BackColor = SystemColors.ActiveBorder;
            txtDirector.Location = new Point(671, 293);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(151, 27);
            txtDirector.TabIndex = 17;
            txtDirector.Visible = false;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Bauhaus 93", 25F);
            lblDirector.Location = new Point(434, 283);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(173, 48);
            lblDirector.TabIndex = 16;
            lblDirector.Text = "Director";
            lblDirector.Visible = false;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.ActiveBorder;
            txtTitulo.Location = new Point(671, 207);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(151, 27);
            txtTitulo.TabIndex = 15;
            txtTitulo.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bauhaus 93", 25F);
            lblTitulo.Location = new Point(434, 198);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 48);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Titulo";
            lblTitulo.Visible = false;
            // 
            // lblActualizar
            // 
            lblActualizar.AutoSize = true;
            lblActualizar.Font = new Font("Bauhaus 93", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActualizar.Location = new Point(424, 51);
            lblActualizar.Name = "lblActualizar";
            lblActualizar.Size = new Size(425, 96);
            lblActualizar.TabIndex = 13;
            lblActualizar.Text = "Actualizar";
            // 
            // frmActualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 713);
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
            Controls.Add(lblActualizar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmActualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtCambiante;
        private Label lblCambiante;
        private TextBox txtYear;
        private Label lblYear;
        private TextBox txtDirector;
        private Label lblDirector;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private Label lblActualizar;
    }
}