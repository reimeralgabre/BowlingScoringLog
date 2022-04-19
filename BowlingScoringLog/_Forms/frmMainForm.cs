using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BowlingScoringLog
{
    public partial class frmMainForm : Form
    {
        string selectedButton;
        Form frm;

        public frmMainForm()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRecordLog_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            selectedButton = button.Name;
            HighlightSelectedButton();
            frm = new frmRecordLog { TopLevel = false, TopMost = true };
            PanelToForm();
            //btnFilter.PerformClick();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            selectedButton = button.Name;
            HighlightSelectedButton();
            frm = new frmSettings { TopLevel = false, TopMost = true };
            PanelToForm();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            selectedButton = button.Name;
            HighlightSelectedButton();
            frm = new frmFAQ { TopLevel = false, TopMost = true };
            PanelToForm();
        }

        private void HighlightSelectedButton()
        {
            foreach (Control c in pnlSidePanel.Controls)
            {
                if (c is Button)
                {
                    if (c.Name == selectedButton)
                    {
                        c.BackColor = Color.Teal;
                    }
                    else
                    {
                        c.BackColor = Color.DarkSlateGray;
                    }
                }
            }
        }

        private void PanelToForm()
        {
            pnlMainForm.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pnlMainForm.Controls.Add(frm);
            frm.Show();
        }
    }
}
