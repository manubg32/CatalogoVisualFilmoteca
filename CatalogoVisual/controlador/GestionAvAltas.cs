using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoVisual.modelo;

namespace CatalogoVisual.controlador;

public partial class GestionAv
{
    public void AltaPelicula(string titulo, string? director, int year, int idFoto, int duracion)
    {
        //damos de alta una pelicula y la añadimos a la lista de audiovisuales

        Pelicula nueva = new Pelicula(titulo, director, year, idFoto, duracion);
        UtilsStatic.avs.Add(nueva);
    }

    public void AltaSerie(string? titulo, string? director, int year, int idFoto, int nCapitulos)
    {
        //damos de alta una serie y la añadimos a la lista de audiovisuales
        Serie nueva = new Serie(titulo, director, year, idFoto, nCapitulos);
        UtilsStatic.avs.Add(nueva);
    }
}
