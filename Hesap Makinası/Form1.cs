using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinası
{
    public partial class Form1 : Form
    {
        ArrayList list = new ArrayList();
        int attack;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Uğur Altınsoy";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "CE";
            button2.Text = "0";
            button3.Text = "/";
            button4.Text = "-";
            button5.Text = "7";
            button6.Text = "8";
            button7.Text = "9";
            button8.Text = "*";
            button9.Text = "4";
            button10.Text = "5";
            button11.Text = "6";
            button12.Text = "+";
            button13.Text = "1";
            button14.Text = "2";
            button15.Text = "3";
            button16.Text = "=";
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim() + 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            list.Clear();
        }

        //Çıkartma
        private void button4_Click(object sender, EventArgs e)
        {
            attack = 3;
            list.Add(textBox1.Text);
            textBox1.Text = "";
        }

        //Çarpma
        private void button8_Click(object sender, EventArgs e)
        {
            attack = 2;
            list.Add(textBox1.Text);
            textBox1.Text = "";
        }

        //Bölme
        private void button3_Click(object sender, EventArgs e)
        {
            attack = 1;
            list.Add(textBox1.Text);
            textBox1.Text = "";
        }

        //Toplama
        private void button12_Click(object sender, EventArgs e)
        {
            attack = 4;
            list.Add(textBox1.Text);
            textBox1.Text = "";
        }

        //Eşittir
        private void button16_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double est;
            list.Add(textBox1.Text.Trim());

            switch (attack)
            {
                case 1:
                    //Bölme
                    a = double.Parse((string)list[0]);
                    b = double.Parse((string)list[1]);
                    est =  a / b;
                    list.Clear();
                    textBox1.Text = est.ToString();
                    break;
                case 2:
                    //Çarpma
                    a = double.Parse((string)list[0]);
                    b = double.Parse((string)list[1]);
                    est = a * b;
                    list.Clear();
                    textBox1.Text = est.ToString();
                    break;
                case 3:
                    //Cıkartma
                    a = double.Parse((string)list[0]);
                    b = double.Parse((string)list[1]);
                    est = a - b;
                    list.Clear();
                    textBox1.Text = est.ToString();
                    break;
                case 4:
                    //Toplama
                    a = double.Parse((string)list[0]);
                    b = double.Parse((string)list[1]);
                    est = a + b;
                    list.Clear();
                    textBox1.Text = est.ToString();

                    break;
                default:
                    break;
            }
        }
    }
}