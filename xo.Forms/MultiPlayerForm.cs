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
    public partial class MultiPlayerForm : Form
    {
        private MainForm parentForm;
        public MultiPlayerForm(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btn_start_multi_game_Click(object sender, EventArgs e)
        {
            if (txt_player1_name.Text != "" && txt_player2_name.Text != "" && (rb_player1_x.Checked || rb_player1_o.Checked))
                parentForm.openChildForm(new GameBoard(this));
            else
                MessageBox.Show("Please enter your names & your X and O choice");

        }

        public string[] playerNames()
        {
            string[] names = new string[2];
            names[0] = txt_player1_name.Text;
            names[1] = txt_player2_name.Text;
            return names;
        }

        public bool getRadioChoice()
        {
            if (rb_player1_x.Checked) return true;
            else return false;
        }

        private void radioClickedX1(object sender, EventArgs e)
        {
            rb_player2_o.Checked = true;
        }

        private void radioClickO1(object sender, EventArgs e)
        {
            rb_player2_x.Checked = true;
        }

        private void radioClickX2(object sender, EventArgs e)
        {
            rb_player1_o.Checked = true;
        }

        private void radioClickO2(object sender, EventArgs e)
        {
            rb_player1_x.Checked = true;
        }
    }
}
