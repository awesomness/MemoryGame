using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame_v1
{
    public partial class DialogBox : Form
    {
        public DialogBox(string score, string playerName)
        {
            InitializeComponent();
            labelScore.Text = score + " POINTS!";
            labelWinner.Text = playerName + " WON!";
        }

        private void DialogBox_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
