using System;
using System.Windows.Forms;

namespace ReversiApp
{
    public partial class GameResultForm : Form
    {
        private readonly int WhiteScore;
        private readonly int BlackScore;
        private readonly Action Restart;

        public GameResultForm(int whiteScore, int blackScore, Action restart)
        {
            WhiteScore = whiteScore;
            BlackScore = blackScore;
            Restart = restart;

            InitializeComponent();
            SetLabels();
        }

        private void SetLabels() {
            LabelWhite.Text = WhiteScore.ToString();
            LabelBlack.Text = BlackScore.ToString();

            String result =
                WhiteScore > BlackScore ? "White won" :
                BlackScore > WhiteScore ? "Black won" :
                "Draw";
            LabelResult.Text = result;
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            Restart();
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
