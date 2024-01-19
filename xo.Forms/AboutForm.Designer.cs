namespace xo.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            lbl_welcome = new Label();
            logo_welcomeForm = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)logo_welcomeForm).BeginInit();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.None;
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(339, 109);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(260, 81);
            lbl_welcome.TabIndex = 3;
            lbl_welcome.Text = "XoGame";
            // 
            // logo_welcomeForm
            // 
            logo_welcomeForm.Anchor = AnchorStyles.None;
            logo_welcomeForm.Image = (Image)resources.GetObject("logo_welcomeForm.Image");
            logo_welcomeForm.Location = new Point(49, 38);
            logo_welcomeForm.Name = "logo_welcomeForm";
            logo_welcomeForm.Size = new Size(201, 193);
            logo_welcomeForm.SizeMode = PictureBoxSizeMode.Zoom;
            logo_welcomeForm.TabIndex = 2;
            logo_welcomeForm.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 258);
            label1.Name = "label1";
            label1.Size = new Size(677, 81);
            label1.TabIndex = 4;
            label1.Text = "Developer : Ahmed Taha";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(224, 355);
            label2.Name = "label2";
            label2.Size = new Size(278, 81);
            label2.TabIndex = 5;
            label2.Text = "ITI Banha";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 174, 208);
            ClientSize = new Size(739, 489);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_welcome);
            Controls.Add(logo_welcomeForm);
            Name = "AboutForm";
            Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)logo_welcomeForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_welcome;
        private PictureBox logo_welcomeForm;
        private Label label1;
        private Label label2;
    }
}