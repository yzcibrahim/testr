using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("asdasdasdasd");
            MessageBox.Show("editted");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ibrahim" || true)
            {
                MessageBox.Show("welcome ibrahim, how are you today inşallah");
            }
            else
            {
                MessageBox.Show("who are you man????");

            }
            var integer = 3;
            var total = integer + 4;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
