using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xo.Core;

namespace xo.Forms
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
            getScores();
        }

        private void getScores()
        {
            dgv_score.DataSource = ScoreService.Select();
            dgv_score.Columns["GameId"].Visible = false;
        }

        int currentId = 0;
        private void RowHeaderDblClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgv_score.SelectedRows[0];
            currentId = (int)row.Cells["gameId"].Value;
        }

        private void DeleteBtnClick(object sender, EventArgs e)
        {
            ScoreService.Delete(currentId);
            getScores();
        }
    }
}
