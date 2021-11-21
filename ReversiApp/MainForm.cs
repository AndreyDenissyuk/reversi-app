using ReversiApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReversiApp
{
    public partial class MainForm : Form
    {
        private Game Game;

        private static readonly Image WhiteDiskImage = Resources.DiskWhite_small;
        private static readonly Image BlackDiskImage = Resources.DiskBlack_small;

        public MainForm()
        {
            InitializeComponent();
            Game = new Game(this);
            Game.Init();
        }

        public void SetCurrentPlayer(bool isWhite)
        {
            pictureCurrentPlayer.Image = isWhite ? WhiteDiskImage : BlackDiskImage;
        }

        public void UpdateScore(int whiteScore, int blackScore)
        {
            LabelWhiteScore.Text = whiteScore.ToString();
            LabelBlackScore.Text = blackScore.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Game.Restart();
        }
    }
}
