﻿using System;
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
    public partial class Form2 : Form
    {
        private bool player1Turn; // Alla spelares turn.
        private bool player2Turn;
        private bool player3Turn;
        private bool player4Turn;
        private bool player5Turn;

        private bool isPlayer1Computer { get; set; }
        private bool isPlayer2Computer { get; set; }
        private bool isPlayer3Computer { get; set; }
        private bool isPlayer4Computer { get; set; }
        private bool isPlayer5Computer { get; set; }

        List<Players> Players = new List<Players>();

        private string diff { get; set; }   // Medlemsvariabel för Difficulty.
        private string Theme { get; set; }  // Medlemsvariabel för Tema.
        private string Board { get; set; }  // Medlemsvariabel för Board.
        private bool IsCheckedP2 { get; set; }   // AI, eller inte för player 2.
        private bool IsCheckedP3 { get; set; }    // AI, eller inte för player 3.
        private bool IsCheckedP4 { get; set; }    // AI, eller inte för player 4
        private bool IsCheckedP5 { get; set; }    // AI, eller inte för player 5
        private string RoundTime { get; set; }    // Tiden som ska ticka ner.

        PictureBox firstClick = null;
        PictureBox secondClick = null;
        int bildTestat;

        Random rnd = new Random();

        int scorePlayer1 = 0;
        int timeLeft;
        

        PictureBox[] picBoxes = new PictureBox[12];

        Queue<int> uniqInts = new Queue<int>();

        public Form2(string player1Name, string player2Name, string player3Name, string player4Name, string player5Name,
                    string roundTime, string difficilty, string theme, string board, bool isCheckedP2, bool isCheckedP3,
                    bool isCheckedP4, bool isCheckedP5)
        {
            InitializeComponent();

            this.buttonTestaVinnare.Visible = false;

            if(player2Name == "")
            {
                labelScorePlayer2.Visible = false;
            }
            if (player3Name == "")
            {
                labelScorePlayer3.Visible = false;
            }
            if (player4Name == "")
            {
                labelScorePlayer4.Visible = false;
            }
            if (player5Name == "")
            {
                labelScorePlayer5.Visible = false;
            }
            //Variabler
            labelPlayer1.Text = player1Name;
            labelPlayer2.Text = player2Name;
            labelPlayer3.Text = player3Name;
            labelPlayer4.Text = player4Name;
            labelPlayer5.Text = player5Name;
            RoundTime = roundTime;
            labelTimeCounter.Text = roundTime;
            diff = difficilty;
            Theme = theme;
            Board = board;
            IsCheckedP2 = isCheckedP2;
            IsCheckedP3 = isCheckedP3;
            IsCheckedP4 = isCheckedP4;
            IsCheckedP5 = isCheckedP5;

            labelPlayersTurn.Text = labelPlayer1.Text + "'s turn!";

            //Timer
            timeLeft = Convert.ToInt32(RoundTime);
            labelTimeCounter.Text = RoundTime;
            RoundTimer.Start();        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            picBoxes[0] = pictureBox1;
            picBoxes[1] = pictureBox2;
            picBoxes[2] = pictureBox3;
            picBoxes[3] = pictureBox4;
            picBoxes[4] = pictureBox5;
            picBoxes[5] = pictureBox6;
            picBoxes[6] = pictureBox7;
            picBoxes[7] = pictureBox8;
            picBoxes[8] = pictureBox9;
            picBoxes[9] = pictureBox10;
            picBoxes[10] = pictureBox11;
            picBoxes[11] = pictureBox12;

            for (int i = 0; i < 12; i++)
            {
                picBoxes[i].Image = Properties.Resources.svitkortrygg;
            }

            AssignImagesToPictureBoxes();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            var a = new Form1();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var a = new DialogBox(labelScorePlayer1.Text, labelPlayer1.Text))
            {
                if (a.ShowDialog(this) == DialogResult.OK)
                {
                }
            }
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClick.Image = Properties.Resources.svitkortrygg;
            secondClick.Image = Properties.Resources.svitkortrygg;

            firstClick = null;
            secondClick = null;

            RoundTimer.Stop();
            MessageBox.Show("NEXT PLAYER GET READY!!!");
            timeLeft = Convert.ToInt32(RoundTime);
            labelTimeCounter.Text = RoundTime;
            RoundTimer.Start();    
        }

        private void AssignImagesToPictureBoxes()
        {
            //1. ERHÅLLA LISTA MED 8 UNIKA INTS
            //1.5 ITERERA 8 GÅNGER
            for (int i = 0; i<6; i++)
            {
                uniqInts.Enqueue(i + 1);
            }
            //anders tänker

            var countCards = Convert.ToInt32(Board);
            int rand;
            int counter = 0;

            for(int i=0; i< (Convert.ToInt32(Board) / 2); i++)
            {
                counter = 0;
                while(counter < 2)
                {
                    rand = rnd.Next(countCards);
                    if (picBoxes[rand].Tag == null)
                    {
                        picBoxes[rand].Tag = i;
                        counter++;
                    }
                }
            }

            for(int i=0; i<countCards; i++)
            {
                catList1.Images[i].Tag = i;
            }
        }

        private void RoundTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                labelTimeCounter.Text = timeLeft.ToString();
            }
            else
            {
                RoundTimer.Stop();
                MessageBox.Show("Time's up!\n NEXT PLAYER GET READY!!!");
                timeLeft = Convert.ToInt32(RoundTime);
                labelTimeCounter.Text = RoundTime;
                RoundTimer.Start();        
            }
        }

        // Funktion för att lägga till Scores till spelare.
        private void AddScorePlayers()
        {
            int scorePlayer1 = 0;
            int scorePlayer2 = 0;
            int scorePlayer3 = 0;
            int scorePlayer4 = 0;
            int scorePlayer5 = 0;

            if (player1Turn == true)
            {
                ++scorePlayer1;
                labelScorePlayer1.Text = scorePlayer1.ToString();
            }

            if (player2Turn == true)
            {
                ++scorePlayer2;
                labelScorePlayer2.Text = scorePlayer2.ToString();
            }

            if (player3Turn == true)
            {
                ++scorePlayer3;
                labelScorePlayer3.Text = scorePlayer3.ToString();
            }
            if (player4Turn == true)
            {
                ++scorePlayer4;
                labelScorePlayer4.Text = scorePlayer4.ToString();
            }
            if (player5Turn == true)
            {
                ++scorePlayer5;
                labelScorePlayer5.Text = scorePlayer5.ToString();
            }

        }

        private void timerPairFound_Tick(object sender, EventArgs e)
        {
            timerPairFound.Stop();

            firstClick.Image = null;
            secondClick.Image = null;
            firstClick.Visible = false;
            secondClick.Visible = false;
            firstClick = null;
            secondClick = null;
            this.scorePlayer1 = this.scorePlayer1 + 1;
            labelScorePlayer1.Text = scorePlayer1.ToString();

            RoundTimer.Stop();
            timeLeft = Convert.ToInt32(RoundTime);
            labelTimeCounter.Text = RoundTime;
            RoundTimer.Start();    

            if(this.scorePlayer1 == 6)
            {
                this.RoundTimer.Enabled = false;
                this.RoundTimer.Stop();
                using (var a = new DialogBox(labelScorePlayer1.Text, labelPlayer1.Text))
                {
                    if (a.ShowDialog(this) == DialogResult.OK) 
                    {
                    }
                }
                this.Hide();
            }
        }

        private void PlayerList()
        {
            Players.Add(new Players(labelScorePlayer1.Text, labelPlayer1.Text, isPlayer1Computer, player1Turn));
            Players.Add(new Players(labelScorePlayer2.Text, labelPlayer2.Text, isPlayer2Computer, player2Turn));
            Players.Add(new Players(labelScorePlayer3.Text, labelPlayer3.Text, isPlayer3Computer, player3Turn));
            Players.Add(new Players(labelScorePlayer4.Text, labelPlayer4.Text, isPlayer4Computer, player4Turn));
            Players.Add(new Players(labelScorePlayer5.Text, labelPlayer5.Text, isPlayer5Computer, player5Turn));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            PictureBox clickedPicture = sender as PictureBox;

            //ANDERS ANDERS ANDERS ANDERS
            //for(int i=0; i<Convert.ToInt32(Board); i++)
            //{
            //if (clickedPicture.Image == null)
            //    return;
            //}
            //if (clickedPicture.Image == catList1.Images[(int)clickedPicture.Tag])
            //        return;

            //if (this.catList contains ??????


            if (firstClick == null)
            {
                firstClick = clickedPicture;
                firstClick.Image = catList1.Images[(int)clickedPicture.Tag];
                firstClick.Tag = clickedPicture.Tag;
                return;
            }
            else if (secondClick == null)
            {
                secondClick = clickedPicture;
                secondClick.Image = catList1.Images[(int)clickedPicture.Tag];
                secondClick.Tag = clickedPicture.Tag;

                if (firstClick.Tag.Equals(secondClick.Tag))
                {
                    timerPairFound.Enabled = true;
                    return;
                }
                timer1.Enabled = true;
            }
        }
    }
}
