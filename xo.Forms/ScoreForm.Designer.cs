namespace xo.Forms
{
    partial class ScoreForm
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
            dgv_score = new DataGridView();
            pnl_score = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_score).BeginInit();
            pnl_score.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_score
            // 
            dgv_score.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_score.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_score.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_score.Location = new Point(0, 71);
            dgv_score.Name = "dgv_score";
            dgv_score.RowHeadersWidth = 51;
            dgv_score.Size = new Size(739, 418);
            dgv_score.TabIndex = 0;
            dgv_score.RowHeaderMouseDoubleClick += RowHeaderDblClick;
            // 
            // pnl_score
            // 
            pnl_score.BackColor = Color.FromArgb(50, 19, 71);
            pnl_score.Controls.Add(button1);
            pnl_score.Dock = DockStyle.Top;
            pnl_score.Location = new Point(0, 0);
            pnl_score.Name = "pnl_score";
            pnl_score.Size = new Size(739, 71);
            pnl_score.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(739, 71);
            button1.TabIndex = 0;
            button1.Text = "Delete Score";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DeleteBtnClick;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 174, 208);
            ClientSize = new Size(739, 489);
            Controls.Add(pnl_score);
            Controls.Add(dgv_score);
            Name = "ScoreForm";
            Text = "ScoreForm";
            ((System.ComponentModel.ISupportInitialize)dgv_score).EndInit();
            pnl_score.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_score;
        private Panel pnl_score;
        private Button button1;
    }
}