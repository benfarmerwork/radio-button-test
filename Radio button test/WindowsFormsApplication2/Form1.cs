using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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
        string movies;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                movies = movies + checkBox1.Text + "\n";
            }
            if (checkBox2.Checked)
            {
                movies += checkBox2.Text + "\n";
            }
            if (checkBox3.Checked)
            {
                movies += checkBox3.Text + "\r\n";
            }
            if (checkBox4.Checked)
            {
                movies += checkBox4.Text + "\r\n";
            }
            if (checkBox5.Checked)
            {
                movies += checkBox5.Text + "\r\n";
            }
            MessageBox.Show(movies);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ChosenMovie = "";
            if (radioButton1.Checked)
            {
                ChosenMovie = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                ChosenMovie = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                ChosenMovie = radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                ChosenMovie = radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                ChosenMovie = radioButton5.Text;
            }
            MessageBox.Show("your chosen movie is " + ChosenMovie);
        }
    }
}
