namespace xo.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MenuVisiblity();
        }

        #region Side Menu

        #region visbility methods
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

        #endregion

        #region events
        private void btn_mode_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_mode_options);
        }

        private void btn_singlePlayer_Click(object sender, EventArgs e)
        {
            openChildForm(new SinglePlayer());
            HideSubMenu();
        }

        private void btn_multiPlayer_Click(object sender, EventArgs e)
        {
            // code

            HideSubMenu();
        }

        private void btn_scores_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            // code 
            HideSubMenu();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #endregion

        #region Forms Navigation
        private Form activeForm = null;
        private void openChildForm(Form childFrom)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            pnl_childForm.Controls.Add(childFrom);
            pnl_childForm.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

#endregion

    }
}
