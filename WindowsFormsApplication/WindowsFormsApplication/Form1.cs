using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            checkBox1.Hide();
            checkBox2.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Hide();
            checkBox1.Show();
        }
    }
}