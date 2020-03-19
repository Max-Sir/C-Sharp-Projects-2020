using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runnable_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rd=new Random();
            button1.Location=new Point(
                (rd.Next(0,this.Width-50)),(rd.Next(0, this.Height - 50)));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e. == MouseButtons.Right)
            {
                textBox1.Text = "бла-бла-бла!!!";
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            e
        }
    }
}
