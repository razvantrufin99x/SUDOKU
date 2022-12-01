using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SUDOKU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int NR = 0;

        public void setValue(buttonsudoku n)
        {
            button1.Text = n.Name.ToString();
           
                n.setText(NR);
           
           
        }

        

        private void button82_Click(object sender, EventArgs e)
        {
            NR = 1;
            button91.Text = NR.ToString();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            NR = 2;
            button91.Text = NR.ToString();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            NR = 3;
            button91.Text = NR.ToString();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            NR = 4;
            button91.Text = NR.ToString();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            NR = 5;
            button91.Text = NR.ToString();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            NR = 6;
            button91.Text = NR.ToString();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            NR = 7;
            button91.Text = NR.ToString();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            NR = 8;
            button91.Text = NR.ToString();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            NR = 9;
            button91.Text = NR.ToString();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NR = 0;
            button91.Text = NR.ToString();
        }
    }
}
