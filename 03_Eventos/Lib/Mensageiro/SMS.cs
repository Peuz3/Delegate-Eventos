using System;

namespace _03_Eventos.Lib.Mensageiro
{
    public class SMS
    {

        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            Console.WriteLine("SMS enviado para o vídeo: " + args.Video.Nome);
        }
    }
}
