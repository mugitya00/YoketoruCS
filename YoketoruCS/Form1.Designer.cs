namespace YoketoruCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonStart = new Button();
            labelTitle = new Label();
            buttonTitle = new Button();
            labelGameover = new Label();
            labelClear = new Label();
            labelScore = new Label();
            highScore = new Label();
            labelTimer = new Label();
            tempPlayer = new Label();
            labelCopyright = new Label();
            tempObstacle = new Label();
            tempItem = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(403, 376);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(95, 48);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "スタート!!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(403, 165);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(95, 28);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "よけとるCS";
            labelTitle.Click += labelTitle_Click;
            // 
            // buttonTitle
            // 
            buttonTitle.Location = new Point(404, 359);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(95, 48);
            buttonTitle.TabIndex = 2;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += buttonTitle_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(390, 230);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(121, 28);
            labelGameover.TabIndex = 3;
            labelGameover.Text = "GAME OVER";
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(432, 245);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(57, 28);
            labelClear.TabIndex = 4;
            labelClear.Text = "クリア";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(403, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(92, 37);
            labelScore.TabIndex = 5;
            labelScore.Text = "00000";
            // 
            // highScore
            // 
            highScore.AutoSize = true;
            highScore.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            highScore.Location = new Point(374, 57);
            highScore.Name = "highScore";
            highScore.Size = new Size(162, 25);
            highScore.TabIndex = 6;
            highScore.Text = "HighScore：00000";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Yu Gothic UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(826, 509);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(89, 54);
            labelTimer.TabIndex = 7;
            labelTimer.Text = "000";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tempPlayer.Location = new Point(238, 230);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(67, 28);
            tempPlayer.TabIndex = 8;
            tempPlayer.Text = "(^O^)";
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new Point(404, 548);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(94, 15);
            labelCopyright.TabIndex = 9;
            labelCopyright.Text = "(C)2023岸野悠真";
            // 
            // tempObstacle
            // 
            tempObstacle.AutoSize = true;
            tempObstacle.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tempObstacle.Location = new Point(122, 320);
            tempObstacle.Name = "tempObstacle";
            tempObstacle.Size = new Size(39, 30);
            tempObstacle.TabIndex = 10;
            tempObstacle.Text = "🔹";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tempItem.Location = new Point(44, 376);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(35, 30);
            tempItem.TabIndex = 11;
            tempItem.Text = "★";
            tempItem.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 572);
            Controls.Add(tempItem);
            Controls.Add(tempObstacle);
            Controls.Add(labelCopyright);
            Controls.Add(tempPlayer);
            Controls.Add(labelTimer);
            Controls.Add(highScore);
            Controls.Add(labelScore);
            Controls.Add(labelClear);
            Controls.Add(labelGameover);
            Controls.Add(buttonTitle);
            Controls.Add(labelTitle);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button buttonStart;
        private Label labelTitle;
        private Button buttonTitle;
        private Label labelGameover;
        private Label labelClear;
        private Label labelScore;
        private Label highScore;
        private Label labelTimer;
        private Label tempPlayer;
        private Label labelCopyright;
        private Label tempObstacle;
        private Label tempItem;
    }
}