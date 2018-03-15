using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rich_text_box_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonlinks_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == null)
                richTextBox1.Text = richTextBox1.Text + textBoxlinks.Text;
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + textBoxlinks.Text;

            }
        }

        private void buttonrechts_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == null)
                richTextBox1.Text = richTextBox1.Text + textBoxlinks.Text;
            else
            {


            }
        }
    }
}
