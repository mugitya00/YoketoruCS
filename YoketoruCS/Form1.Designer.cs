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
            buttonStart.Location = new Point(329, 269);
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
            labelTitle.Location = new Point(329, 119);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(95, 28);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "よけとるCS";
            // 
            // buttonTitle
            // 
            buttonTitle.Location = new Point(329, 287);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(95, 48);
            buttonTitle.TabIndex = 2;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(315, 133);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(121, 28);
            labelGameover.TabIndex = 3;
            labelGameover.Text = "GAME OVER";
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(345, 161);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(57, 28);
            labelClear.TabIndex = 4;
            labelClear.Text = "クリア";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}