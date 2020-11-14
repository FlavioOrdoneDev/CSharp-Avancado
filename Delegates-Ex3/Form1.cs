using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //btnClick.Click += delegate (object sender, EventArgs args)
            btnClick.Click += delegate
            {
                MessageBox.Show("Fui clicado");
            };
        }
    }
}
