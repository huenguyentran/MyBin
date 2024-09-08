namespace DemomCaroGame2
{
    public partial class picAvata : Form
    {
        #region Prioperties
        ChessBoardManager ChessBoard;
        #endregion
        public picAvata()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlBoardGame, playerName, picMark);

            ChessBoard.drawChessBoard();

            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
