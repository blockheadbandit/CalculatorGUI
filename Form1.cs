using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Made by Reece K Steptoe 2021
namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        public int runtime;//this is to find the last 2 calculations
        public List<String> History = new List<string>();//stores a list of past calculations

        public void calculation()
        {
            
            label2.Text = "";
            string alltext = label1.Text;
            label2.Text = label1.Text + "=";
            if (alltext.Contains('*'))
            {
                try
                {
                    string[] calculation = alltext.Split('*');
                    float num1 = float.Parse(calculation[0]);
                    float num2 = float.Parse(calculation[1]);
                    float maincalc = num1 * num2;
                    label1.Text = maincalc.ToString();
                    label2.Text += label1.Text;
                    string histxt = label2.Text;
                    History.Add(histxt);
                    

                }
                catch { }//stops the program crashing when a user enters 2 operators or number is too long
            }
            if (alltext.Contains('+'))
            {
                try
                {
                    string[] calculation = alltext.Split('+');
                    float num1 = float.Parse(calculation[0]);
                    float num2 = float.Parse(calculation[1]);
                    float maincalc = num1 + num2;
                    label1.Text = maincalc.ToString();
                    label2.Text += label1.Text;
                    string histxt = label2.Text;
                    History.Add(histxt);

                }
                catch { }//stops the program crashing when a user enters 2 operators or number is too long
            }
            if (alltext.Contains('-'))
            {
                try
                {
                    string[] calculation = alltext.Split('-');
                    float num1 = float.Parse(calculation[0]);
                    float num2 = float.Parse(calculation[1]);
                    float maincalc = num1 - num2;
                    label1.Text = maincalc.ToString();
                    label2.Text += label1.Text;
                    string histxt = label2.Text;
                    History.Add(histxt);

                }
                catch { }//stops the program crashing when a user enters 2 operators or number is too long
            }
            if (alltext.Contains('/'))
            {
                try
                {
                    string[] calculation = alltext.Split('/');
                    float num1 = float.Parse(calculation[0]);
                    float num2 = float.Parse(calculation[1]);
                    float maincalc = num1 / num2;
                    label1.Text = maincalc.ToString();
                    label2.Text += label1.Text;
                    string histxt = label2.Text;
                    History.Add(histxt);

                }
                catch { }//stops the program crashing when a user enters 2 operators or number is too long
            }
            runtime++;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string textres = label1.Text;
            try
            {
                textres = textres.Substring(0, textres.Length - 1);
                label1.Text = textres;
            }
            catch(Exception){}//stops the program crashing when a user tries to delete empty spaces
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Deleted button
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //Deleted button
        }

        private void button20_Click(object sender, EventArgs e)
        {

            calculation();  
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Unused section
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Calculator screen
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            label1.Text += "/";
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
        }

        private void button21_Click(object sender, EventArgs e)
        {
        }

        private void button19_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click_3(object sender, EventArgs e)
        {
            string past = "";
            for (int i = 0; i < History.Count; i++)
            {
                past += History[i] + Environment.NewLine;
            }
            MessageBox.Show("History:" + Environment.NewLine +past);


        }
    }
}
