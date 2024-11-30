namespace CatalogoVisual
{
    partial class FrmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcercaDe));
            pctFilmoteca = new PictureBox();
            pctLogo = new PictureBox();
            lblInfo = new Label();
            lblCopy = new Label();
            ((System.ComponentModel.ISupportInitialize)pctFilmoteca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            SuspendLayout();
            // 
            // pctFilmoteca
            // 
            pctFilmoteca.Image = (Image)resources.GetObject("pctFilmoteca.Image");
            pctFilmoteca.Location = new Point(67, 23);
            pctFilmoteca.Name = "pctFilmoteca";
            pctFilmoteca.Size = new Size(1128, 162);
            pctFilmoteca.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFilmoteca.TabIndex = 1;
            pctFilmoteca.TabStop = false;
            // 
            // pctLogo
            // 
            pctLogo.Image = Properties.Resources.rollo;
            pctLogo.Location = new Point(527, 478);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(199, 176);
            pctLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLogo.TabIndex = 2;
            pctLogo.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(185, 277);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(898, 20);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Proyecto realizado por Manuel Borrero Guerrero  para la asignatura de Desarrollo de Interfaces de 2º de D.A.M., Profesor Juan Antonio";
            // 
            // lblCopy
            // 
            lblCopy.AutoSize = true;
            lblCopy.Location = new Point(433, 380);
            lblCopy.Name = "lblCopy";
            lblCopy.Size = new Size(377, 20);
            lblCopy.TabIndex = 4;
            lblCopy.Text = "© 2024 Manuel Borrero. Todos los derechos reservados.";
            // 
            // FrmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 713);
            Controls.Add(lblCopy);
            Controls.Add(lblInfo);
            Controls.Add(pctLogo);
            Controls.Add(pctFilmoteca);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAcercaDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)pctFilmoteca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctFilmoteca;
        private PictureBox pctLogo;
        private Label lblInfo;
        private Label lblCopy;
    }
}