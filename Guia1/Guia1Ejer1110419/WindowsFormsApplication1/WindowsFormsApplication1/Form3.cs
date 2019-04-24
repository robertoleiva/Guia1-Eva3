using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            if(radioButton1.Checked==true)
            {
                total = total + 50;
            }
            if(radioButton2.Checked==true)
            {
                total = total + 100;
            }
            if(radioButton3.Checked==true)
            {
                total = total + 150;
            }
            if(checkBox1.Checked==true)
            {
                total = total + 5;
            }
            if(checkBox2.Checked==true)
            {
                total = total + 15;
            }
            if(checkBox3.Checked==true)
            {
                total = total + 20;
            }

            MessageBox.Show("El total de gastos es: " + total.ToString("c2"));
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
