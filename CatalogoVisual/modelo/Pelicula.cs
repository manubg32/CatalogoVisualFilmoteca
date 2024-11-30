using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVisual.modelo
{



    public class Pelicula : Audiovisual
    {
        private int duracion;

        public int Duracion
        {
            get
            {
                return duracion;
            }
            set
            {
                if (value > 0)
                {
                    duracion = value;
                }
                else
                {
                    throw new Exception("La duracion debe ser superior a 0");
                }
            }
        }

        public Pelicula(String titulo, String director, int year, int idFoto, int duracion) : base(titulo, director, year, idFoto)
        {
            Duracion = duracion;

        }

        public override string Describir()
        {
            return $"La pelicula {Titulo} ({Year}), dirijida por el director: {Director}, tiene una duracion de {Duracion} minutos.";
        }
    }
}
