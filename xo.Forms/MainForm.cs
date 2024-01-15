namespace xo.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MenuVisiblity();
        }

        private void MenuVisiblity()
        {
            pnl_mode_options.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnl_mode_options.Visible) pnl_mode_options.Visible = false;
        }

        private void ShowSubMenu(Panel panel)
        {
            if (!pnl_mode_options.Visible)
            {
                HideSubMenu();
                pnl_mode_options.Visible = true;
            }
            else
            {
                pnl_mode_options.Visible = false;
            }
        }

        private void btn_mode_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_mode_options);
        }

        private void btn_singlePlayer_Click(object sender, EventArgs e)
        {
            // code 

            HideSubMenu();
        }

        private void btn_multiPlayer_Click(object sender, EventArgs e)
        {
            // code

            HideSubMenu();
        }
    }
}
