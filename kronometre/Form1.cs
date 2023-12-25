using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }
        int sayac = 0;
        int dakika = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            sayac = sayac + 1;
            label1.Text = sayac.ToString();
            if (sayac == 60) 
            {
                dakika = dakika + 1;
                label2.Text = dakika.ToString();
                sayac = 0;
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            sayac = 0;
            dakika = 0;
            label2.Text = "0";
            label1.Text = "0";
        }
    }
}
