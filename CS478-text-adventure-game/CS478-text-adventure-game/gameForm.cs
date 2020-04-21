using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS478_text_adventure_game
{
    public partial class gameForm : Form
    {
        int tick = 36000;
        public gameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick--;
            label1.Text = tick / 60 + ":" + ((tick % 60) >= 10 ? (tick % 60).ToString() : "0" + (tick % 60));
        }

    }
}
