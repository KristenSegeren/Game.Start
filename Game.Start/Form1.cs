using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Start
{
    public partial class YourMOM : Form
    {
        public YourMOM()
        {
            InitializeComponent();
            label3.Visible= false;
            label2.Visible= false;
            label1.Visible= false;
            LabelBG.Visible= false;
            GOlabel.Visible= false; 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            STARTbutton.Visible = false; //startButton
            Name1Label.Visible = false;  //nameLabel

            SoundPlayer _321sound = new SoundPlayer(Properties.Resources._321Sound);
            _321sound.Play();

            label3.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            label2.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            label1.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            _321sound.Stop();

            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;

            BackColor = Color.MediumAquamarine;
            GOlabel.Visible = true;

            SoundPlayer CatScream = new SoundPlayer(Properties.Resources.CatScream);
            CatScream.Play();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            STARTbutton.Visible = false; 
            Name1Label.Visible = false;
            label3.Visible = true;
            Refresh();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }       
    
}
