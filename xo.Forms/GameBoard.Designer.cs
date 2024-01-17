namespace xo.Forms
{
    partial class GameBoard
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
            components = new System.ComponentModel.Container();
            pnl_up_buttons = new Panel();
            btn_saveScores = new Button();
            btn_reset = new Button();
            btn_newGame = new Button();
            pnl_score = new Panel();
            lbl_player2_score = new Label();
            lbl_player1_score = new Label();
            lbl_player2 = new Label();
            lbl_player1 = new Label();
            lbl_score = new Label();
            t_pnl_board = new TableLayoutPanel();
            btn_31 = new Button();
            btn_32 = new Button();
            btn_33 = new Button();
            btn_11 = new Button();
            btn_21 = new Button();
            btn_12 = new Button();
            btn_22 = new Button();
            btn_13 = new Button();
            btn_23 = new Button();
            ComputerTimer = new System.Windows.Forms.Timer(components);
            pnl_up_buttons.SuspendLayout();
            pnl_score.SuspendLayout();
            t_pnl_board.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_up_buttons
            // 
            pnl_up_buttons.BackColor = Color.FromArgb(50, 19, 71);
            pnl_up_buttons.Controls.Add(btn_saveScores);
            pnl_up_buttons.Controls.Add(btn_reset);
            pnl_up_buttons.Controls.Add(btn_newGame);
            pnl_up_buttons.Dock = DockStyle.Top;
            pnl_up_buttons.Location = new Point(0, 0);
            pnl_up_buttons.Name = "pnl_up_buttons";
            pnl_up_buttons.Size = new Size(739, 71);
            pnl_up_buttons.TabIndex = 0;
            // 
            // btn_saveScores
            // 
            btn_saveScores.Anchor = AnchorStyles.None;
            btn_saveScores.FlatAppearance.BorderSize = 0;
            btn_saveScores.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 47, 148);
            btn_saveScores.FlatStyle = FlatStyle.Flat;
            btn_saveScores.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_saveScores.ForeColor = SystemColors.Control;
            btn_saveScores.Location = new Point(498, 0);
            btn_saveScores.Name = "btn_saveScores";
            btn_saveScores.Size = new Size(249, 71);
            btn_saveScores.TabIndex = 2;
            btn_saveScores.Text = "Save Score";
            btn_saveScores.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            btn_reset.Anchor = AnchorStyles.None;
            btn_reset.FlatAppearance.BorderSize = 0;
            btn_reset.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 47, 148);
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reset.ForeColor = SystemColors.Control;
            btn_reset.Location = new Point(249, 0);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(249, 71);
            btn_reset.TabIndex = 1;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_newGame
            // 
            btn_newGame.Anchor = AnchorStyles.None;
            btn_newGame.FlatAppearance.BorderSize = 0;
            btn_newGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 47, 148);
            btn_newGame.FlatStyle = FlatStyle.Flat;
            btn_newGame.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_newGame.ForeColor = SystemColors.Control;
            btn_newGame.Location = new Point(0, 0);
            btn_newGame.Name = "btn_newGame";
            btn_newGame.Size = new Size(249, 71);
            btn_newGame.TabIndex = 0;
            btn_newGame.Text = "New Game";
            btn_newGame.UseVisualStyleBackColor = true;
            btn_newGame.Click += btn_newGame_Click;
            // 
            // pnl_score
            // 
            pnl_score.BackColor = Color.LavenderBlush;
            pnl_score.Controls.Add(lbl_player2_score);
            pnl_score.Controls.Add(lbl_player1_score);
            pnl_score.Controls.Add(lbl_player2);
            pnl_score.Controls.Add(lbl_player1);
            pnl_score.Controls.Add(lbl_score);
            pnl_score.Dock = DockStyle.Top;
            pnl_score.Location = new Point(0, 71);
            pnl_score.Name = "pnl_score";
            pnl_score.Size = new Size(739, 45);
            pnl_score.TabIndex = 1;
            // 
            // lbl_player2_score
            // 
            lbl_player2_score.Anchor = AnchorStyles.None;
            lbl_player2_score.AutoSize = true;
            lbl_player2_score.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_player2_score.Location = new Point(617, 4);
            lbl_player2_score.Name = "lbl_player2_score";
            lbl_player2_score.Size = new Size(27, 31);
            lbl_player2_score.TabIndex = 4;
            lbl_player2_score.Text = "0";
            // 
            // lbl_player1_score
            // 
            lbl_player1_score.Anchor = AnchorStyles.None;
            lbl_player1_score.AutoSize = true;
            lbl_player1_score.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_player1_score.Location = new Point(409, 4);
            lbl_player1_score.Name = "lbl_player1_score";
            lbl_player1_score.Size = new Size(27, 31);
            lbl_player1_score.TabIndex = 3;
            lbl_player1_score.Text = "0";
            // 
            // lbl_player2
            // 
            lbl_player2.Anchor = AnchorStyles.None;
            lbl_player2.AutoSize = true;
            lbl_player2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_player2.Location = new Point(501, 4);
            lbl_player2.Name = "lbl_player2";
            lbl_player2.Size = new Size(121, 31);
            lbl_player2.TabIndex = 2;
            lbl_player2.Text = "Computer";
            // 
            // lbl_player1
            // 
            lbl_player1.Anchor = AnchorStyles.None;
            lbl_player1.AutoSize = true;
            lbl_player1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_player1.Location = new Point(327, 4);
            lbl_player1.Name = "lbl_player1";
            lbl_player1.Size = new Size(80, 31);
            lbl_player1.TabIndex = 1;
            lbl_player1.Text = "Player";
            // 
            // lbl_score
            // 
            lbl_score.Anchor = AnchorStyles.None;
            lbl_score.AutoSize = true;
            lbl_score.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_score.Location = new Point(88, 7);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(73, 31);
            lbl_score.TabIndex = 0;
            lbl_score.Text = "Score";
            // 
            // t_pnl_board
            // 
            t_pnl_board.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            t_pnl_board.ColumnCount = 3;
            t_pnl_board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            t_pnl_board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            t_pnl_board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            t_pnl_board.Controls.Add(btn_31, 0, 2);
            t_pnl_board.Controls.Add(btn_32, 0, 2);
            t_pnl_board.Controls.Add(btn_33, 0, 2);
            t_pnl_board.Controls.Add(btn_11, 0, 0);
            t_pnl_board.Controls.Add(btn_21, 0, 1);
            t_pnl_board.Controls.Add(btn_12, 1, 0);
            t_pnl_board.Controls.Add(btn_22, 1, 1);
            t_pnl_board.Controls.Add(btn_13, 2, 0);
            t_pnl_board.Controls.Add(btn_23, 2, 1);
            t_pnl_board.Location = new Point(178, 131);
            t_pnl_board.Name = "t_pnl_board";
            t_pnl_board.RowCount = 3;
            t_pnl_board.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            t_pnl_board.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            t_pnl_board.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            t_pnl_board.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            t_pnl_board.Size = new Size(340, 340);
            t_pnl_board.TabIndex = 2;
            // 
            // btn_31
            // 
            btn_31.Dock = DockStyle.Fill;
            btn_31.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_31.Location = new Point(3, 229);
            btn_31.Name = "btn_31";
            btn_31.Size = new Size(107, 108);
            btn_31.TabIndex = 3;
            btn_31.UseVisualStyleBackColor = true;
            btn_31.Click += button_clicked;
            btn_31.MouseEnter += button_enter;
            btn_31.MouseLeave += button_leave;
            // 
            // btn_32
            // 
            btn_32.Dock = DockStyle.Fill;
            btn_32.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_32.Location = new Point(116, 229);
            btn_32.Name = "btn_32";
            btn_32.Size = new Size(107, 108);
            btn_32.TabIndex = 2;
            btn_32.UseVisualStyleBackColor = true;
            btn_32.Click += button_clicked;
            btn_32.MouseEnter += button_enter;
            btn_32.MouseLeave += button_leave;
            // 
            // btn_33
            // 
            btn_33.Dock = DockStyle.Fill;
            btn_33.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_33.Location = new Point(229, 229);
            btn_33.Name = "btn_33";
            btn_33.Size = new Size(108, 108);
            btn_33.TabIndex = 1;
            btn_33.UseVisualStyleBackColor = true;
            btn_33.Click += button_clicked;
            btn_33.MouseEnter += button_enter;
            btn_33.MouseLeave += button_leave;
            // 
            // btn_11
            // 
            btn_11.Dock = DockStyle.Fill;
            btn_11.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_11.Location = new Point(3, 3);
            btn_11.Name = "btn_11";
            btn_11.Size = new Size(107, 107);
            btn_11.TabIndex = 0;
            btn_11.UseVisualStyleBackColor = true;
            btn_11.Click += button_clicked;
            btn_11.MouseEnter += button_enter;
            btn_11.MouseLeave += button_leave;
            // 
            // btn_21
            // 
            btn_21.Dock = DockStyle.Fill;
            btn_21.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_21.Location = new Point(3, 116);
            btn_21.Name = "btn_21";
            btn_21.Size = new Size(107, 107);
            btn_21.TabIndex = 4;
            btn_21.UseVisualStyleBackColor = true;
            btn_21.Click += button_clicked;
            btn_21.MouseEnter += button_enter;
            btn_21.MouseLeave += button_leave;
            // 
            // btn_12
            // 
            btn_12.Dock = DockStyle.Fill;
            btn_12.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_12.Location = new Point(116, 3);
            btn_12.Name = "btn_12";
            btn_12.Size = new Size(107, 107);
            btn_12.TabIndex = 5;
            btn_12.UseVisualStyleBackColor = true;
            btn_12.Click += button_clicked;
            btn_12.MouseEnter += button_enter;
            btn_12.MouseLeave += button_leave;
            // 
            // btn_22
            // 
            btn_22.Dock = DockStyle.Fill;
            btn_22.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_22.Location = new Point(116, 116);
            btn_22.Name = "btn_22";
            btn_22.Size = new Size(107, 107);
            btn_22.TabIndex = 6;
            btn_22.UseVisualStyleBackColor = true;
            btn_22.Click += button_clicked;
            btn_22.MouseEnter += button_enter;
            btn_22.MouseLeave += button_leave;
            // 
            // btn_13
            // 
            btn_13.Dock = DockStyle.Fill;
            btn_13.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_13.Location = new Point(229, 3);
            btn_13.Name = "btn_13";
            btn_13.Size = new Size(108, 107);
            btn_13.TabIndex = 7;
            btn_13.UseVisualStyleBackColor = true;
            btn_13.Click += button_clicked;
            btn_13.MouseEnter += button_enter;
            btn_13.MouseLeave += button_leave;
            // 
            // btn_23
            // 
            btn_23.Dock = DockStyle.Fill;
            btn_23.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_23.Location = new Point(229, 116);
            btn_23.Name = "btn_23";
            btn_23.Size = new Size(108, 107);
            btn_23.TabIndex = 8;
            btn_23.UseVisualStyleBackColor = true;
            btn_23.Click += button_clicked;
            btn_23.MouseEnter += button_enter;
            btn_23.MouseLeave += button_leave;
            // 
            // ComputerTimer
            // 
            ComputerTimer.Interval = 1000;
            ComputerTimer.Tick += ComputerTurn;
            // 
            // GameBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 174, 208);
            ClientSize = new Size(739, 489);
            Controls.Add(t_pnl_board);
            Controls.Add(pnl_score);
            Controls.Add(pnl_up_buttons);
            Name = "GameBoard";
            Text = "GameBoard";
            pnl_up_buttons.ResumeLayout(false);
            pnl_score.ResumeLayout(false);
            pnl_score.PerformLayout();
            t_pnl_board.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_up_buttons;
        private Button btn_newGame;
        private Button btn_saveScores;
        private Button btn_reset;
        private Panel pnl_score;
        private Label lbl_score;
        private Label lbl_player1;
        private Label lbl_player2_score;
        private Label lbl_player1_score;
        private Label lbl_player2;
        private TableLayoutPanel t_pnl_board;
        private Button btn_11;
        private Button btn_31;
        private Button btn_32;
        private Button btn_33;
        private Button btn_21;
        private Button btn_12;
        private Button btn_22;
        private Button btn_13;
        private Button btn_23;
        private System.Windows.Forms.Timer ComputerTimer;
    }
}