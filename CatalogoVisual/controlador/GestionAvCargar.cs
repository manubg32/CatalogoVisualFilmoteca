using CatalogoVisual.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVisual.controlador
{
    public partial class GestionAv
    {

        private const int BYTES_REG_SERIE = 215;
        private const int BYTES_REG_PELICULA = 215;

        public static int maxId = 0;


        public static List<Audiovisual> CargarDeArchivo()
        {
            var lista = new List<Audiovisual>();


            //Si el archivo existe
            if (File.Exists("catalogo.dat"))
            {
                try
                {
                    using (var fileStr = new FileStream("catalogo.dat", FileMode.Open))
                    {
                        using (BinaryReader brFile = new BinaryReader(fileStr))
                        {
                            while (fileStr.Position < fileStr.Length - sizeof(Char))
                            {
                                char marca = brFile.ReadChar();//Depende de la marca se hace una cosa u otra
                                switch (marca)
                                {
                                    case MARCA_SERIE:
                                        if (brFile.SePuedenLeer(BYTES_REG_SERIE - sizeof(Char)))
                                        {
                                            lista.Add(CargarSerie(brFile));
                                        }

                                        break;
                                    case MARCA_PELICULA:
                                        if (brFile.SePuedenLeer(BYTES_REG_PELICULA - sizeof(Char)))
                                        {
                                            lista.Add(CargarPelicula(brFile));
                                        }

                                        break;
                                }
                            }
                            UtilsStatic.maxId = maxId;//Actualizamos el maxId
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR: Error durantre la carga del catálogo. Se ha leído {lista.Count} registros.\nDetalles: {e.ToString()}");
                }
            }

            return lista;
        }

        private static Audiovisual CargarPelicula(BinaryReader brFile)
        {
            string titulo = brFile.ReadString().Trim();
            string director = brFile.ReadString().Trim();
            int year = brFile.ReadInt32();
            int idFoto = brFile.ReadInt32();
            if (idFoto > maxId)
            {
                maxId = idFoto;
            }
            int duracion = brFile.ReadInt32();//Si es una pelicula tenemos en cuenta la duracion

            return new Pelicula(titulo, director, year, idFoto, duracion);
        }

        private static Audiovisual CargarSerie(BinaryReader br)
        {
            string titulo = br.ReadString().Trim();
            string director = br.ReadString().Trim();
            int year = br.ReadInt32();
            int idFoto = br.ReadInt32();
            if (idFoto > maxId)
            {
                maxId = idFoto;
            }
            int nCapitulos = br.ReadInt32();//Si es una serie tenemos en cuenta el numero de capitulos

            return new Serie(titulo, director, year, idFoto, nCapitulos);
        }

        public void CargarLista()
        {
            UtilsStatic.avs = CargarDeArchivo();
        }
    }

}
