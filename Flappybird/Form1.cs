 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappybird
{
    public partial class Form1 : Form
    {
        int gamespeed = 10;
        int gravity = 8;
       public float score = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public void gametimer(object sender, EventArgs e)
        {
            flappybird.Top = flappybird.Top + gravity;
            pipeneechewala.Left = pipeneechewala.Left - gamespeed;
            pipeooperwala .Left = pipeooperwala.Left - gamespeed;

            if(pipeneechewala.Left < -2)
            {
                pipeneechewala.Left = 600;
                score= score + 0.5f;
                label1.Text = score.ToString();
            }
            if (pipeooperwala.Left < -2)
            {
                pipeooperwala.Left = 800;
                score = score + 0.5f;
                label1.Text = score.ToString();
            }
            if(flappybird.Bounds.IntersectsWith(ground.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeooperwala.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeneechewala  .Bounds))
            {
                timer1.Stop();
            
                label1.Text = score.ToString();
            }
            
        }

       

        private void gemkeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gemkeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void flappybird_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
