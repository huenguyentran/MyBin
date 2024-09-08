namespace DemomCaroGame2
{
    partial class picAvata
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
            pnlBoardGame = new Panel();
            pictureBox1 = new PictureBox();
            playerName = new TextBox();
            progressBar1 = new ProgressBar();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            picMark = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMark).BeginInit();
            SuspendLayout();
            // 
            // pnlBoardGame
            // 
            pnlBoardGame.Location = new Point(15, 0);
            pnlBoardGame.Margin = new Padding(4);
            pnlBoardGame.Name = "pnlBoardGame";
            pnlBoardGame.Size = new Size(801, 697);
            pnlBoardGame.TabIndex = 0;
            pnlBoardGame.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.caro;
            pictureBox1.Location = new Point(816, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // playerName
            // 
            playerName.AcceptsReturn = true;
            playerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            playerName.Enabled = false;
            playerName.Location = new Point(816, 434);
            playerName.Margin = new Padding(4);
            playerName.Name = "playerName";
            playerName.Size = new Size(214, 31);
            playerName.TabIndex = 2;
            playerName.TextChanged += textBox1_TextChanged;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            progressBar1.Location = new Point(816, 487);
            progressBar1.Margin = new Padding(4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(215, 36);
            progressBar1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Location = new Point(816, 549);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 31);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(815, 588);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(215, 65);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(870, 657);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 54);
            label1.TabIndex = 6;
            label1.Text = "5 in 1 line to win";
            label1.Click += label1_Click;
            // 
            // picMark
            // 
            picMark.Image = Properties.Resources.circle;
            picMark.Location = new Point(1038, 434);
            picMark.Name = "picMark";
            picMark.Size = new Size(204, 204);
            picMark.SizeMode = PictureBoxSizeMode.StretchImage;
            picMark.TabIndex = 7;
            picMark.TabStop = false;
            // 
            // picAvata
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 710);
            Controls.Add(picMark);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(progressBar1);
            Controls.Add(playerName);
            Controls.Add(pictureBox1);
            Controls.Add(pnlBoardGame);
            Margin = new Padding(4);
            Name = "picAvata";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBoardGame;
        private PictureBox pictureBox1;
        private TextBox playerName;
        private ProgressBar progressBar1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private PictureBox picMark;
    }
}
