namespace BowlingScoringLog
{
    partial class frmScoringLogData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGames = new System.Windows.Forms.Label();
            this.pnlParameters = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameOfGame = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoOfPlayers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.toolTipRecordLog = new System.Windows.Forms.ToolTip(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvScoringLog = new System.Windows.Forms.DataGridView();
            this.pnlFunctionTab = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnlParameters.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoringLog)).BeginInit();
            this.pnlFunctionTab.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblGames);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 30);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 5);
            this.panel3.TabIndex = 1;
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.Location = new System.Drawing.Point(3, 9);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(104, 13);
            this.lblGames.TabIndex = 0;
            this.lblGames.Text = "Bowling Score Log";
            // 
            // pnlParameters
            // 
            this.pnlParameters.BackColor = System.Drawing.Color.White;
            this.pnlParameters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlParameters.Controls.Add(this.label3);
            this.pnlParameters.Controls.Add(this.txtNameOfGame);
            this.pnlParameters.Controls.Add(this.btnStart);
            this.pnlParameters.Controls.Add(this.label1);
            this.pnlParameters.Controls.Add(this.txtNoOfPlayers);
            this.pnlParameters.Controls.Add(this.panel2);
            this.pnlParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlParameters.Location = new System.Drawing.Point(0, 0);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.Size = new System.Drawing.Size(1121, 88);
            this.pnlParameters.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name of Game";
            // 
            // txtNameOfGame
            // 
            this.txtNameOfGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtNameOfGame.Location = new System.Drawing.Point(105, 33);
            this.txtNameOfGame.Name = "txtNameOfGame";
            this.txtNameOfGame.Size = new System.Drawing.Size(110, 22);
            this.txtNameOfGame.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::BowlingScoringLog.Properties.Resources.Button_Play_icon__1_;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(191, 57);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(24, 24);
            this.btnStart.TabIndex = 2;
            this.toolTipRecordLog.SetToolTip(this.btnStart, "Start");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Players";
            // 
            // txtNoOfPlayers
            // 
            this.txtNoOfPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtNoOfPlayers.Location = new System.Drawing.Point(105, 58);
            this.txtNoOfPlayers.Name = "txtNoOfPlayers";
            this.txtNoOfPlayers.Size = new System.Drawing.Size(80, 22);
            this.txtNoOfPlayers.TabIndex = 1;
            this.txtNoOfPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNoOfPlayers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfPlayers_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtRemarks.Location = new System.Drawing.Point(61, 6);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(156, 22);
            this.txtRemarks.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::BowlingScoringLog.Properties.Resources.edit_file_icon;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(24, 24);
            this.btnUpdate.TabIndex = 4;
            this.toolTipRecordLog.SetToolTip(this.btnUpdate, "Update");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvScoringLog);
            this.pnlMain.Controls.Add(this.pnlFunctionTab);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 88);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1121, 260);
            this.pnlMain.TabIndex = 5;
            // 
            // dgvScoringLog
            // 
            this.dgvScoringLog.AllowUserToAddRows = false;
            this.dgvScoringLog.AllowUserToDeleteRows = false;
            this.dgvScoringLog.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvScoringLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvScoringLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvScoringLog.ColumnHeadersHeight = 25;
            this.dgvScoringLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoringLog.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoringLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScoringLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvScoringLog.Location = new System.Drawing.Point(0, 0);
            this.dgvScoringLog.MultiSelect = false;
            this.dgvScoringLog.Name = "dgvScoringLog";
            this.dgvScoringLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvScoringLog.RowHeadersVisible = false;
            this.dgvScoringLog.RowHeadersWidth = 30;
            this.dgvScoringLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvScoringLog.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvScoringLog.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvScoringLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScoringLog.ShowCellErrors = false;
            this.dgvScoringLog.ShowCellToolTips = false;
            this.dgvScoringLog.ShowEditingIcon = false;
            this.dgvScoringLog.ShowRowErrors = false;
            this.dgvScoringLog.Size = new System.Drawing.Size(1097, 260);
            this.dgvScoringLog.TabIndex = 255;
            this.dgvScoringLog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScoringLog_CellDoubleClick);
            // 
            // pnlFunctionTab
            // 
            this.pnlFunctionTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFunctionTab.Controls.Add(this.btnUpdate);
            this.pnlFunctionTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFunctionTab.Location = new System.Drawing.Point(1097, 0);
            this.pnlFunctionTab.Name = "pnlFunctionTab";
            this.pnlFunctionTab.Size = new System.Drawing.Size(24, 260);
            this.pnlFunctionTab.TabIndex = 256;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlFooter.Controls.Add(this.label2);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Controls.Add(this.txtRemarks);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 348);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1121, 34);
            this.pnlFooter.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::BowlingScoringLog.Properties.Resources.Save_icon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1044, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmScoringLogData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 382);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlParameters);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmScoringLogData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmScoringLogData_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlParameters.ResumeLayout(false);
            this.pnlParameters.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoringLog)).EndInit();
            this.pnlFunctionTab.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Panel pnlParameters;
        private System.Windows.Forms.ToolTip toolTipRecordLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoOfPlayers;
        private System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.DataGridView dgvScoringLog;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Panel pnlFunctionTab;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameOfGame;
    }
}