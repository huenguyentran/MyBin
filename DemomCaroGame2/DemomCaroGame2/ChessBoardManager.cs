using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemomCaroGame2
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel ChessBoard;

        private List<Player> player;

        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }


        private int currentPlayer;
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        private TextBox playerName;
        public TextBox PlayerName { get => playerName; set => playerName = value; }

        private PictureBox playerMark;
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }

        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            this.ChessBoard = chessBoard;   
            this.playerName = playerName; 
            this.playerMark = mark;


            this.Player = new List<Player>() 
            {
                new Player("Player1", Image.FromFile(Application.StartupPath +  "\\image\\circle.png")),
                new Player("Player2", Image.FromFile(Application.StartupPath +  "\\image\\X.png"))
            };

            CurrentPlayer = 0;

            ChangePlayer();
        }

        #endregion

        #region Methods
        public void drawChessBoard()
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
                        BackgroundImageLayout = ImageLayout.Stretch,
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);
                    oldBtn = btn;
                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Cons.CHESS_HEIGHT);
                oldBtn.Width = 0;
                oldBtn.Height = 0;

            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // ep kieu sang button

            if (btn.BackgroundImage != null) return;

            mark(btn);

            ChangePlayer();

        }

        private void mark(Button btn)
        {

            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            currentPlayer = currentPlayer == 1 ? 0 : 1;


        }

        private void ChangePlayer()
        {
            playerName.Text = player[currentPlayer].Name;
            PlayerMark.Image = player[currentPlayer].Mark;

        }
        #endregion

    }
}
