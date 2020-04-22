using System;

namespace _03_Eventos.Lib.Mensageiro
{
    public class Email
    {

        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            Console.WriteLine("Email enviado para o vídeo: " + args.Video.Nome);
        }
    }
}
