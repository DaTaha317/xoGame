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
        public GameBoard()
        {
            InitializeComponent();
        }

        #region Game Code
        bool turn = true; // true = X turn , false = O turn 
        int turn_count = 0;

        private void checkForWinner()
        {
            bool gameOver = false;

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
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
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

        #endregion

    }
}
