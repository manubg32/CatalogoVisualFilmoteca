using CatalogoVisual.controlador;
using CatalogoVisual.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoVisual
{
    public partial class FrmAlta : Form
    {

        GestionAv ga = new GestionAv();

        public FrmAlta()
        {
            InitializeComponent();
            if (FrmMenuPrincipal.avs.Count == 0)
            {
                btnCancelar.Visible = false;
            }
            else
            {
                btnCancelar.Visible = true;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el elemento seleccionado
            string opcionSeleccionada = cmbTipo.SelectedItem.ToString();

            // Ejecutar acciones según la opción
            switch (opcionSeleccionada)
            {
                case "Serie":
                    activarBotones();
                    lblCambiante.Text = "Capítulos ";
                    break;
                case "Pelicula":
                    activarBotones();
                    lblCambiante.Text = "Duración ";
                    break;
            }
        }

        private void activarBotones()
        {
            lblTitulo.Visible = true;
            txtTitulo.Visible = true;
            lblDirector.Visible = true;
            txtDirector.Visible = true;
            lblYear.Visible = true;
            txtYear.Visible = true;
            lblCambiante.Visible = true;
            txtCambiante.Visible = true;
            pctAv.Visible = true;
            lblHint.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerramos el frame
        }

        private void pctAv_Click(object sender, EventArgs e)
        {
            // Creamos y configuramos el cuadro de dislogo para abrir archivos
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;", // Filtro para imagenes
                Title = "Selecciona una imagen"
            };

            // Mostrar el cuadro de diálogo y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                pctAv.Image = Image.FromFile(openFileDialog.FileName);
                pctAv.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            String queja = "";
            bool creado = false;

            if (!string.IsNullOrEmpty(txtTitulo.Text) && txtTitulo.Text.Length <= 100)
            {
                txtTitulo.BackColor = SystemColors.ActiveBorder;
                if (txtDirector.Text.Length <= 100)
                {
                    txtDirector.BackColor = SystemColors.ActiveBorder;
                    if (int.TryParse(txtYear.Text, out int year))
                    {
                        txtDirector.BackColor = SystemColors.ActiveBorder;
                        if (year > 0 && year <= DateTime.Today.Year)
                        {
                            txtYear.BackColor = SystemColors.ActiveBorder;
                            if (int.TryParse(txtCambiante.Text, out int cambiante))
                            {
                                txtCambiante.BackColor = SystemColors.ActiveBorder;
                                if (cambiante > 0)
                                {
                                    txtCambiante.BackColor = SystemColors.ActiveBorder;
                                    if (cmbTipo.SelectedIndex == 0)
                                    {
                                        string idFoto = (++UtilsStatic.maxId).ToString();

                                        if (pctAv.Image != null)
                                        {
                                            // Ruta relativa a la carpeta de ejecución del proyecto
                                            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Carteles");

                                            // Crear la carpeta si no existe
                                            if (!Directory.Exists(rutaCarpeta))
                                            {
                                                Directory.CreateDirectory(rutaCarpeta);
                                            }
                                            //Generamos la ruta completa del archivo
                                            string rutaCompleta = Path.Combine(rutaCarpeta, $"{idFoto}.jpg");

                                            //Guardamos la imagen en la ruta especificada
                                            pctAv.Image.Save(rutaCompleta, System.Drawing.Imaging.ImageFormat.Jpeg);
                                        }
                                        ga.AltaSerie(txtTitulo.Text, txtDirector.Text, year, Int32.Parse(idFoto), cambiante);
                                        creado = true;
                                    }
                                    else if (cmbTipo.SelectedIndex == 1)
                                    {

                                        string idFoto = (++UtilsStatic.maxId).ToString();

                                        if (pctAv.Image != null)
                                        {
                                            // Ruta relativa a la carpeta de ejecución del proyecto
                                            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Carteles");

                                            // Crear la carpeta si no existe
                                            if (!Directory.Exists(rutaCarpeta))
                                            {
                                                Directory.CreateDirectory(rutaCarpeta);
                                            }

                                            // Generar la ruta completa del archivo
                                            string rutaCompleta = Path.Combine(rutaCarpeta, $"{idFoto}.jpg");

                                            // Guardar la imagen en la ruta especificada
                                            pctAv.Image.Save(rutaCompleta, System.Drawing.Imaging.ImageFormat.Jpeg);
                                        }

                                        // Lógica para dar de alta la película
                                        ga.AltaPelicula(txtTitulo.Text.ToString(), txtDirector.Text.ToString(), year, Int32.Parse(idFoto), cambiante);

                                        creado = true;

                                    }
                                }
                                else
                                {
                                    queja += $"\n{lblCambiante.Text}debe ser positivo";
                                    txtCambiante.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                queja += $"\n{lblCambiante.Text}debe ser un número";
                                txtCambiante.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            queja += "\nEl año debe ser positivo y menor o igual al año actual";
                            txtYear.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        queja += "\nEl año debe ser un número";
                        txtYear.BackColor = Color.Red;
                    }
                }
                else
                {
                    queja += "\nEl director debe tener menos de 100 carácteres";
                    txtDirector.BackColor = Color.Red;
                }
            }
            else
            {
                queja += "\nEl título no puede estar vacío y debe tener menos de 100 carácteres";
                txtTitulo.BackColor = Color.Red;
            }

            if (creado){
                MessageBox.Show("Audiovisual dado de alta correctamente", "Todo fue bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitulo.Text = "";
                txtDirector.Text = "";
                txtYear.Text = "";
                txtCambiante.Text = "";
                FrmMenuPrincipal.esElPrimero = false;
                this.Close();
            }
            else
            {
                MessageBox.Show(queja, "Algo no fue bien...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }   
    }
}
