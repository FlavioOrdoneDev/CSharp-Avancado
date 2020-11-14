using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop
{
    public partial class Form1 : Form
    {
        Queue<LumberJack> breakfastLine = new Queue<LumberJack>();        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddLumber_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNameLumber.Text))
            {
                MessageBox.Show("Por favor insira um nome.");
                return;
            }

            breakfastLine.Enqueue(new LumberJack(txtNameLumber.Text));
            txtNameLumber.Clear();
            RedrawList();
        }

        private void numericLumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFlapJacks_Click(object sender, EventArgs e)
        {
            FlapJack food;

            if (radioCrispy.Checked == true)
                food = FlapJack.Crispy;
            else if (radioSoggy.Checked == true)
                food = FlapJack.Soggy;
            else if (radioBrowned.Checked == true)
                food = FlapJack.Browned;
            else
                food = FlapJack.Banana;

            LumberJack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapJacks(food, (int)numericLumber.Value);

            RedrawList();
        }

        private void btnNextLumber_Click(object sender, EventArgs e)
        {
            LumberJack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapJacks();
            RedrawList();
        }

        private void RedrawList()
        {
            int qtdLumberJack = 1;
            listBoxCoffe.Items.Clear();
            foreach (var item in breakfastLine)
            {
                listBoxCoffe.Items.Add(qtdLumberJack + " " + item.Name);
                qtdLumberJack++;
            }

            LumberJack currentLumberjack = breakfastLine.Peek();

            txtFlapJacks.Text = currentLumberjack.Name + " tem " + currentLumberjack.FlapJackCount + " panquecas";
            
        }
    }
}
