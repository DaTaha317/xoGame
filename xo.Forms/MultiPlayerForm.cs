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
            parentForm.openChildForm(new GameBoard(this));
        }
    }
}
