using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db db1 = new db();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db1.Humans.ToList();

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            db db1=new db();
          human h=new human() { name=textBox1.Text,family=textBox2.Text,age=Convert.ToByte(textBox3.Text)};
        db1.Humans.Add(h);
           
          
            db1.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db1.Humans.ToList();

        }
    }
}
