using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangtur
{
    public partial class Main : Form
    {
        private GameLogic gameLogic;
        private bool _active = false;
        private const int MaxFails = GameLogic.MaxFails;
        private Bitmap[] images = {
            Properties.Resources._0,
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
            Properties.Resources._6
        };

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void Reset()
        {
            InputForm inputForm = new InputForm(Properties.Resources.newGameTitle);
            DialogResult res = inputForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    gameLogic = new GameLogic(inputForm.Input);
                } catch (ArgumentException e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }

                Active = true;
                guide.Text = Properties.Resources.guidePressLetter;

                UpdateState(gameLogic);
            }
        }

        private void UpdateGuess(string currentGuess)
        {
            StringBuilder sb = new StringBuilder(currentGuess.Length * 2);
            foreach (var c in currentGuess)
            {
                sb.Append(c);
                sb.Append(' ');
            }
            guess.Text = sb.ToString();
        }

        private void UpdateLetters(List<char> ltrs)
        {
            StringBuilder sb = new StringBuilder(ltrs.Count * 2);
            foreach (var l in ltrs)
            {
                sb.Append(l);
                sb.Append(' ');
            }
            letters.Text = sb.ToString();
        }

        private void Key_press(object sender, KeyPressEventArgs e)
        {
            if (Active)
            {
                gameLogic.Guess(e.KeyChar);

                UpdateState(gameLogic);

                if (!gameLogic.CurrentGuess.Contains('_'))
                {
                    Won();
                }

                if (gameLogic.Fails >= MaxFails)
                {
                    Lost();
                }
            }
        }

        private void UpdateState(GameLogic gameLogic)
        {
            UpdateLetters(gameLogic.Letters);
            UpdateGuess(gameLogic.CurrentGuess);
            UpdateImage(gameLogic.Fails);
        }

        private void UpdateImage(int fails)
        {
            gameBoard.Image = images[fails];
        }

        private void Lost()
        {
            MessageBox.Show(Properties.Resources.lost);
            Active = false;
            guide.Text = Properties.Resources.guideNewGame;
        }

        private void Won()
        {
            MessageBox.Show(Properties.Resources.won);
            Active = false;
            guide.Text = Properties.Resources.guideNewGame;
        }

        private void MakeAttempt_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm(Properties.Resources.attemptTitle);
            DialogResult diagRes = inputForm.ShowDialog();
            if (diagRes == DialogResult.OK)
            {
                String attempt = inputForm.Input;

                bool res = gameLogic.Attempt(attempt);

                UpdateState(gameLogic);

                if (res)
                {
                    Won();
                }
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private bool Active
        {
            get { return _active; }
            set
            {
                _active = value;
                makeAttempt.Enabled = value;
            }
        }
    }
}
