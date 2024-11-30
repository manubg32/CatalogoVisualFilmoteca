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

namespace CatalogoVisual.vista
{
    public partial class FrmDetalles : Form
    {
        public FrmDetalles(modelo.Audiovisual avMostrado)
        {
            InitializeComponent();

            Serie s;
            Pelicula p;

            if (avMostrado is Serie)
            {
                lblAdicional.Text = "Nº Capitulos";
                s = (Serie)avMostrado;
                lblAdicionalMostrado.Text = s.NCapitulos.ToString();
            } else if (avMostrado is Pelicula)
            {
                lblAdicional.Text = "Duración";
                p = (Pelicula)avMostrado;
                lblAdicionalMostrado.Text = p.Duracion.ToString();
            }

            try
            {
                String? ruta = $"Resources\\Carteles\\{avMostrado.IdFoto}.jpg";
                pctCartel.Image = Image.FromFile(ruta);
                pctCartel.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch (FileNotFoundException ignore) { }

            lblTituloMostrado.Text = avMostrado.Titulo;
            lblDirectorMostrado.Text = avMostrado.Director;
            lblYearMostrado.Text = avMostrado.Year.ToString();


        }
    }
}
