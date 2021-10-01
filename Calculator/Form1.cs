using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int first = Convert.ToInt32(textBox1.Text);
                int second = Convert.ToInt32(textBox2.Text);
                int res = first - second;
                textBox3.Text = res.ToString();

            }
            catch (NullReferenceException) {
                MessageBox.Show("Type digit");

            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                int first = Convert.ToInt32(textBox1.Text);
                int second = Convert.ToInt32(textBox2.Text);
                int res = first + second;
                textBox3.Text = res.ToString();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Type digit");

            }

        }

        private void mulktiply_Click(object sender, EventArgs e)
        {
            try
            {
                int first = Convert.ToInt32(textBox1.Text);
                int second = Convert.ToInt32(textBox2.Text);
                int res = first * second;
                textBox3.Text = res.ToString();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Type digit");

            }

        }

        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                int first = Convert.ToInt32(textBox1.Text);
                int second = Convert.ToInt32(textBox2.Text);
                int res = first / second;
                textBox3.Text = res.ToString();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Type digit");

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
