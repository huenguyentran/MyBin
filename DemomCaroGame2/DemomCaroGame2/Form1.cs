namespace DemomCaroGame2
{
    public partial class picAvata : Form
    {
        public picAvata()
        {
            InitializeComponent();

            drawChessBoard();
        }

        void drawChessBoard()
        {
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                    };
                    pnlBoardGame.Controls.Add(btn);
                    oldBtn = btn;
                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Cons.CHESS_HEIGHT);
                oldBtn.Width = 0;
                oldBtn.Height = 0;

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
