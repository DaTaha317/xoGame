namespace xo.Forms
{
    partial class SinglePlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_start_single_game = new Button();
            gb_player = new GroupBox();
            txt_player_name = new TextBox();
            lbl_name = new Label();
            gb_player.SuspendLayout();
            SuspendLayout();
            // 
            // btn_start_single_game
            // 
            btn_start_single_game.Anchor = AnchorStyles.None;
            btn_start_single_game.BackColor = Color.FromArgb(50, 19, 71);
            btn_start_single_game.FlatAppearance.BorderSize = 0;
            btn_start_single_game.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 47, 148);
            btn_start_single_game.FlatStyle = FlatStyle.Flat;
            btn_start_single_game.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_start_single_game.ForeColor = SystemColors.Control;
            btn_start_single_game.Location = new Point(304, 393);
            btn_start_single_game.Name = "btn_start_single_game";
            btn_start_single_game.Size = new Size(287, 70);
            btn_start_single_game.TabIndex = 8;
            btn_start_single_game.Text = "Start Game";
            btn_start_single_game.UseVisualStyleBackColor = false;
            btn_start_single_game.Click += btn_start_single_game_Click;
            // 
            // gb_player
            // 
            gb_player.Anchor = AnchorStyles.None;
            gb_player.Controls.Add(txt_player_name);
            gb_player.Controls.Add(lbl_name);
            gb_player.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_player.Location = new Point(142, 165);
            gb_player.Name = "gb_player";
            gb_player.Size = new Size(619, 144);
            gb_player.TabIndex = 6;
            gb_player.TabStop = false;
            gb_player.Text = "Player";
            // 
            // txt_player_name
            // 
            txt_player_name.Location = new Point(112, 54);
            txt_player_name.Name = "txt_player_name";
            txt_player_name.Size = new Size(452, 43);
            txt_player_name.TabIndex = 3;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(19, 60);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(77, 31);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name";
            // 
            // SinglePlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 174, 208);
            ClientSize = new Size(906, 594);
            Controls.Add(btn_start_single_game);
            Controls.Add(gb_player);
            Name = "SinglePlayerForm";
            Text = "BoardForm";
            gb_player.ResumeLayout(false);
            gb_player.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_start_single_game;
        private GroupBox gb_player;
        private TextBox txt_player_name;
        private Label lbl_name;
    }
}