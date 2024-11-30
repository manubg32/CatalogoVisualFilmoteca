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
    public partial class FrmFiltrar : Form
    {
        public FrmFiltrar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuPrincipal.estaFiltrando = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String titulo = "";
            String director = "";
            int year;

            bool mismoTitulo = true;
            bool mismoDirector = true;
            bool mismoYear = true;


            FrmMenuPrincipal.avsFiltrados.Clear();

            if (!string.IsNullOrEmpty(txtTitulo.Text))
            {
                titulo = txtTitulo.Text;
            }

            if (!string.IsNullOrEmpty(txtDirector.Text))
            {
                director = txtDirector.Text;
            }

            foreach (Audiovisual a in FrmMenuPrincipal.avs)
            {
                mismoTitulo = true;
                mismoDirector = true;
                mismoYear = true;

                if (titulo.Length > 0)
                {
                    if (!a.Titulo.Equals(titulo))
                    {
                        mismoTitulo = false;
                    }
                }

                if (director.Length > 0)
                {
                    if (!a.Director.Equals(director))
                    {
                        mismoDirector = false;
                    }
                }


                if (!string.IsNullOrEmpty(txtYear.Text))
                {
                    if (int.TryParse(txtYear.Text, out int yearParseado))
                    {
                        if (yearParseado != a.Year)
                        {
                            mismoYear = false;
                        }
                        
                    }
                    else
                    {
                        mismoYear = false;
                    }
                }

                if (mismoTitulo && mismoDirector && mismoYear)
                {
                    FrmMenuPrincipal.avsFiltrados.Add(a);
                }
            }

            if (FrmMenuPrincipal.avsFiltrados.Count > 0)
            {
                FrmMenuPrincipal.avsMostrados = FrmMenuPrincipal.avsFiltrados;
                FrmMenuPrincipal.estaFiltrando = true;
                txtTitulo.Text = "";
                txtDirector.Text = "";
                txtYear.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay elementos que coincidan\nProbemos de nuevo", "Algo fue mal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitulo.Text = "";
                txtDirector.Text = "";
                txtYear.Text = "";
            }

        }
    }
}
