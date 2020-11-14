using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Lib.Mensageiro
{
    public class EMAIL
    {
        // public void EnviarMensagem(Video video)
        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            // Console.WriteLine("EMAIL enviado para o video: " + video.Nome);
            Console.WriteLine("EMAIL enviado para o video: " +args.Video.Nome);
        }
    }
}
