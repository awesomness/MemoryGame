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
        public DialogBox(string score, string playerName)   // Här skapas nya variabler i dialogboxens konstruktor.
        {   // Detta för att ta emot spelarens score och namn för att de ska kunna placeras i dialogrutan.
            InitializeComponent();
            labelScore.Text = score;
            labelWinner.Text = playerName;
        }

        private void DialogBox_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
           // var a = new Form1();
            Application.Restart();
           // a.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
