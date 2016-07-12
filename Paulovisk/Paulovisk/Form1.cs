using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paulovisk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valorInvestido = 0;
            for (int i = 0; i <= 99; i += 1) {
                valorInvestido = valorInvestido +1;
                

            }

            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void button2_Click(object sender, EventArgs e)
        {



            int i = 0;
            int resultado = 0;

            while (i < 99; i += 1){

                resultado += 3;

                MessageBox.Show("resultado" + resultado);
                i ++;
            }



        }
    }
}
