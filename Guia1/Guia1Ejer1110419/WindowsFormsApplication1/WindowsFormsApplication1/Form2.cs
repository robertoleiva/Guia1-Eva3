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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, password;
            usuario = txtLogin.Text.TrimEnd();
            password = txtPassword.Text.TrimEnd();
            if ((usuario == "UTEC") && (password == "programacion1"))
            {
                MessageBox.Show("Bienvenidos al sistema");
            }
            else
            {
                MessageBox.Show("verificar usuario y password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
