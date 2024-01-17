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
            if (txt_player1_name.Text != "" && txt_player2_name.Text != "")
                parentForm.openChildForm(new GameBoard(this));
            else
                MessageBox.Show("Please enter your names");

        }

        public string[] playerNames()
        {
            string[] names = new string[2];
            names[0] = txt_player1_name.Text;
            names[1] = txt_player2_name.Text;
            return names;
        }
    }
}
