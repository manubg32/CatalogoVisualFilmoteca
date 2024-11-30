﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVisual.modelo { 

    public abstract class Audiovisual
    {
        //Tamaño maximo del titulo
        public const int MAX_TITULO = 100;

        //Tamaño maximo del director
        public const int MAX_DIRECTOR = 100;

        private string titulo;
        private string? director;
        private int year;
        private int idFoto;

        public int IdFoto
        {
            get
            {
                return idFoto;
            }
            set
            {
                idFoto = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value > 0 && value <= DateTime.Today.Year)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("El año deber ser un valor positivo y menor o igual al año actual ");
                }
            }
        }

        public String Director
        {
            get
            {
                return director;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length <= MAX_DIRECTOR)
                {
                    director = value;
                }
                else
                {
                    director = "Anonimo";
                }
            }

        }

        public String Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length <= MAX_TITULO)
                {
                    titulo = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("El titulo de la pelicula no puede quedar vacío y debe tener menos de 100 caracteres");
                }
            }
        }
        protected Audiovisual(String titulo, String? director, int year, int idFoto)
        {
            Titulo = titulo;
            Director = director;
            Year = year;
            IdFoto = idFoto;
        }

        public abstract String Describir();
    }
}
