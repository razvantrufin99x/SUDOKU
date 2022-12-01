using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SUDOKU
{
    public partial class buttonsudoku : UserControl
    {
        public buttonsudoku()
        {
            InitializeComponent();
        }
        public Form1 f;

        public void setText(int i)
        {
            if (i != 0)
            {
                button1.Text = i.ToString();
            }
            else
            {
                button1.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // f.Text = this.Name;
            f.setValue(this);
            
        }

        private void buttonsudoku_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }
        }
    }
}
