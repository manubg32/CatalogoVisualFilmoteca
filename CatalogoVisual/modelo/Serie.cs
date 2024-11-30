using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVisual.modelo
{
    public class Serie : Audiovisual
    {

        private int nCapitulos;

        public int NCapitulos
        {
            get
            {
                return nCapitulos;
            }
            set
            {
                if (value > 0)
                {
                    nCapitulos = value;
                }
                else
                {
                    throw new Exception("El numero de capitulos no puede ser negativo");
                }
            }
        }


        public Serie(String titulo, String director, int year, int idFoto, int nCapitulos) : base(titulo, director, year, idFoto)
        {
            NCapitulos = nCapitulos;
        }

        public override string Describir()
        {
            return $"La serie {Titulo} ({Year}), dirijida por el director: {Director}, tiene un total de {NCapitulos} capitulos.";
        }

    }
}
