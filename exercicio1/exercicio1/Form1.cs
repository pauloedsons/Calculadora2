using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maria = 30, joao = 12, paulo = 33;

            int idade = 3 / maria + joao + paulo;

            MessageBox.Show("Idade - média calculada: " +idade );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a= 4,  b= 24, c= 43;
            double delta =0 , a1, a2;

            delta = b * b - 4 * a * c;

            double raiz = Math.Sqrt(delta);

            a1 = (-b + raiz) / (2 * a);
            a2 = (-b - raiz) / (2 * a);



            MessageBox.Show(" Resultado:  " + a1 + " " + a2);





        }

        private void button3_Click(object sender, EventArgs e)
        {


            double valorInvestido = 1000.0;
            for (int i = 1; i <= 12; i += 1) {

                valorInvestido = valorInvestido * 1.01;
            }

            MessageBox.Show("Valor investido agora é " + valorInvestido);




        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 99; i++) {
               
            }
            MessageBox.Show("O total é: " + i);
        }
    }
}
