
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
            if (txt_player_name.Text != "") parentForm.openChildForm(new GameBoard(this));
            else MessageBox.Show("Please enter your name");

        }

        public string playerName()
        {
            return txt_player_name.Text;
        }
    }
}
