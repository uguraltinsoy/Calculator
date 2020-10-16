using System;
using System.Collections;
using System.Globalization;
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
            this.Text = "hesap Makinesi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "CE";
            button2.Text = "0";
            button3.Text = "÷";
            button4.Text = "-";
            button5.Text = "7";
            button6.Text = "8";
            button7.Text = "9";
            button8.Text = "X";
            button9.Text = "4";
            button10.Text = "5";
            button11.Text = "6";
            button12.Text = "+";
            button13.Text = "1";
            button14.Text = "2";
            button15.Text = "3";
            button16.Text = "=";
            button17.Text = "x²";
            button18.Text = "√x";
            button19.Text = "📋";
            button20.Text = "•";
            button21.Text = "C";
            button22.Text = "⌫";
            button23.Text = "¹/x";
            button24.Text = "%";


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

        private void button20_Click(object sender, EventArgs e)
        {
            bool _bool = textBox1.Text.Trim().Contains(".");
            if (!_bool)
            {
                textBox1.Text = textBox1.Text.Trim() + ".";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text.Trim());
            double y = Math.Pow(x, 2);
            textBox1.Text = y.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text.Trim());
            textBox1.Text = Math.Sqrt(x).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text.Trim());
            textBox1.Text = (1 / x).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text.Trim());
            MessageBox.Show("Panoya Kopyalandı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            list.Clear();
            attack = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //Çıkartma
        private void button4_Click(object sender, EventArgs e)
        {
            attack = 3;
            if (!textBox1.Text.Equals(""))
            {
                list.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        //Çarpma
        private void button8_Click(object sender, EventArgs e)
        {
            attack = 2;
            if (!textBox1.Text.Equals(""))
            {
                list.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        //Bölme
        private void button3_Click(object sender, EventArgs e)
        {
            attack = 1;
            if (!textBox1.Text.Equals(""))
            {
                list.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        //Toplama
        private void button12_Click(object sender, EventArgs e)
        {
            attack = 4;
            if (!textBox1.Text.Equals(""))
            {
                list.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        //Eşittir
        private void button16_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double est;
            list.Add(textBox1.Text.Trim());

            try
            {
                switch (attack)
                {
                    case 1:
                        //Bölme
                        a = double.Parse((string)list[0], CultureInfo.InvariantCulture);
                        b = double.Parse((string)list[1], CultureInfo.InvariantCulture);
                        est = a / b;
                        list.Clear();
                        textBox1.Text = est.ToString();
                        break;
                    case 2:
                        //Çarpma
                        a = double.Parse((string)list[0], CultureInfo.InvariantCulture);
                        b = double.Parse((string)list[1], CultureInfo.InvariantCulture);
                        est = a * b;
                        list.Clear();
                        textBox1.Text = est.ToString();
                        break;
                    case 3:
                        //Cıkartma
                        a = double.Parse((string)list[0], CultureInfo.InvariantCulture);
                        b = double.Parse((string)list[1], CultureInfo.InvariantCulture);
                        est = a - b;
                        list.Clear();
                        textBox1.Text = est.ToString();
                        break;
                    case 4:
                        //Toplama
                        a = double.Parse((string)list[0], CultureInfo.InvariantCulture);
                        b = double.Parse((string)list[1], CultureInfo.InvariantCulture);
                        est = a + b;
                        list.Clear();
                        textBox1.Text = est.ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}