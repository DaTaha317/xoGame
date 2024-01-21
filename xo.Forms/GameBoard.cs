using xo.Core.Models;
using xo.Core;
using System.Diagnostics.Eventing.Reader;

namespace xo.Forms
{
    public partial class GameBoard : Form
    {
        private SinglePlayerForm singlePlayer;
        private MultiPlayerForm multiPlayer;
        private bool singlePlayerMode;

        public GameBoard(SinglePlayerForm singlePlayer)
        {
            InitializeComponent();
            this.singlePlayer = singlePlayer;
            singlePlayerMode = true;
            lbl_player1.Text = singlePlayer.playerName();
            adjustLabelPosition();
        }

        public GameBoard(MultiPlayerForm multiPlayer)
        {
            InitializeComponent();
            this.multiPlayer = multiPlayer;
            singlePlayerMode = false;

            if (multiPlayer.getRadioChoice())
            {
                lbl_player1.Text = multiPlayer.playerNames()[0];
                lbl_player2.Text = multiPlayer.playerNames()[1];
            }
            else
            {
                lbl_player1.Text = multiPlayer.playerNames()[1];
                lbl_player2.Text = multiPlayer.playerNames()[0];
            }

            
            adjustLabelPosition();
        }

        #region Game Code
        bool turn = true; // true = X turn , false = O turn 
        int turn_count = 0;
        bool gameOver = false;
        int playerOneScore = 0;
        int playerTwoScore = 0;

        private void checkForWinner()
        {

            // Horizontal Checks
            if ((btn_11.Text == btn_12.Text) && (btn_12.Text == btn_13.Text) && !btn_11.Enabled) gameOver = true;
            else if ((btn_21.Text == btn_22.Text) && (btn_22.Text == btn_23.Text) && !btn_21.Enabled) gameOver = true;
            else if ((btn_31.Text == btn_32.Text) && (btn_32.Text == btn_33.Text) && !btn_31.Enabled) gameOver = true;

            // Vertical Checks
            else if ((btn_11.Text == btn_21.Text) && (btn_21.Text == btn_31.Text) && !btn_11.Enabled) gameOver = true;
            else if ((btn_12.Text == btn_22.Text) && (btn_22.Text == btn_32.Text) && !btn_12.Enabled) gameOver = true;
            else if ((btn_13.Text == btn_23.Text) && (btn_23.Text == btn_33.Text) && !btn_13.Enabled) gameOver = true;

            // Horizontal Checks
            else if ((btn_11.Text == btn_22.Text) && (btn_22.Text == btn_33.Text) && !btn_11.Enabled) gameOver = true;
            else if ((btn_31.Text == btn_22.Text) && (btn_22.Text == btn_13.Text) && !btn_31.Enabled) gameOver = true;

            if (gameOver)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = lbl_player2.Text;
                    playerTwoScore++;
                    lbl_player2_score.Text = playerTwoScore.ToString();
                }

                else
                {
                    winner = lbl_player1.Text;
                    playerOneScore++;
                    lbl_player1_score.Text = playerOneScore.ToString();
                }

                MessageBox.Show($"The winner is {winner}!!");
            }
            else
            {
                if (turn_count == 9) MessageBox.Show("Draw");
            }
        }

        #endregion

        #region Events
        private void button_clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn) btn.Text = "X";
            else btn.Text = "O";
            turn = !turn;
            btn.Enabled = false;
            turn_count++;

            checkForWinner();

            // Game Mode
            if (singlePlayerMode) ComputerTimer.Start();

        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            ComputerTimer.Stop();
            gameOver = false;
            turn = true;
            turn_count = 0;

            foreach (Control c in t_pnl_board.Controls)
            {
                Button btn = c as Button;
                btn.Enabled = true;
                btn.Text = "";
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                if (turn) btn.Text = "X";
                else btn.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled) btn.Text = "";
        }

        private void ComputerTurn(object sender, EventArgs e)
        {
            List<Button> buttons = GetButtons();
            if (!gameOver)
            {
                int randomIndex = 0;
                do
                {
                    Random random = new Random();
                    randomIndex = random.Next(buttons.Count);

                }
                while (!buttons[randomIndex].Enabled);

                buttons[randomIndex].Text = "O";
                buttons[randomIndex].Enabled = false;
                turn_count++;
                turn = !turn;

                checkForWinner();
                ComputerTimer.Stop();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            playerOneScore = 0;
            lbl_player1_score.Text = playerOneScore.ToString();
            playerTwoScore = 0;
            lbl_player2_score.Text = playerTwoScore.ToString();

            btn_newGame_Click(sender, e);

        }

        private void btn_saveScores_Click(object sender, EventArgs e)
        {
            Game game = new Game()
            {
                PlayerOne = lbl_player1.Text,
                PlayerOneScore = int.Parse(lbl_player1_score.Text),
                PlayerTwo = lbl_player2.Text,
                PlayerTwoScore = int.Parse(lbl_player2_score.Text),
        };

            try
            {
                ScoreService.Insert(game);
                MessageBox.Show("Score has been saved");
                btn_reset_Click(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Helper Methods
        private void disableButtons()
        {
            foreach (Control c in t_pnl_board.Controls)
            {
                Button btn = c as Button;
                btn.Enabled = false;
            }
        }

        private List<Button> GetButtons()
        {
            List<Button> buttons = new List<Button>();
            foreach (Control c in t_pnl_board.Controls)
            {
                Button btn = c as Button;
                buttons.Add(btn);
            }
            return buttons;
        }

        private void adjustLabelPosition()
        {
            int centerP1 = lbl_player1.Left + (lbl_player1.Width - lbl_player1_score.Width) / 2;
            lbl_player1_score.Location = new Point(centerP1, lbl_player1.Bottom + 2);

            int centerP2 = lbl_player2.Left + (lbl_player2.Width - lbl_player2_score.Width) / 2;
            lbl_player2_score.Location = new Point(centerP2, lbl_player2.Bottom + 2);
        }

        #endregion

    }
}
