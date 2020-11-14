using Events.Lib;
using Events.Lib.Mensageiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnVideoEncode_Click(object sender, EventArgs e)
        {
            Video video = new Video() { Nome = "video.mp4" };

            VideoEncode videoEncode = new VideoEncode();

            videoEncode.Encoded += new EMAIL().EnviarMensagem;
            videoEncode.Encoded += new SMS().EnviarMensagem;

            videoEncode.Encode(video);
        }
    }
}
