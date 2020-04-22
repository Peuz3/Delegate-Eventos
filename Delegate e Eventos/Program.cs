using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates

{
    class Program
    {
        //Declarando um delegate
        delegate int Calcular(int a, int b);

        static void Main(string[] args)
        {

            Calcular calSoma = new Calcular(Soma);
            int soma = calSoma(50, 30);

            Calcular calSubtracao = new Calcular(Subtracao);
            int subtracao = calSubtracao(60, 25);
            
            
            //Forma tradicional de chamar métodos
            /*
            var soma = Soma(10, 20);
            var subtracao = Subtracao(20, 10);
            */
            Console.WriteLine("Soma: " + soma);

            Console.WriteLine("Subtração: " + subtracao);

            Console.ReadLine();
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtracao (int a, int b)
        {
            return a - b;
        }
    }
}
