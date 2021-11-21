using ReversiApp.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReversiApp
{
    class Game
    {
        class ReversiButton : Button
        {
            public int X;
            public int Y;
        }

        private MainForm form;
        private ReversiButton[,] buttons;

        private static readonly Image WhiteDiskImage = Resources.DiskWhite;
        private static readonly Image BlackDiskImage = Resources.DiskBlack;

        private static readonly Color ButtonColor = Color.FromArgb(225);

        public Board Board;
        public bool IsWhitePlayer;

        private bool IsGameFinished;

        public Game(MainForm form)
        {
            this.form = form;
            Board = new Board();
            buttons = new ReversiButton[Board.HEIGHT, Board.WIDTH];
            IsWhitePlayer = true;
            IsGameFinished = false;
        }

        public void Init()
        {
            Board.Init();
            InitButtons();
            form.SetCurrentPlayer(IsWhitePlayer);
            PrepareNextMove();
        }

        public void Restart()
        {
            Board = new Board();
            for (int y = 0; y < Board.HEIGHT; y++)
            {
                for (int x = 0; x < Board.WIDTH; x++)
                {
                    form.Controls.Remove(buttons[y, x]);
                }
            }

            buttons = new ReversiButton[Board.HEIGHT, Board.WIDTH];
            IsWhitePlayer = true;
            IsGameFinished = false;
            Init();
        }

        public void PrepareNextMove()
        {
            form.UpdateScore(Board.WhiteScore, Board.BlackScore);

            CheckGameFinished();
            if (IsGameFinished) return;

            bool[,] possibleMoves = Board.GetPossibleMoves(IsWhitePlayer);

            for (int y = 0; y < Board.HEIGHT; y++) 
            {
                for (int x = 0; x < Board.WIDTH; x++) 
                {
                    buttons[y, x].Enabled = possibleMoves[y, x];
                    if (Board.Disks[y, x].Equals(Disk.White)) 
                    {
                        buttons[y, x].BackgroundImage = WhiteDiskImage;
                    }
                    if (Board.Disks[y, x].Equals(Disk.Black)) 
                    {
                        buttons[y, x].BackgroundImage = BlackDiskImage;
                    }
                }
            }
        }

        private void CheckGameFinished()
        {
            if (!Board.CanMove(IsWhitePlayer))
            {
                // Change player if no possible moves
                IsWhitePlayer = !IsWhitePlayer;
                form.SetCurrentPlayer(IsWhitePlayer);
                if (!Board.CanMove(IsWhitePlayer))
                {
                    IsGameFinished = true;
                    GameResultForm resultForm = new GameResultForm(Board.WhiteScore, Board.BlackScore, Restart)
                    {
                        StartPosition = FormStartPosition.CenterParent,
                        FormBorderStyle = FormBorderStyle.FixedSingle
                    };
                    resultForm.ShowDialog();
                    return;
                }
            }
        }

        public void InitButtons()
        {
            int xPos = 30;
            int yPos = 30;
            int size = 50;

            for (int y = 0; y < Board.HEIGHT; y++)
            {
                for (int x = 0; x < Board.WIDTH; x++)
                {
                    buttons[y, x] = new ReversiButton
                    {
                        Width = size,
                        Height = size,
                        X = x,
                        Y = y,
                        TabStop = false,
                        BackColor = ButtonColor,
                        Top = yPos + y * size,
                        Left = xPos + x * size
                    };

                    buttons[y, x].Click += new EventHandler(OnButtonClick);

                    form.Controls.Add(buttons[y, x]);
                }
            }
        }

        private void OnButtonClick(Object sender, EventArgs e)
        {
            ReversiButton b = (ReversiButton)sender;
            b.Enabled = false;
            b.BackgroundImage = IsWhitePlayer ? WhiteDiskImage : BlackDiskImage;
            Board.Move(b.Y, b.X, IsWhitePlayer);
            IsWhitePlayer = !IsWhitePlayer;
            form.SetCurrentPlayer(IsWhitePlayer);
            PrepareNextMove();
        }
    }
}
