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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            GetSettingsData();
        }

        private void GetSettingsData()
        {
            using (SqlConnection conn = Database.DefSQLConnection())
            {
                SqlCommand cmd = new SqlCommand("select * from Settings", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while(rdr.Read())
                    {
                        txtMinNoOfPlayers.Text = Convert.ToString(rdr["MinPlayers"]);
                        txtMaxNoOfPlayers.Text = Convert.ToString(rdr["MaxPlayers"]);
                    }
                }
            }
        }

        private void txtMinNoOfPlayers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaxNoOfPlayers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMinNoOfPlayers.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please input minimum number of players.", "Bowling Scoring Log",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtMinNoOfPlayers.Focus();
            }
            else if(txtMaxNoOfPlayers.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please input maximum number of players.", "Bowling Scoring Log",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtMaxNoOfPlayers.Focus();
            }
            else if (GetValue(txtMinNoOfPlayers.Text) > GetValue(txtMaxNoOfPlayers.Text))
            {
                MessageBox.Show("Minimum number of players should be less than or equal to maximum number of players.", "Bowling Scoring Log",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtMinNoOfPlayers.Focus();
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to save this data?", "Bowling Score Log",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                { 
                    using (SqlConnection conn = Database.DefSQLConnection())
                    {
                        SqlCommand cmd = new SqlCommand("update Settings set " +
                                                            "MinPlayers = @MinPlayers, " +
                                                            "MaxPlayers = @MaxPlayers ", conn);
                        cmd.Parameters.AddWithValue("@MinPlayers", txtMinNoOfPlayers.Text);
                        cmd.Parameters.AddWithValue("@MaxPlayers", txtMaxNoOfPlayers.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Settings successfully saved.", "Bowling Scoring Log Settings",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        public int GetValue(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            int value;

            if (int.TryParse(text, out value))
                return value;

            //not parsable
            return 0;
        }
    }
}
