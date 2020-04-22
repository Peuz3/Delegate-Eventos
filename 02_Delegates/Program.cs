using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Delegates.Lib;

namespace _02_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            //Passando um objeto como parâmetro

            //Simulações
            //Tela de cadastro de usuário - Thumb (foto do perfil)
            Foto fotoUsuario = new Foto { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1000 };
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processar(fotoUsuario);//Passando um objeto como parâmetro

            //Tela de cadastro de produtos: Colorir + Tamanho Médio
            Foto fotoProduto = new Foto { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1000 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            //Para haver a outra chamada de um método delegate deve-se usar o += para concatenar
            FotoProcessador.filtros += new FotoFiltro().RedimensionarTamMedio;
            FotoProcessador.Processar(fotoProduto);


            //Tela de cadastro de Álbum do Usuário - Preto e Branco
            Foto fotoAlbum = new Foto { Nome = "album.jpg", TamanhoX = 1920, TamanhoY = 1000 };
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processar(fotoAlbum);


            Console.ReadLine();

        }
    }
}
