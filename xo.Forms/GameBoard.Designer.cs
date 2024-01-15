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
            pnl_up_buttons = new Panel();
            btn_saveScores = new Button();
            btn_reset = new Button();
            btn_newGame = new Button();
            pnl_up_buttons.SuspendLayout();
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
            // 
            // GameBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 174, 208);
            ClientSize = new Size(739, 489);
            Controls.Add(pnl_up_buttons);
            Name = "GameBoard";
            Text = "GameBoard";
            pnl_up_buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_up_buttons;
        private Button btn_newGame;
        private Button btn_saveScores;
        private Button btn_reset;
    }
}