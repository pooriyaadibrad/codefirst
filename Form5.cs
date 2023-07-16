using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test5
{
    public partial class Form5 : Form
    {
        public Form5()
        { 
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
          

           
        }
        public List<int> Data=new List<int>();
        public List<string> oprator=new List<string>();
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //bool b = false;
            //foreach (var item in oprator)
            //{
            //    if (item == "-")
            //    {
            //        b = true;
            //    }
            //}
            //if (b == true)
            //{
            //    int a = Convert.ToInt32(textBox1.Text);
            //    a *= -1;
            //    oprator.Remove("-");
            //    oprator.Add("+");
            //    Data.Add(a);
            //}
            //else
            //{
            //    int a = Convert.ToInt32(textBox1.Text);
            //    Data.Add(a);
            //    oprator.Add("+");
            //    textBox1.Clear();
            //}
            int a = Convert.ToInt32(textBox1.Text);
            Data.Add(a);
            oprator.Add("+");
            textBox1.Clear();
            textBox1.Text = "+";
           

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //bool b=false;
            //foreach(var item in oprator)
            //{
            //    if(item=="-")
            //    {
            //        b=true;
            //    }
            //}
            //if (b == true)
            //{
            //    int a = Convert.ToInt32(textBox1.Text);
            //        a *= -1;
            //        oprator.Remove("-");
            //        oprator.Add("+");
            //        Data.Add(a);
            //}
            //else
            //{
            //    int a = Convert.ToInt32(textBox1.Text);
            //    Data.Add(a);
            //    oprator.Add("-");

            //}
            int a = Convert.ToInt32(textBox1.Text);
               Data.Add(a);
               oprator.Add("-");
            textBox1.Clear();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            Data.Add(a);
            oprator.Add("*");
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            Data.Add(a);
            oprator.Add("/");
            textBox1.Clear();
        }
        public int result = 0;
        private void button15_Click(object sender, EventArgs e)
        {
           
            int a = Convert.ToInt32(textBox1.Text);
            Data.Add(a);
            result = Data[0];
       
            int i = 0;
            foreach (var item in oprator)
            {
                
                   
                    if (item == "+")
                    {
                       
                        
                        result += Data[i + 1];
                 
                        
                        
                       i++;
                    }
                    else if (item == "-") 
                    {
                    result -= Data[i + 1];
                    i++;
                    }
                  
            }

   
            textBox1.Text=result.ToString();


        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            oprator.Clear();
            Data.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
