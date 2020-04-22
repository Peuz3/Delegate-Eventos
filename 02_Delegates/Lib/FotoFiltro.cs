using System;

namespace _02_Delegates.Lib
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            //Algoritmo que faz colorimento
            Console.WriteLine("FotoFiltro > Colorir: " + foto.Nome);
        }

        public void GerarThumb(Foto foto)
        {
            //Algoritmo que faz colorimento
            Console.WriteLine("FotoFiltro > GerarThumb: " + foto.Nome);
        }

        public void PretoBranco(Foto foto)
        {
            //Algoritmo que faz colorimento
            Console.WriteLine("FotoFiltro > PretoBranco: " + foto.Nome);
        }

        public void RedimensionarTamMedio(Foto foto)
        {
            //Algoritmo que faz colorimento
            Console.WriteLine("FotoFiltro > RedimensionarTamMedio: " + foto.Nome);
        }
    }
}
