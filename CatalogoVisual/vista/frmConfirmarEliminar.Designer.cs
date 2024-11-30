namespace CatalogoVisual
{
    partial class FrmConfirmarEliminar
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblEliminar = new Label();
            lstLista = new ListBox();
            lblElementos = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.Desktop;
            btnAceptar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = SystemColors.Window;
            btnAceptar.Location = new Point(675, 603);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(186, 61);
            btnAceptar.TabIndex = 41;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(425, 603);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(186, 61);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.Font = new Font("Bauhaus 93", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminar.Location = new Point(460, 49);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(338, 96);
            lblEliminar.TabIndex = 39;
            lblEliminar.Text = "Eliminar";
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(460, 261);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(338, 264);
            lstLista.TabIndex = 42;
            // 
            // lblElementos
            // 
            lblElementos.AutoSize = true;
            lblElementos.Font = new Font("Bauhaus 93", 18F);
            lblElementos.Location = new Point(325, 183);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(681, 34);
            lblElementos.TabIndex = 43;
            lblElementos.Text = "Está a punto de eliminar los siguientes elementos:";
            // 
            // frmConfirmarEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 713);
            Controls.Add(lblElementos);
            Controls.Add(lstLista);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblEliminar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmConfirmarEliminar";
            Text = "¿Estás Seguro?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblEliminar;
        private ListBox lstLista;
        private Label lblElementos;
    }
}