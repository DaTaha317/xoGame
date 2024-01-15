
namespace xo.Forms
{
    public partial class SinglePlayerForm : Form
    {
        private MainForm parentForm;
        public SinglePlayerForm(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btn_start_single_game_Click(object sender, EventArgs e)
        {
            parentForm.openChildForm(new GameBoard());
        }
    }
}
