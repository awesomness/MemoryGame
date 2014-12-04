namespace MemoryGame_v1
{
    partial class DialogBox
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
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelWinner = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(80, 336);
            this.buttonPlayAgain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(150, 56);
            this.buttonPlayAgain.TabIndex = 0;
            this.buttonPlayAgain.Text = "Play again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(272, 336);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(150, 56);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(464, 336);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(150, 56);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.BackColor = System.Drawing.Color.Transparent;
            this.labelWinner.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinner.ForeColor = System.Drawing.Color.White;
            this.labelWinner.Location = new System.Drawing.Point(288, 208);
            this.labelWinner.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(123, 37);
            this.labelWinner.TabIndex = 3;
            this.labelWinner.Text = "who won?";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(288, 272);
            this.labelScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(124, 37);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "the score?";
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame_v1.Properties.Resources.altwinner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 444);
            this.ControlBox = false;
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonPlayAgain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winner";
            this.Load += new System.EventHandler(this.DialogBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Label labelScore;
    }
}