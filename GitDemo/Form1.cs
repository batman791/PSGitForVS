using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I was clicked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Feature 1.1");
            //a change
            //change for feature1.11

            //local changes

            //some more local changes

            //more changes

        }
    }
}
