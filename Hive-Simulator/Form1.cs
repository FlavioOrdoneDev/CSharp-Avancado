using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hive_Simulator
{
    public partial class Form1 : Form
    {

        Queen queen;
        public Form1()
        {
            /*
                Coletar Nectar
                Cuidar do Ovos
                Manter a Colmeia
                Cuidar dos Filhotes
                Produzir Mel
                Patrulhar a Colmeia 
            */


            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Coletar Nectar", "Produzir Mel" }, 140);
            workers[1] = new Worker(new string[] { "Cuidar do Ovos", "Cuidar dos Filhotes" }, 114);
            workers[2] = new Worker(new string[] { "Manter a Colmeia", "Patrulhar a Colmeia" }, 149);
            workers[3] = new Worker(new string[] { "Coletar Nectar", "Produzir Mel", "Cuidar do Ovos",
                                                   "Cuidar dos Filhotes", "Manter a Colmeia", "Patrulhar a Colmeia" }, 155);

            queen = new Queen(workers);
        }        

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workeerBeeJob.Text, (int)numShifts.Value) == false)
                MessageBox.Show("Nenhuma operária está disponível para fazer este trabalho '" + workeerBeeJob.Text + "', A Rainha diz...");
            else
                MessageBox.Show("O trabalho '" + workeerBeeJob.Text + "' será feito em " + numShifts.Value + " turnos", "A Rainha diz...");
        }

        private void btnNextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
