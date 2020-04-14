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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            gameForm a = new gameForm();
            a.Show();
        }

        private void options_Click(object sender, EventArgs e)
        {
            optionsForm b = new optionsForm();
            b.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
