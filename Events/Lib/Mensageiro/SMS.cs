using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Lib.Mensageiro
{
    public class SMS
    {
        // public void EnviarMensagem(Video video)
        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            // Console.WriteLine("SMS enviado para o video: " + video.Nome);
            Console.WriteLine("SMS enviado para o video: " + args.Video.Nome);
        }
    }
}
