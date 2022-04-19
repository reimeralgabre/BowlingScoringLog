namespace BowlingScoringLog
{
    partial class frmMainForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRecordLog = new System.Windows.Forms.Button();
            this.pnlMainTopPanel = new System.Windows.Forms.Panel();
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.pnlMainForm = new System.Windows.Forms.Panel();
            this.toolTipRecordLog = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSidePanel.Controls.Add(this.btnFAQ);
            this.pnlSidePanel.Controls.Add(this.btnSettings);
            this.pnlSidePanel.Controls.Add(this.btnRecordLog);
            this.pnlSidePanel.Controls.Add(this.pnlMainTopPanel);
            this.pnlSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(187, 547);
            this.pnlSidePanel.TabIndex = 0;
            // 
            // btnFAQ
            // 
            this.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFAQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFAQ.FlatAppearance.BorderSize = 0;
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.ForeColor = System.Drawing.Color.White;
            this.btnFAQ.Image = global::BowlingScoringLog.Properties.Resources.Apps_Help_icon;
            this.btnFAQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFAQ.Location = new System.Drawing.Point(0, 100);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(187, 30);
            this.btnFAQ.TabIndex = 2;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::BowlingScoringLog.Properties.Resources.Apps_Preferences_Desktop_C_icon;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 70);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(187, 30);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRecordLog
            // 
            this.btnRecordLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecordLog.FlatAppearance.BorderSize = 0;
            this.btnRecordLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordLog.ForeColor = System.Drawing.Color.White;
            this.btnRecordLog.Image = global::BowlingScoringLog.Properties.Resources.Apps_Pyrenamer_icon;
            this.btnRecordLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecordLog.Location = new System.Drawing.Point(0, 40);
            this.btnRecordLog.Name = "btnRecordLog";
            this.btnRecordLog.Size = new System.Drawing.Size(187, 30);
            this.btnRecordLog.TabIndex = 0;
            this.btnRecordLog.Text = "RECORD LOG";
            this.btnRecordLog.UseVisualStyleBackColor = true;
            this.btnRecordLog.Click += new System.EventHandler(this.btnRecordLog_Click);
            // 
            // pnlMainTopPanel
            // 
            this.pnlMainTopPanel.BackgroundImage = global::BowlingScoringLog.Properties.Resources.Top_Menu_Panel;
            this.pnlMainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainTopPanel.Name = "pnlMainTopPanel";
            this.pnlMainTopPanel.Size = new System.Drawing.Size(187, 40);
            this.pnlMainTopPanel.TabIndex = 2;
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(187, 0);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(934, 40);
            this.pnlTopPanel.TabIndex = 1;
            // 
            // pnlMainForm
            // 
            this.pnlMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainForm.Location = new System.Drawing.Point(187, 40);
            this.pnlMainForm.Name = "pnlMainForm";
            this.pnlMainForm.Size = new System.Drawing.Size(934, 507);
            this.pnlMainForm.TabIndex = 2;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 547);
            this.Controls.Add(this.pnlMainForm);
            this.Controls.Add(this.pnlTopPanel);
            this.Controls.Add(this.pnlSidePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(700, 380);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.pnlSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.Panel pnlMainTopPanel;
        private System.Windows.Forms.Button btnRecordLog;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Panel pnlMainForm;
        private System.Windows.Forms.ToolTip toolTipRecordLog;
    }
}

