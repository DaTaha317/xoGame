namespace xo.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnl_SideMenu = new Panel();
            btn_exit = new Button();
            btn_about = new Button();
            btn_scores = new Button();
            pnl_mode_options = new Panel();
            btn_multiPlayer = new Button();
            btn_singlePlayer = new Button();
            btn_mode = new Button();
            pnl_logo = new Panel();
            logo_sideMenu = new PictureBox();
            pnl_footer = new Panel();
            pnl_childForm = new Panel();
            lbl_welcome = new Label();
            logo_welcomeForm = new PictureBox();
            pnl_SideMenu.SuspendLayout();
            pnl_mode_options.SuspendLayout();
            pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_sideMenu).BeginInit();
            pnl_childForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_welcomeForm).BeginInit();
            SuspendLayout();
            // 
            // pnl_SideMenu
            // 
            pnl_SideMenu.BackColor = Color.FromArgb(10, 7, 17);
            pnl_SideMenu.Controls.Add(btn_exit);
            pnl_SideMenu.Controls.Add(btn_about);
            pnl_SideMenu.Controls.Add(btn_scores);
            pnl_SideMenu.Controls.Add(pnl_mode_options);
            pnl_SideMenu.Controls.Add(btn_mode);
            pnl_SideMenu.Controls.Add(pnl_logo);
            pnl_SideMenu.Dock = DockStyle.Left;
            pnl_SideMenu.Location = new Point(0, 0);
            pnl_SideMenu.Name = "pnl_SideMenu";
            pnl_SideMenu.Size = new Size(193, 553);
            pnl_SideMenu.TabIndex = 0;
            // 
            // btn_exit
            // 
            btn_exit.Dock = DockStyle.Top;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = SystemColors.Control;
            btn_exit.Location = new Point(0, 319);
            btn_exit.Name = "btn_exit";
            btn_exit.Padding = new Padding(5, 0, 0, 0);
            btn_exit.Size = new Size(193, 45);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.TextAlign = ContentAlignment.MiddleLeft;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_about
            // 
            btn_about.Dock = DockStyle.Top;
            btn_about.FlatAppearance.BorderSize = 0;
            btn_about.FlatStyle = FlatStyle.Flat;
            btn_about.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_about.ForeColor = SystemColors.Control;
            btn_about.Location = new Point(0, 274);
            btn_about.Name = "btn_about";
            btn_about.Padding = new Padding(5, 0, 0, 0);
            btn_about.Size = new Size(193, 45);
            btn_about.TabIndex = 4;
            btn_about.Text = "About";
            btn_about.TextAlign = ContentAlignment.MiddleLeft;
            btn_about.UseVisualStyleBackColor = true;
            btn_about.Click += btn_about_Click;
            // 
            // btn_scores
            // 
            btn_scores.Dock = DockStyle.Top;
            btn_scores.FlatAppearance.BorderSize = 0;
            btn_scores.FlatStyle = FlatStyle.Flat;
            btn_scores.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_scores.ForeColor = SystemColors.Control;
            btn_scores.Location = new Point(0, 229);
            btn_scores.Name = "btn_scores";
            btn_scores.Padding = new Padding(5, 0, 0, 0);
            btn_scores.Size = new Size(193, 45);
            btn_scores.TabIndex = 3;
            btn_scores.Text = "Scores";
            btn_scores.TextAlign = ContentAlignment.MiddleLeft;
            btn_scores.UseVisualStyleBackColor = true;
            btn_scores.Click += btn_scores_Click;
            // 
            // pnl_mode_options
            // 
            pnl_mode_options.BackColor = Color.FromArgb(35, 32, 39);
            pnl_mode_options.Controls.Add(btn_multiPlayer);
            pnl_mode_options.Controls.Add(btn_singlePlayer);
            pnl_mode_options.Dock = DockStyle.Top;
            pnl_mode_options.Location = new Point(0, 144);
            pnl_mode_options.Name = "pnl_mode_options";
            pnl_mode_options.Size = new Size(193, 85);
            pnl_mode_options.TabIndex = 2;
            // 
            // btn_multiPlayer
            // 
            btn_multiPlayer.Dock = DockStyle.Top;
            btn_multiPlayer.FlatAppearance.BorderSize = 0;
            btn_multiPlayer.FlatStyle = FlatStyle.Flat;
            btn_multiPlayer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_multiPlayer.ForeColor = SystemColors.ScrollBar;
            btn_multiPlayer.Location = new Point(0, 40);
            btn_multiPlayer.Name = "btn_multiPlayer";
            btn_multiPlayer.Padding = new Padding(30, 0, 0, 0);
            btn_multiPlayer.Size = new Size(193, 40);
            btn_multiPlayer.TabIndex = 1;
            btn_multiPlayer.Text = "Multiplayer";
            btn_multiPlayer.TextAlign = ContentAlignment.MiddleLeft;
            btn_multiPlayer.UseVisualStyleBackColor = true;
            btn_multiPlayer.Click += btn_multiPlayer_Click;
            // 
            // btn_singlePlayer
            // 
            btn_singlePlayer.Dock = DockStyle.Top;
            btn_singlePlayer.FlatAppearance.BorderSize = 0;
            btn_singlePlayer.FlatStyle = FlatStyle.Flat;
            btn_singlePlayer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_singlePlayer.ForeColor = SystemColors.ScrollBar;
            btn_singlePlayer.Location = new Point(0, 0);
            btn_singlePlayer.Name = "btn_singlePlayer";
            btn_singlePlayer.Padding = new Padding(30, 0, 0, 0);
            btn_singlePlayer.Size = new Size(193, 40);
            btn_singlePlayer.TabIndex = 0;
            btn_singlePlayer.Text = "Single Player";
            btn_singlePlayer.TextAlign = ContentAlignment.MiddleLeft;
            btn_singlePlayer.UseVisualStyleBackColor = true;
            btn_singlePlayer.Click += btn_singlePlayer_Click;
            // 
            // btn_mode
            // 
            btn_mode.Dock = DockStyle.Top;
            btn_mode.FlatAppearance.BorderSize = 0;
            btn_mode.FlatStyle = FlatStyle.Flat;
            btn_mode.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_mode.ForeColor = SystemColors.Control;
            btn_mode.Location = new Point(0, 99);
            btn_mode.Name = "btn_mode";
            btn_mode.Padding = new Padding(5, 0, 0, 0);
            btn_mode.Size = new Size(193, 45);
            btn_mode.TabIndex = 1;
            btn_mode.Text = "Play";
            btn_mode.TextAlign = ContentAlignment.MiddleLeft;
            btn_mode.UseVisualStyleBackColor = true;
            btn_mode.Click += btn_mode_Click;
            // 
            // pnl_logo
            // 
            pnl_logo.BackColor = Color.FromArgb(11, 7, 17);
            pnl_logo.Controls.Add(logo_sideMenu);
            pnl_logo.Dock = DockStyle.Top;
            pnl_logo.Location = new Point(0, 0);
            pnl_logo.Name = "pnl_logo";
            pnl_logo.Size = new Size(193, 99);
            pnl_logo.TabIndex = 0;
            // 
            // logo_sideMenu
            // 
            logo_sideMenu.Image = (Image)resources.GetObject("logo_sideMenu.Image");
            logo_sideMenu.Location = new Point(39, 14);
            logo_sideMenu.Name = "logo_sideMenu";
            logo_sideMenu.Size = new Size(117, 79);
            logo_sideMenu.SizeMode = PictureBoxSizeMode.Zoom;
            logo_sideMenu.TabIndex = 0;
            logo_sideMenu.TabStop = false;
            // 
            // pnl_footer
            // 
            pnl_footer.BackColor = Color.FromArgb(50, 19, 71);
            pnl_footer.Dock = DockStyle.Bottom;
            pnl_footer.Location = new Point(193, 489);
            pnl_footer.Name = "pnl_footer";
            pnl_footer.Size = new Size(739, 64);
            pnl_footer.TabIndex = 1;
            // 
            // pnl_childForm
            // 
            pnl_childForm.BackColor = Color.FromArgb(194, 174, 208);
            pnl_childForm.Controls.Add(lbl_welcome);
            pnl_childForm.Controls.Add(logo_welcomeForm);
            pnl_childForm.Dock = DockStyle.Fill;
            pnl_childForm.Location = new Point(193, 0);
            pnl_childForm.Name = "pnl_childForm";
            pnl_childForm.Size = new Size(739, 489);
            pnl_childForm.TabIndex = 2;
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(226, 378);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(260, 81);
            lbl_welcome.TabIndex = 1;
            lbl_welcome.Text = "XoGame";
            // 
            // logo_welcomeForm
            // 
            logo_welcomeForm.Image = (Image)resources.GetObject("logo_welcomeForm.Image");
            logo_welcomeForm.Location = new Point(167, 53);
            logo_welcomeForm.Name = "logo_welcomeForm";
            logo_welcomeForm.Size = new Size(373, 311);
            logo_welcomeForm.SizeMode = PictureBoxSizeMode.Zoom;
            logo_welcomeForm.TabIndex = 0;
            logo_welcomeForm.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(pnl_childForm);
            Controls.Add(pnl_footer);
            Controls.Add(pnl_SideMenu);
            MinimumSize = new Size(950, 600);
            Name = "MainForm";
            Text = "MainForm";
            pnl_SideMenu.ResumeLayout(false);
            pnl_mode_options.ResumeLayout(false);
            pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_sideMenu).EndInit();
            pnl_childForm.ResumeLayout(false);
            pnl_childForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_welcomeForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_SideMenu;
        private Panel pnl_logo;
        private Button btn_mode;
        private Panel pnl_mode_options;
        private Button btn_multiPlayer;
        private Button btn_singlePlayer;
        private Button btn_exit;
        private Button btn_about;
        private Button btn_scores;
        private PictureBox logo_sideMenu;
        private Panel pnl_footer;
        private Panel pnl_childForm;
        private PictureBox logo_welcomeForm;
        private Label lbl_welcome;
    }
}
