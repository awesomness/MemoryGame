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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.HidePlayer2(); // Default är att gömma alla players förutom player 1.
            this.HidePlayer3();
            this.HidePlayer4();
            this.HidePlayer5();

            if (labelPlayer1.Visible == true)
            {
                buttonRemovePlayer.Visible = false;
            }

            int a = 2;
            for (int i = 0; i < 60; i++ )
            {
                comboBoxBoard.Items.Add(a.ToString());
                a += 2;
            }

            comboBoxBoard.SelectedIndex = 5;

            comboBoxDifficulty.Items.Add("Easy");
            comboBoxDifficulty.Items.Add("Medium");
            comboBoxDifficulty.Items.Add("Hard");
            comboBoxDifficulty.SelectedIndex = 0;

            comboBoxRoundTime.Items.Add("10");
            comboBoxRoundTime.Items.Add("20");
            comboBoxRoundTime.Items.Add("30");
            comboBoxRoundTime.SelectedIndex = 1;

            comboBoxTheme.Items.Add("Cars");
            comboBoxTheme.Items.Add("Cats");
            comboBoxTheme.Items.Add("Dogs");
            comboBoxTheme.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = new Form2(textBoxPlayer1.Text, textBoxPlayer2.Text, textBoxPlayer3.Text, textBoxPlayer4.Text, textBoxPlayer5.Text,  // Information som ska fraktas till Form2.
                             comboBoxRoundTime.Text, comboBoxDifficulty.Text, comboBoxTheme.Text, comboBoxBoard.Text, checkBoxPlayer2.Checked,
                             checkBoxPlayer3.Checked, checkBoxPlayer4.Checked, checkBoxPlayer5.Checked);   
            this.Hide();
            a.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HidePlayer2()  // Göm player 2.
        {
            labelPlayer2.Hide();    // Göm label
            textBoxPlayer2.Hide();   // Göm textBox
            checkBoxPlayer2.Hide();   // Göm checkbox
        }
        private void HidePlayer3()  // Göm player 3.
        {
            labelPlayer3.Hide();
            textBoxPlayer3.Hide();
            checkBoxPlayer3.Hide();
        }
        private void HidePlayer4()  // Göm player 4
        {
            labelPlayer4.Hide();
            textBoxPlayer4.Hide();
            checkBoxPlayer4.Hide();
        }
        private void HidePlayer5()  // Göm player 5
        {
            labelPlayer5.Hide();
            textBoxPlayer5.Hide();
            checkBoxPlayer5.Hide();
        }

        private void ShowPlayer2()  // Visa player 2.
        {
            labelPlayer2.Show();    // Visa label.
            textBoxPlayer2.Show();  // Visa textbox.
            checkBoxPlayer2.Show(); // Visa checkbox.
        }

        private void ShowPlayer3()  // Visa player 3.
        {
            labelPlayer3.Show();
            textBoxPlayer3.Show();
            checkBoxPlayer3.Show();
        }

        private void ShowPlayer4()  // Visa player 4.
        {
            labelPlayer4.Show();
            textBoxPlayer4.Show();
            checkBoxPlayer4.Show();
        }

        private void ShowPlayer5()  // Visa player 5.
        {
            labelPlayer5.Show();
            textBoxPlayer5.Show();
            checkBoxPlayer5.Show();
        }

        private void buttonAddPlayer_Click_1(object sender, EventArgs e)  // Knapp för att lägga till spelare.
        {
            if (labelPlayer2.Visible == false)   // Om spelare 2 är osynlig...
            {
                this.ShowPlayer2();     // ... visa då player 2.
            }
            else if (labelPlayer3.Visible == false) // Om labelplayer3 inte finns på formen...
            {
                this.ShowPlayer3(); // ... visa den.
            }
            else if (labelPlayer4.Visible == false)     // osv.
            {
                this.ShowPlayer4();
            }
            else if (labelPlayer5.Visible == false)
            {
                this.ShowPlayer5();
            }

            if (labelPlayer2.Visible == true)   // Remove knappen ska bara synas om player2 syns.
            {
                buttonRemovePlayer.Visible = true;
            }
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            if (labelPlayer5.Visible == true)
            {
                this.HidePlayer5();
            }
            else if (labelPlayer4.Visible == true)
            {
                this.HidePlayer4();
            }
            else if (labelPlayer3.Visible == true)
            {
                this.HidePlayer3();
            }
            else if (labelPlayer2.Visible == true)
            {
                this.HidePlayer2();
            }

            if (labelPlayer2.Visible == false)
            {
                buttonRemovePlayer.Visible = false;
            }
        }
    }
}
