namespace MemoryGame_v1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelScore = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer3 = new System.Windows.Forms.Label();
            this.labelPlayer4 = new System.Windows.Forms.Label();
            this.labelPlayer5 = new System.Windows.Forms.Label();
            this.labelPlayersTurn = new System.Windows.Forms.Label();
            this.labelScorePlayer1 = new System.Windows.Forms.Label();
            this.labelScorePlayer2 = new System.Windows.Forms.Label();
            this.labelScorePlayer3 = new System.Windows.Forms.Label();
            this.labelScorePlayer4 = new System.Windows.Forms.Label();
            this.labelScorePlayer5 = new System.Windows.Forms.Label();
            this.labelTimeRemaining = new System.Windows.Forms.Label();
            this.labelTimeCounter = new System.Windows.Forms.Label();
            this.buttonTestaVinnare = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.catList1 = new System.Windows.Forms.ImageList(this.components);
            this.RoundTimer = new System.Windows.Forms.Timer(this.components);
            this.timerPairFound = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(468, 12);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(48, 24);
            this.labelScore.TabIndex = 9;
            this.labelScore.Text = "Score";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.ForeColor = System.Drawing.Color.White;
            this.labelPlayer1.Location = new System.Drawing.Point(412, 45);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(64, 24);
            this.labelPlayer1.TabIndex = 10;
            this.labelPlayer1.Text = "Player1";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.ForeColor = System.Drawing.Color.White;
            this.labelPlayer2.Location = new System.Drawing.Point(412, 69);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(64, 24);
            this.labelPlayer2.TabIndex = 11;
            this.labelPlayer2.Text = "Player2";
            // 
            // labelPlayer3
            // 
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer3.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer3.ForeColor = System.Drawing.Color.White;
            this.labelPlayer3.Location = new System.Drawing.Point(412, 93);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(64, 24);
            this.labelPlayer3.TabIndex = 12;
            this.labelPlayer3.Text = "Player3";
            // 
            // labelPlayer4
            // 
            this.labelPlayer4.AutoSize = true;
            this.labelPlayer4.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer4.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer4.ForeColor = System.Drawing.Color.White;
            this.labelPlayer4.Location = new System.Drawing.Point(412, 116);
            this.labelPlayer4.Name = "labelPlayer4";
            this.labelPlayer4.Size = new System.Drawing.Size(64, 24);
            this.labelPlayer4.TabIndex = 13;
            this.labelPlayer4.Text = "Player4";
            // 
            // labelPlayer5
            // 
            this.labelPlayer5.AutoSize = true;
            this.labelPlayer5.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer5.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer5.ForeColor = System.Drawing.Color.White;
            this.labelPlayer5.Location = new System.Drawing.Point(412, 140);
            this.labelPlayer5.Name = "labelPlayer5";
            this.labelPlayer5.Size = new System.Drawing.Size(64, 24);
            this.labelPlayer5.TabIndex = 14;
            this.labelPlayer5.Text = "Player5";
            // 
            // labelPlayersTurn
            // 
            this.labelPlayersTurn.AutoSize = true;
            this.labelPlayersTurn.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayersTurn.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayersTurn.ForeColor = System.Drawing.Color.White;
            this.labelPlayersTurn.Location = new System.Drawing.Point(412, 166);
            this.labelPlayersTurn.Name = "labelPlayersTurn";
            this.labelPlayersTurn.Size = new System.Drawing.Size(111, 24);
            this.labelPlayersTurn.TabIndex = 15;
            this.labelPlayersTurn.Text = "Player1\'s turn";
            // 
            // labelScorePlayer1
            // 
            this.labelScorePlayer1.AutoSize = true;
            this.labelScorePlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelScorePlayer1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorePlayer1.ForeColor = System.Drawing.Color.White;
            this.labelScorePlayer1.Location = new System.Drawing.Point(472, 45);
            this.labelScorePlayer1.Name = "labelScorePlayer1";
            this.labelScorePlayer1.Size = new System.Drawing.Size(20, 24);
            this.labelScorePlayer1.TabIndex = 23;
            this.labelScorePlayer1.Text = "0";
            // 
            // labelScorePlayer2
            // 
            this.labelScorePlayer2.AutoSize = true;
            this.labelScorePlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelScorePlayer2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorePlayer2.ForeColor = System.Drawing.Color.White;
            this.labelScorePlayer2.Location = new System.Drawing.Point(472, 69);
            this.labelScorePlayer2.Name = "labelScorePlayer2";
            this.labelScorePlayer2.Size = new System.Drawing.Size(20, 24);
            this.labelScorePlayer2.TabIndex = 24;
            this.labelScorePlayer2.Text = "0";
            // 
            // labelScorePlayer3
            // 
            this.labelScorePlayer3.AutoSize = true;
            this.labelScorePlayer3.BackColor = System.Drawing.Color.Transparent;
            this.labelScorePlayer3.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorePlayer3.ForeColor = System.Drawing.Color.White;
            this.labelScorePlayer3.Location = new System.Drawing.Point(472, 93);
            this.labelScorePlayer3.Name = "labelScorePlayer3";
            this.labelScorePlayer3.Size = new System.Drawing.Size(20, 24);
            this.labelScorePlayer3.TabIndex = 25;
            this.labelScorePlayer3.Text = "0";
            // 
            // labelScorePlayer4
            // 
            this.labelScorePlayer4.AutoSize = true;
            this.labelScorePlayer4.BackColor = System.Drawing.Color.Transparent;
            this.labelScorePlayer4.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorePlayer4.ForeColor = System.Drawing.Color.White;
            this.labelScorePlayer4.Location = new System.Drawing.Point(472, 116);
            this.labelScorePlayer4.Name = "labelScorePlayer4";
            this.labelScorePlayer4.Size = new System.Drawing.Size(20, 24);
            this.labelScorePlayer4.TabIndex = 26;
            this.labelScorePlayer4.Text = "0";
            // 
            // labelScorePlayer5
            // 
            this.labelScorePlayer5.AutoSize = true;
            this.labelScorePlayer5.BackColor = System.Drawing.Color.Transparent;
            this.labelScorePlayer5.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorePlayer5.ForeColor = System.Drawing.Color.White;
            this.labelScorePlayer5.Location = new System.Drawing.Point(472, 140);
            this.labelScorePlayer5.Name = "labelScorePlayer5";
            this.labelScorePlayer5.Size = new System.Drawing.Size(20, 24);
            this.labelScorePlayer5.TabIndex = 27;
            this.labelScorePlayer5.Text = "0";
            // 
            // labelTimeRemaining
            // 
            this.labelTimeRemaining.AutoSize = true;
            this.labelTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeRemaining.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeRemaining.ForeColor = System.Drawing.Color.White;
            this.labelTimeRemaining.Location = new System.Drawing.Point(412, 300);
            this.labelTimeRemaining.Name = "labelTimeRemaining";
            this.labelTimeRemaining.Size = new System.Drawing.Size(120, 24);
            this.labelTimeRemaining.TabIndex = 28;
            this.labelTimeRemaining.Text = "Time remaining";
            // 
            // labelTimeCounter
            // 
            this.labelTimeCounter.AutoSize = true;
            this.labelTimeCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeCounter.Font = new System.Drawing.Font("Segoe Print", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeCounter.ForeColor = System.Drawing.Color.White;
            this.labelTimeCounter.Location = new System.Drawing.Point(432, 332);
            this.labelTimeCounter.Name = "labelTimeCounter";
            this.labelTimeCounter.Size = new System.Drawing.Size(77, 61);
            this.labelTimeCounter.TabIndex = 29;
            this.labelTimeCounter.Text = "15";
            // 
            // buttonTestaVinnare
            // 
            this.buttonTestaVinnare.Location = new System.Drawing.Point(420, 400);
            this.buttonTestaVinnare.Name = "buttonTestaVinnare";
            this.buttonTestaVinnare.Size = new System.Drawing.Size(92, 23);
            this.buttonTestaVinnare.TabIndex = 30;
            this.buttonTestaVinnare.Text = "Testa Vinnare";
            this.buttonTestaVinnare.UseVisualStyleBackColor = true;
            this.buttonTestaVinnare.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::MemoryGame_v1.Properties.Resources.katterbakgrund;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.61538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.27473F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.05494F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.05494F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 460);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // catList1
            // 
            this.catList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("catList1.ImageStream")));
            this.catList1.TransparentColor = System.Drawing.Color.Transparent;
            this.catList1.Images.SetKeyName(0, "katt1.png");
            this.catList1.Images.SetKeyName(1, "katt2.png");
            this.catList1.Images.SetKeyName(2, "katt3.png");
            this.catList1.Images.SetKeyName(3, "katt4.png");
            this.catList1.Images.SetKeyName(4, "katt5.png");
            this.catList1.Images.SetKeyName(5, "katt6.png");
            this.catList1.Images.SetKeyName(6, "katt7.png");
            this.catList1.Images.SetKeyName(7, "katt8.png");
            this.catList1.Images.SetKeyName(8, "katt9.png");
            this.catList1.Images.SetKeyName(9, "katt10.png");
            this.catList1.Images.SetKeyName(10, "katt11.png");
            this.catList1.Images.SetKeyName(11, "katt12.png");
            this.catList1.Images.SetKeyName(12, "katt13.png");
            this.catList1.Images.SetKeyName(13, "katt14.png");
            this.catList1.Images.SetKeyName(14, "katt15.png");
            this.catList1.Images.SetKeyName(15, "katt16.png");
            this.catList1.Images.SetKeyName(16, "katt17.png");
            this.catList1.Images.SetKeyName(17, "katt18.png");
            this.catList1.Images.SetKeyName(18, "katt19.png");
            this.catList1.Images.SetKeyName(19, "katt20.png");
            this.catList1.Images.SetKeyName(20, "katt21.png");
            this.catList1.Images.SetKeyName(21, "katt22.png");
            this.catList1.Images.SetKeyName(22, "katt23.png");
            this.catList1.Images.SetKeyName(23, "katt24.png");
            this.catList1.Images.SetKeyName(24, "katt25.png");
            this.catList1.Images.SetKeyName(25, "katt26.png");
            this.catList1.Images.SetKeyName(26, "katt27.png");
            this.catList1.Images.SetKeyName(27, "katt28.png");
            this.catList1.Images.SetKeyName(28, "katt29.png");
            this.catList1.Images.SetKeyName(29, "katt30.png");
            this.catList1.Images.SetKeyName(30, "katt31.png");
            this.catList1.Images.SetKeyName(31, "katt32.png");
            this.catList1.Images.SetKeyName(32, "katt33.png");
            this.catList1.Images.SetKeyName(33, "katt34.png");
            this.catList1.Images.SetKeyName(34, "katt35.png");
            this.catList1.Images.SetKeyName(35, "katt36.png");
            this.catList1.Images.SetKeyName(36, "katt37.png");
            this.catList1.Images.SetKeyName(37, "katt38.png");
            this.catList1.Images.SetKeyName(38, "katt39.png");
            this.catList1.Images.SetKeyName(39, "katt40.png");
            this.catList1.Images.SetKeyName(40, "katt41.png");
            this.catList1.Images.SetKeyName(41, "katt42.png");
            this.catList1.Images.SetKeyName(42, "katt43.png");
            this.catList1.Images.SetKeyName(43, "katt44.png");
            this.catList1.Images.SetKeyName(44, "katt45.png");
            this.catList1.Images.SetKeyName(45, "katt46.png");
            this.catList1.Images.SetKeyName(46, "katt47.png");
            this.catList1.Images.SetKeyName(47, "katt48.png");
            this.catList1.Images.SetKeyName(48, "katt49.png");
            this.catList1.Images.SetKeyName(49, "katt50.png");
            this.catList1.Images.SetKeyName(50, "katt51.png");
            this.catList1.Images.SetKeyName(51, "katt52.png");
            this.catList1.Images.SetKeyName(52, "katt53.png");
            this.catList1.Images.SetKeyName(53, "katt54.png");
            this.catList1.Images.SetKeyName(54, "katt55.png");
            this.catList1.Images.SetKeyName(55, "katt56.png");
            this.catList1.Images.SetKeyName(56, "katt57.png");
            this.catList1.Images.SetKeyName(57, "katt58.png");
            this.catList1.Images.SetKeyName(58, "katt59.png");
            this.catList1.Images.SetKeyName(59, "katt60.png");
            // 
            // RoundTimer
            // 
            this.RoundTimer.Interval = 1000;
            this.RoundTimer.Tick += new System.EventHandler(this.RoundTimer_Tick);
            // 
            // timerPairFound
            // 
            this.timerPairFound.Interval = 750;
            this.timerPairFound.Tick += new System.EventHandler(this.timerPairFound_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(124, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(245, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(3, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 110);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(124, 116);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 110);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(245, 116);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(116, 110);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(3, 232);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(115, 109);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Location = new System.Drawing.Point(124, 232);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(115, 109);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Location = new System.Drawing.Point(245, 232);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(116, 109);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox10.Location = new System.Drawing.Point(3, 347);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(115, 110);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox11.Location = new System.Drawing.Point(124, 347);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(115, 110);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox12.Location = new System.Drawing.Point(245, 347);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(116, 110);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame_v1.Properties.Resources.bakgrundbla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonTestaVinnare);
            this.Controls.Add(this.labelTimeCounter);
            this.Controls.Add(this.labelTimeRemaining);
            this.Controls.Add(this.labelScorePlayer5);
            this.Controls.Add(this.labelScorePlayer4);
            this.Controls.Add(this.labelScorePlayer3);
            this.Controls.Add(this.labelScorePlayer2);
            this.Controls.Add(this.labelScorePlayer1);
            this.Controls.Add(this.labelPlayersTurn);
            this.Controls.Add(this.labelPlayer5);
            this.Controls.Add(this.labelPlayer4);
            this.Controls.Add(this.labelPlayer3);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer3;
        private System.Windows.Forms.Label labelPlayer4;
        private System.Windows.Forms.Label labelPlayer5;
        private System.Windows.Forms.Label labelPlayersTurn;
        private System.Windows.Forms.Label labelScorePlayer1;
        private System.Windows.Forms.Label labelScorePlayer2;
        private System.Windows.Forms.Label labelScorePlayer3;
        private System.Windows.Forms.Label labelScorePlayer4;
        private System.Windows.Forms.Label labelScorePlayer5;
        private System.Windows.Forms.Label labelTimeRemaining;
        private System.Windows.Forms.Label labelTimeCounter;
        private System.Windows.Forms.Button buttonTestaVinnare;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList catList1;
        private System.Windows.Forms.Timer RoundTimer;
        private System.Windows.Forms.Timer timerPairFound;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}