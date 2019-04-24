using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String usuario, password;
            usuario = textBox1.Text.TrimEnd();
            password = textBox2.Text.TrimEnd();

            if ((usuario == "UTEC") && (password == "programacion1"))
            {
                MessageBox.Show("Bienvenido al Sistema");
                Form2 ventana = new Form2();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifique usuario o password");
            }
   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
