using CatalogoVisual.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVisual.controlador
{
    public static class UtilsStatic
    {

        public static List<Audiovisual> avs = new List<Audiovisual>(); //Lista principal que sera la que se carga y se guarda

        public static int maxId = 0; //Identificador para la foto

        //Metodo que completa una cadenahasta un tamaño dado con espacios
        public static string CompletarHasta(this string str, int size)
        {
            return str.PadRight(size, ' ');
        }

        //Metodo que comprueba si se puede leer un objeto de un fichero
        public static bool SePuedenLeer(this BinaryReader br, int numBytes)
        {
            bool sePuede = false;
            if (br != null)
            {
                sePuede = br.BaseStream.Length - br.BaseStream.Position >= numBytes;
            }
            return sePuede;
        }
    }
}
