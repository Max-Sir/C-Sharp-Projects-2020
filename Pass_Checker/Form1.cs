using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool fl=true;
        private void Form1_Load(object sender, EventArgs e)
        {
            if(fl)
            { MessageBox.Show(@"Instruction:
    -Enter Password then press Confirm Button
         then click on the red cross(Closing button)
    -The password is 1111
    -you can try to click on the close button before
         then you click on the confirm after the entering of the 
        Password");}
            fl = false;
            //Application.Restart();//лучше не юзать а то плодится и жрёт оперативку
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            //Thread.Sleep(1000);
            if (Psw == @"1111")
            {
                SystemSounds.Beep.Play();
                e.Cancel = false;
            }
            else
            {
                Form1 f=new Form1();
                f.Show();
                SystemSounds.Hand.Play();
            }
        }

        public static string Psw;
        public static int C=10;
        private void button1_Click(object sender, EventArgs e)
        {
            Psw = textBox1.Text;
            if (progressBar1.Value == 99)
            {
                C = -99;

            }
            else if(progressBar1.Value==0)
            {
                C = 99;
            }
            progressBar1.Value += C; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var textBox1PasswordChar = textBox1.PasswordChar;
            if (checkBox1.CheckState == CheckState.Checked/*checkBox1.Checked == true*/)
            {
                textBox1.PasswordChar = '✡';
              //  textBox1.Enabled;
            }
            else if(checkBox1.CheckState == CheckState.Indeterminate)
            {
                textBox1.PasswordChar = '卐';
                textBox1.PasswordChar = textBox1PasswordChar;
            }
        }
    }
}
