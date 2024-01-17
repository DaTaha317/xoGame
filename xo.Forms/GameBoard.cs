using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public GameBoard(MultiPlayerForm multiPlayer)
        {
            InitializeComponent();
            this.multiPlayer = multiPlayer;
            singlePlayerMode = false;
            lbl_player1.Text = multiPlayer.playerNames()[0];
            lbl_player2.Text = multiPlayer.playerNames()[1];
        }

        #region Game Code
        bool turn = true; // true = X turn , false = O turn 
        int turn_count = 0;
        bool gameOver = false;

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
                if (turn) winner = "O";
                else winner = "X";

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
            foreach(Control c in t_pnl_board.Controls)
            {
                Button btn = c as Button;
                buttons.Add(btn);
            }
            return buttons;
        }

        #endregion

    }
}
