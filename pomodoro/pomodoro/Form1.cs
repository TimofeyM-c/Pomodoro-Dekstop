using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pomodoro
{
    
    public partial class Form1 : Form
    {
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Users\1\Desktop\sound.wav");
            simpleSound.Play();
        }
        int m = 0;
        int s = 0;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 1;
            s = s + 1; 
            if (s == 60) 
            {
                m += 1;
                s = 0;
            }
            if (i % 2 == 0)
            {
                if(m == 5)
                {
                    i = 1;
                    s = 0;
                    m = 0;
                    playSimpleSound();
                    MessageBox.Show("Hard Work");
                }
            }
            if(m == 15)
            {
                i++;
                m = 0;
                s = 0;
                playSimpleSound();
                MessageBox.Show("Chill");               
            }
            
            
            label1.Text = Convert.ToString(m);
            label2.Text = Convert.ToString(s);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
