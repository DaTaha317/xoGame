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
        }
    }
}
