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
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBoardGame
            // 
            pnlBoardGame.Location = new Point(12, 0);
            pnlBoardGame.Name = "pnlBoardGame";
            pnlBoardGame.Size = new Size(586, 607);
            pnlBoardGame.TabIndex = 0;
            pnlBoardGame.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.caro;
            pictureBox1.Location = new Point(592, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(604, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            progressBar1.Location = new Point(604, 387);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(172, 29);
            progressBar1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Location = new Point(604, 437);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(604, 481);
            button1.Name = "button1";
            button1.Size = new Size(172, 52);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(626, 554);
            label1.Name = "label1";
            label1.Size = new Size(282, 45);
            label1.TabIndex = 6;
            label1.Text = "5 in 1 line to win";
            // 
            // picAvata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 608);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pnlBoardGame);
            Name = "picAvata";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBoardGame;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
    }
}
