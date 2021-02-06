using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Var_16 : Form
    {
        public Var_16()
        {
            InitializeComponent();
        }
        public double vvod(TextBox t)
        {
            return Convert.ToDouble(t.Text);
        }


        int[] mas = new int[15];
        string Print_L(int [] mas)
        {
            string y = " ";
            for(int i = 0; i < 15; i++)
            {
                y = y + Convert.ToString(mas[i]) + " ";
            }
            return y;
        }
        void vvod(int[] mas)
        {
            Random Random_Number1 = new Random();
                for(int i = 0; i < 15 ; ++i)
                    {
                        mas[i] = Random_Number1.Next(-10, 10);
                    }
        }
        void Find_Min_Max_mas(int[] mas, int minIndex = 0, int maxIndex = 0)
        {
            string w = " ";
            for (int i = 0; i < 15; i++)
            {
                if (mas[i] > mas[maxIndex]) maxIndex = i;
                if (mas[i] < mas[minIndex]) minIndex = i;
            }
            int mult = 1, i1 = minIndex < maxIndex ? minIndex : maxIndex;
            for (int i = 0; i < Math.Abs(maxIndex - minIndex) - 1; i++)
            {
                mult *= mas[i1 + 1 + i];
                w = w + Convert.ToString((mas[i1 + 1 + i])+ " ");
            }
            listBox2.Items.Add(mult);
            listBox3.Items.Add(w);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            mas = new int[15];
            vvod(mas);
            string y = Print_L(mas);
            listBox1.Items.Add(y);
            Find_Min_Max_mas(mas);
        }
    }
}
