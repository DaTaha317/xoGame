namespace xo.Forms
{
    partial class MultiPlayerForm
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
            gb_player1 = new GroupBox();
            txt_player1_name = new TextBox();
            rb_player1_o = new RadioButton();
            rb_player1_x = new RadioButton();
            lbl_name1 = new Label();
            gb_player2 = new GroupBox();
            txt_player2_name = new TextBox();
            rb_player2_o = new RadioButton();
            rb_player2_x = new RadioButton();
            lbl_name2 = new Label();
            btn_start_multi_game = new Button();
            gb_player1.SuspendLayout();
            gb_player2.SuspendLayout();
            SuspendLayout();
            // 
            // gb_player1
            // 
            gb_player1.Anchor = AnchorStyles.None;
            gb_player1.Controls.Add(txt_player1_name);
            gb_player1.Controls.Add(rb_player1_o);
            gb_player1.Controls.Add(rb_player1_x);
            gb_player1.Controls.Add(lbl_name1);
            gb_player1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_player1.Location = new Point(26, 104);
            gb_player1.Name = "gb_player1";
            gb_player1.Size = new Size(335, 171);
            gb_player1.TabIndex = 0;
            gb_player1.TabStop = false;
            gb_player1.Text = "Player 1";
            // 
            // txt_player1_name
            // 
            txt_player1_name.Location = new Point(112, 54);
            txt_player1_name.Name = "txt_player1_name";
            txt_player1_name.Size = new Size(199, 43);
            txt_player1_name.TabIndex = 3;
            // 
            // rb_player1_o
            // 
            rb_player1_o.AutoSize = true;
            rb_player1_o.Location = new Point(252, 109);
            rb_player1_o.Name = "rb_player1_o";
            rb_player1_o.Size = new Size(59, 42);
            rb_player1_o.TabIndex = 2;
            rb_player1_o.TabStop = true;
            rb_player1_o.Text = "O";
            rb_player1_o.UseVisualStyleBackColor = true;
            // 
            // rb_player1_x
            // 
            rb_player1_x.AutoSize = true;
            rb_player1_x.Location = new Point(112, 109);
            rb_player1_x.Name = "rb_player1_x";
            rb_player1_x.Size = new Size(56, 42);
            rb_player1_x.TabIndex = 1;
            rb_player1_x.TabStop = true;
            rb_player1_x.Text = "X";
            rb_player1_x.UseVisualStyleBackColor = true;
            // 
            // lbl_name1
            // 
            lbl_name1.AutoSize = true;
            lbl_name1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name1.Location = new Point(19, 60);
            lbl_name1.Name = "lbl_name1";
            lbl_name1.Size = new Size(77, 31);
            lbl_name1.TabIndex = 0;
            lbl_name1.Text = "Name";
            // 
            // gb_player2
            // 
            gb_player2.Anchor = AnchorStyles.None;
            gb_player2.Controls.Add(txt_player2_name);
            gb_player2.Controls.Add(rb_player2_o);
            gb_player2.Controls.Add(rb_player2_x);
            gb_player2.Controls.Add(lbl_name2);
            gb_player2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_player2.Location = new Point(376, 104);
            gb_player2.Name = "gb_player2";
            gb_player2.Size = new Size(335, 171);
            gb_player2.TabIndex = 4;
            gb_player2.TabStop = false;
            gb_player2.Text = "Player 2";
            // 
            // txt_player2_name
            // 
            txt_player2_name.Location = new Point(112, 54);
            txt_player2_name.Name = "txt_player2_name";
            txt_player2_name.Size = new Size(199, 43);
            txt_player2_name.TabIndex = 3;
            // 
            // rb_player2_o
            // 
            rb_player2_o.AutoSize = true;
            rb_player2_o.Location = new Point(252, 109);
            rb_player2_o.Name = "rb_player2_o";
            rb_player2_o.Size = new Size(59, 42);
            rb_player2_o.TabIndex = 2;
            rb_player2_o.TabStop = true;
            rb_player2_o.Text = "O";
            rb_player2_o.UseVisualStyleBackColor = true;
            // 
            // rb_player2_x
            // 
            rb_player2_x.AutoSize = true;
            rb_player2_x.Location = new Point(112, 109);
            rb_player2_x.Name = "rb_player2_x";
            rb_player2_x.Size = new Size(56, 42);
            rb_player2_x.TabIndex = 1;
            rb_player2_x.TabStop = true;
            rb_player2_x.Text = "X";
            rb_player2_x.UseVisualStyleBackColor = true;
            // 
            // lbl_name2
            // 
            lbl_name2.AutoSize = true;
            lbl_name2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name2.Location = new Point(19, 60);
            lbl_name2.Name = "lbl_name2";
            lbl_name2.Size = new Size(77, 31);
            lbl_name2.TabIndex = 0;
            lbl_name2.Text = "Name";
            // 
            // btn_start_multi_game
            // 
            btn_start_multi_game.Anchor = AnchorStyles.None;
            btn_start_multi_game.BackColor = Color.FromArgb(50, 19, 71);
            btn_start_multi_game.FlatAppearance.BorderSize = 0;
            btn_start_multi_game.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 47, 148);
            btn_start_multi_game.FlatStyle = FlatStyle.Flat;
            btn_start_multi_game.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_start_multi_game.ForeColor = SystemColors.Control;
            btn_start_multi_game.Location = new Point(220, 340);
            btn_start_multi_game.Name = "btn_start_multi_game";
            btn_start_multi_game.Size = new Size(287, 70);
            btn_start_multi_game.TabIndex = 5;
            btn_start_multi_game.Text = "Start Game";
            btn_start_multi_game.UseVisualStyleBackColor = false;
            // 
            // MultiPlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 174, 208);
            ClientSize = new Size(739, 489);
            Controls.Add(btn_start_multi_game);
            Controls.Add(gb_player2);
            Controls.Add(gb_player1);
            Name = "MultiPlayerForm";
            Text = "MultiPlayer";
            gb_player1.ResumeLayout(false);
            gb_player1.PerformLayout();
            gb_player2.ResumeLayout(false);
            gb_player2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_player1;
        private RadioButton rb_player1_x;
        private Label lbl_name1;
        private TextBox txt_player1_name;
        private RadioButton rb_player1_o;
        private GroupBox gb_player2;
        private TextBox txt_player2_name;
        private RadioButton rb_player2_o;
        private RadioButton rb_player2_x;
        private Label lbl_name2;
        private Button btn_start_multi_game;
    }
}