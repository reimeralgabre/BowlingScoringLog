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
    public partial class frmScoringLogData : Form
    {
        public int saveMode;
        SqlTransaction trans;
        public int id;

        int minPlayers;
        int maxPlayers;

        int score;

        public frmScoringLogData()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            txtNameOfGame.SelectionStart = 0;
        }

        private void frmScoringLogData_Load(object sender, EventArgs e)
        {
            InitGridScoringLog();
            DefParams();
        }

        private void DefParams()
        {
            if (saveMode == 0)
            {
                btnStart.Visible = true;

                using (SqlConnection conn = Database.DefSQLConnection())
                {
                    SqlCommand cmdGameNo = new SqlCommand("select case when max(Id) is null then 1 " +
                                                          "else max(Id) +1 end 'Id' " +
                                                          "from Games", conn);
                    txtNameOfGame.Text = "Game " + Convert.ToString(cmdGameNo.ExecuteScalar());

                    SqlCommand cmd = new SqlCommand("select top 1 MinPlayers, MaxPlayers from Settings order by id desc", conn);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            minPlayers = Convert.ToInt32(rdr["MinPlayers"]);
                            maxPlayers = Convert.ToInt32(rdr["MaxPlayers"]);
                        }
                    }
                    rdr.Close();
                    txtNoOfPlayers.Text = Convert.ToString(minPlayers);

                    txtRemarks.SelectAll();
                    txtRemarks.Focus();
                }
            }
            else if (saveMode == 1)
            {
                btnStart.Visible = false;

                using (SqlConnection conn = Database.DefSQLConnection())
                {
                    SqlCommand cmdG = new SqlCommand("select * from Games where Id = @Id", conn);
                    cmdG.Parameters.AddWithValue("@Id", id);
                    SqlDataReader rdrG = cmdG.ExecuteReader();
                    if (rdrG.HasRows)
                    {
                        while (rdrG.Read())
                        {
                            txtNameOfGame.Text = Convert.ToString(rdrG["NameOfGame"]);
                            txtNoOfPlayers.Text = Convert.ToString(rdrG["NumberOfPlayers"]);
                            txtRemarks.Text = Convert.ToString(rdrG["Remarks"]);
                        }
                    }
                    rdrG.Close();

                    dgvScoringLog.Rows.Clear();
                    SqlCommand cmdP = new SqlCommand("select * from ScoreLog where GId = @GId order by Id asc", conn);
                    cmdP.Parameters.AddWithValue("@GId", id);
                    SqlDataReader rdrP = cmdP.ExecuteReader();
                    int num = 0;
                    if (rdrP.HasRows)
                    {
                        while (rdrP.Read())
                        {
                            num += 1;
                            dgvScoringLog.Rows.Add(rdrP["Id"],
                                                   num,
                                                   rdrP["PlayerName"],
                                                   rdrP["Frame1Box1"],
                                                   rdrP["Frame1Box2"],
                                                   rdrP["Frame1Total"],
                                                   rdrP["Frame2Box1"],
                                                   rdrP["Frame2Box2"],
                                                   rdrP["Frame2Total"],
                                                   rdrP["Frame3Box1"],
                                                   rdrP["Frame3Box2"],
                                                   rdrP["Frame3Total"],
                                                   rdrP["Frame4Box1"],
                                                   rdrP["Frame4Box2"],
                                                   rdrP["Frame4Total"],
                                                   rdrP["Frame5Box1"],
                                                   rdrP["Frame5Box2"],
                                                   rdrP["Frame5Total"],
                                                   rdrP["Frame6Box1"],
                                                   rdrP["Frame6Box2"],
                                                   rdrP["Frame6Total"],
                                                   rdrP["Frame7Box1"],
                                                   rdrP["Frame7Box2"],
                                                   rdrP["Frame7Total"],
                                                   rdrP["Frame8Box1"],
                                                   rdrP["Frame8Box2"],
                                                   rdrP["Frame8Total"],
                                                   rdrP["Frame9Box1"],
                                                   rdrP["Frame9Box2"],
                                                   rdrP["Frame9Total"],
                                                   rdrP["Frame10Box1"],
                                                   rdrP["Frame10Box2"],
                                                   rdrP["Frame10Box3"],
                                                   rdrP["Frame10Total"]);
                        }
                    }
                }
                txtRemarks.SelectAll();
                txtRemarks.Focus();
            }
        }

        private void InitGridScoringLog()
        {
            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn No = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn PlayerName = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame1Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame1Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame1 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame2Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame2Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame2 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame3Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame3Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame3 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame4Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame4Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame4 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame5Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame5Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame5 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame6Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame6Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame6 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame7Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame7Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame7 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame8Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame8Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame8 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame9Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame9Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame9 = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn Frame10Box1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame10Box2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame10Box3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Frame10 = new DataGridViewTextBoxColumn();

            using (DataGridViewTextBoxColumn c = Id)
            {
                c.Name = "Id";
                c.DataPropertyName = "Id";
                c.HeaderText = "Id";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = false;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = No)
            {
                c.Name = "No";
                c.DataPropertyName = "No";
                c.HeaderText = "#";
                c.ValueType = typeof(System.Int32);
                c.Width = 20;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = PlayerName)
            {
                c.Name = "PlayerName";
                c.DataPropertyName = "PlayerName";
                c.HeaderText = "Player Name";
                c.ValueType = typeof(System.String);
                c.ReadOnly = false;
                c.Visible = true;
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            using (DataGridViewTextBoxColumn c = Frame1Box1)
            {
                c.Name = "Frame1Box1";
                c.DataPropertyName = "Frame1Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame1Box2)
            {
                c.Name = "Frame1Box2";
                c.DataPropertyName = "Frame1Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame1)
            {
                c.Name = "Frame1";
                c.DataPropertyName = "Frame1";
                c.HeaderText = "Frame 1";
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.ValueType = typeof(System.Int32);
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame2Box1)
            {
                c.Name = "Frame2Box1";
                c.DataPropertyName = "Frame2Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame2Box2)
            {
                c.Name = "Frame2Box2";
                c.DataPropertyName = "Frame2Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame2)
            {
                c.Name = "Frame2";
                c.DataPropertyName = "Frame2";
                c.HeaderText = "Frame 2";
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.ValueType = typeof(System.Int32);
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame3Box1)
            {
                c.Name = "Frame3Box1";
                c.DataPropertyName = "Frame3Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame3Box2)
            {
                c.Name = "Frame3Box2";
                c.DataPropertyName = "Frame3Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame3)
            {
                c.Name = "Frame3";
                c.DataPropertyName = "Frame3";
                c.HeaderText = "Frame 3";
                c.ValueType = typeof(System.Int32);
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame4Box1)
            {
                c.Name = "Frame4Box1";
                c.DataPropertyName = "Frame4Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame4Box2)
            {
                c.Name = "Frame4Box2";
                c.DataPropertyName = "Frame4Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame4)
            {
                c.Name = "Frame4";
                c.DataPropertyName = "Frame4";
                c.HeaderText = "Frame 4";
                c.ValueType = typeof(System.Int32);
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame5Box1)
            {
                c.Name = "Frame5Box1";
                c.DataPropertyName = "Frame5Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame5Box2)
            {
                c.Name = "Frame5Box2";
                c.DataPropertyName = "Frame5Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame5)
            {
                c.Name = "Frame5";
                c.DataPropertyName = "Frame5";
                c.HeaderText = "Frame 5";
                c.ValueType = typeof(System.Int32);
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame6Box1)
            {
                c.Name = "Frame6Box1";
                c.DataPropertyName = "Frame6Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame6Box2)
            {
                c.Name = "Frame6Box2";
                c.DataPropertyName = "Frame6Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame6)
            {
                c.Name = "Frame6";
                c.DataPropertyName = "Frame6";
                c.HeaderText = "Frame 6";
                c.ValueType = typeof(System.Int32);
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame7Box1)
            {
                c.Name = "Frame7Box1";
                c.DataPropertyName = "Frame7Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame7Box2)
            {
                c.Name = "Frame7Box2";
                c.DataPropertyName = "Frame7Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame7)
            {
                c.Name = "Frame7";
                c.DataPropertyName = "Frame7";
                c.HeaderText = "Frame 7";
                c.ValueType = typeof(System.Int32);
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame8Box1)
            {
                c.Name = "Frame8Box1";
                c.DataPropertyName = "Frame8Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame8Box2)
            {
                c.Name = "Frame8Box2";
                c.DataPropertyName = "Frame8Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame8)
            {
                c.Name = "Frame8";
                c.DataPropertyName = "Frame8";
                c.HeaderText = "Frame 8";
                c.ValueType = typeof(System.Int32);
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame9Box1)
            {
                c.Name = "Frame9Box1";
                c.DataPropertyName = "Frame9Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame9Box2)
            {
                c.Name = "Frame9Box2";
                c.DataPropertyName = "Frame9Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame9)
            {
                c.Name = "Frame9";
                c.DataPropertyName = "Frame9";
                c.HeaderText = "Frame 9";
                c.ValueType = typeof(System.Int32);
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame10Box1)
            {
                c.Name = "Frame10Box1";
                c.DataPropertyName = "Frame10Box1";
                c.HeaderText = "1";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame10Box2)
            {
                c.Name = "Frame10Box2";
                c.DataPropertyName = "Frame10Box2";
                c.HeaderText = "2";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame10Box3)
            {
                c.Name = "Frame10Box3";
                c.DataPropertyName = "Frame10Box3";
                c.HeaderText = "3";
                c.ValueType = typeof(System.Int32);
                c.Width = 15;
                c.ReadOnly = true;
                c.Visible = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Frame10)
            {
                c.Name = "Frame10";
                c.DataPropertyName = "Frame10";
                c.HeaderText = "Frame 10";
                c.ValueType = typeof(System.Int32);
                c.DefaultCellStyle.BackColor = Color.Teal;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.Width = 60;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvScoringLog.Columns.Clear();
            dgvScoringLog.Columns.AddRange(
                new DataGridViewColumn[]{
                Id,
                No,
                PlayerName,
                Frame1Box1,
                Frame1Box2,
                Frame1,
                Frame2Box1,
                Frame2Box2,
                Frame2,
                Frame3Box1,
                Frame3Box2,
                Frame3,
                Frame4Box1,
                Frame4Box2,
                Frame4,
                Frame5Box1,
                Frame5Box2,
                Frame5,
                Frame6Box1,
                Frame6Box2,
                Frame6,
                Frame7Box1,
                Frame7Box2,
                Frame7,
                Frame8Box1,
                Frame8Box2,
                Frame8,
                Frame9Box1,
                Frame9Box2,
                Frame9,
                Frame10Box1,
                Frame10Box2,
                Frame10Box3,
                Frame10});

            dgvScoringLog.ColumnHeadersHeight = 40;
            dgvScoringLog.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvScoringLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvScoringLog.DefaultCellStyle.Font = new Font("Segoe UI", 7);
            foreach (DataGridViewColumn col in dgvScoringLog.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetValue(txtNoOfPlayers.Text) <= 0)
                {
                    MessageBox.Show("Please input number of teams.", "Bowling Scoring Log",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtNoOfPlayers.Focus();
                    txtNoOfPlayers.SelectAll();
                }
                else if (GetValue(txtNoOfPlayers.Text) < minPlayers)
                {
                    MessageBox.Show("Minimum number of players should be " + Convert.ToString(minPlayers) + ".", "Bowling Scoring Log",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtNoOfPlayers.Focus();
                    txtNoOfPlayers.SelectAll();
                }
                else if (GetValue(txtNoOfPlayers.Text) > maxPlayers)
                {
                    MessageBox.Show("Maximum number of players should be " + Convert.ToString(maxPlayers) + ".", "Bowling Scoring Log",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtNoOfPlayers.Focus();
                    txtNoOfPlayers.SelectAll();
                }
                else
                {
                    dgvScoringLog.Rows.Clear();
                    int j = Convert.ToInt32(txtNoOfPlayers.Text);
                    for (int i = 0; i < j; i++)
                    {
                        dgvScoringLog.Rows.Add(-1, 
                                               i + 1, 
                                               "Player " + Convert.ToString(i + 1),
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "",
                                               "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public decimal GetValue(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            decimal value;

            if (decimal.TryParse(text, out value))
                return value;

            //not parsable
            return 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvScoringLog.SelectedRows.Count > 0)
            {
                if (dgvScoringLog.CurrentRow.Cells["PlayerName"].Value == null ||
                    dgvScoringLog.CurrentRow.Cells["PlayerName"].Value == DBNull.Value ||
                    dgvScoringLog.CurrentRow.Cells["PlayerName"].Value.ToString().Trim().Length == 0)
                {
                    MessageBox.Show("Please enter player name.", "Bowling Scoring Log",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    dgvScoringLog.CurrentRow.Cells["PlayerName"].Selected = true;
                }
                else
                {
                    frmBowlingScoringLogTrans f = new frmBowlingScoringLogTrans();
                    f.lblPlayerName.Text = Convert.ToString(dgvScoringLog.CurrentRow.Cells["PlayerName"].Value);
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a player.", "Barcode Scoring Log",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvScoringLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScoringLog.SelectedCells.Count > 0)
            {
                btnUpdate.PerformClick();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this data?", "Bowling Score Log",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (saveMode == 0)
                {
                    using (SqlConnection conn = Database.DefSQLConnection())
                    {
                        using (trans = conn.BeginTransaction())
                        {
                            try
                            {
                                SqlCommand cmdId = new SqlCommand("select case when max(Id) is null then 1 " +
                                                                  "else max(Id) +1 end 'Id' " +
                                                                  "from Games", conn);
                                cmdId.Transaction = trans;
                                id = Convert.ToInt32(cmdId.ExecuteScalar());

                                SqlCommand cmdG = new SqlCommand("insert into Games " +
                                                                     "(Id, " + "" +
                                                                     "NameOfGame, " +
                                                                     "NumberOfPlayers, " +
                                                                     "Remarks) " +
                                                                 "values " +
                                                                     "(@Id, " + "" +
                                                                     "@NameOfGame, " +
                                                                     "@NumberOfPlayers, " +
                                                                     "@Remarks) ", conn);
                                cmdG.Parameters.AddWithValue("@Id", id);
                                cmdG.Parameters.AddWithValue("@NameOfGame", txtNameOfGame.Text);
                                cmdG.Parameters.AddWithValue("@NumberOfPlayers", txtNoOfPlayers.Text);
                                cmdG.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                                cmdG.Transaction = trans;
                                cmdG.ExecuteNonQuery();

                                foreach (DataGridViewRow row in dgvScoringLog.Rows)
                                {
                                    DataTable dtScore = new DataTable();
                                    dtScore.Columns.AddRange(new DataColumn[] { new DataColumn("Value", typeof(Int32)) });
                                    dtScore.Rows.Clear();
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame1"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame2"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame3"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame4"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame5"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame6"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame7"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame8"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame9"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame10"].Value)));
                                    score = Convert.ToInt32(dtScore.Compute("max([Value])", string.Empty));

                                    SqlCommand cmdP = new SqlCommand("insert into ScoreLog " +
                                                                        "(PlayerName," +
                                                                        "Frame1Box1, " +
                                                                        "Frame1Box2, " +
                                                                        "Frame1Total, " +
                                                                        "Frame2Box1, " +
                                                                        "Frame2Box2, " +
                                                                        "Frame2Total, " +
                                                                        "Frame3Box1, " +
                                                                        "Frame3Box2, " +
                                                                        "Frame3Total, " +
                                                                        "Frame4Box1, " +
                                                                        "Frame4Box2, " +
                                                                        "Frame4Total, " +
                                                                        "Frame5Box1, " +
                                                                        "Frame5Box2, " +
                                                                        "Frame5Total, " +
                                                                        "Frame6Box1, " +
                                                                        "Frame6Box2, " +
                                                                        "Frame6Total, " +
                                                                        "Frame7Box1, " +
                                                                        "Frame7Box2, " +
                                                                        "Frame7Total, " +
                                                                        "Frame8Box1, " +
                                                                        "Frame8Box2, " +
                                                                        "Frame8Total, " +
                                                                        "Frame9Box1, " +
                                                                        "Frame9Box2, " +
                                                                        "Frame9Total, " +
                                                                        "Frame10Box1, " +
                                                                        "Frame10Box2, " +
                                                                        "Frame10Box3, " +
                                                                        "Frame10Total, " +
                                                                        "pins_knocked_down, " +
                                                                        "GId) " +
                                                                    "values " +
                                                                        "(@PlayerName," +
                                                                        "@Frame1Box1, " +
                                                                        "@Frame1Box2, " +
                                                                        "@Frame1Total, " +
                                                                        "@Frame2Box1, " +
                                                                        "@Frame2Box2, " +
                                                                        "@Frame2Total, " +
                                                                        "@Frame3Box1, " +
                                                                        "@Frame3Box2, " +
                                                                        "@Frame3Total, " +
                                                                        "@Frame4Box1, " +
                                                                        "@Frame4Box2, " +
                                                                        "@Frame4Total, " +
                                                                        "@Frame5Box1, " +
                                                                        "@Frame5Box2, " +
                                                                        "@Frame5Total, " +
                                                                        "@Frame6Box1, " +
                                                                        "@Frame6Box2, " +
                                                                        "@Frame6Total, " +
                                                                        "@Frame7Box1, " +
                                                                        "@Frame7Box2, " +
                                                                        "@Frame7Total, " +
                                                                        "@Frame8Box1, " +
                                                                        "@Frame8Box2, " +
                                                                        "@Frame8Total, " +
                                                                        "@Frame9Box1, " +
                                                                        "@Frame9Box2, " +
                                                                        "@Frame9Total, " +
                                                                        "@Frame10Box1, " +
                                                                        "@Frame10Box2, " +
                                                                        "@Frame10Box3, " +
                                                                        "@Frame10Total, " +
                                                                        "@pins_knocked_down, " +
                                                                        "@GId) ", conn);
                                    cmdP.Parameters.AddWithValue("@PlayerName", row.Cells["PlayerName"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame1Box1", row.Cells["Frame1Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame1Box2", row.Cells["Frame1Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame1Total", row.Cells["Frame1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame2Box1", row.Cells["Frame2Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame2Box2", row.Cells["Frame2Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame2Total", row.Cells["Frame2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame3Box1", row.Cells["Frame3Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame3Box2", row.Cells["Frame3Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame3Total", row.Cells["Frame3"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame4Box1", row.Cells["Frame4Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame4Box2", row.Cells["Frame4Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame4Total", row.Cells["Frame4"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame5Box1", row.Cells["Frame5Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame5Box2", row.Cells["Frame5Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame5Total", row.Cells["Frame5"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame6Box1", row.Cells["Frame6Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame6Box2", row.Cells["Frame6Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame6Total", row.Cells["Frame6"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame7Box1", row.Cells["Frame7Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame7Box2", row.Cells["Frame7Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame7Total", row.Cells["Frame7"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame8Box1", row.Cells["Frame8Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame8Box2", row.Cells["Frame8Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame8Total", row.Cells["Frame8"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame9Box1", row.Cells["Frame9Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame9Box2", row.Cells["Frame9Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame9Total", row.Cells["Frame9"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame10Box1", row.Cells["Frame10Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame10Box2", row.Cells["Frame10Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame10Box3", row.Cells["Frame10Box3"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame10Total", row.Cells["Frame10"].Value);
                                    cmdP.Parameters.AddWithValue("@pins_knocked_down", GetValue(Convert.ToString(score)));
                                    cmdP.Parameters.AddWithValue("@GId", id);
                                    cmdP.Transaction = trans;
                                    cmdP.ExecuteNonQuery();
                                }

                                trans.Commit();

                                frmRecordLog f1 = (frmRecordLog)Application.OpenForms["frmRecordLog"];
                                f1.btnFilter.PerformClick();
                                f1.dgvGames.Rows[0].Selected = true;
                                MessageBox.Show("Score log successfully saved!", "Bowling Scoring Log",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                                trans.Rollback();
                            }
                        }
                    }
                }
                else if (saveMode == 1)
                {
                    using (SqlConnection conn = Database.DefSQLConnection())
                    {
                        using (trans = conn.BeginTransaction())
                        {
                            try
                            {
                                foreach (DataGridViewRow row in dgvScoringLog.Rows)
                                {
                                    DataTable dtScore = new DataTable();
                                    dtScore.Columns.AddRange(new DataColumn[] { new DataColumn("Value", typeof(Int32)) });
                                    dtScore.Rows.Clear();
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame1"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame2"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame3"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame4"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame5"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame6"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame7"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame8"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame9"].Value)));
                                    dtScore.Rows.Add(GetValue(Convert.ToString(row.Cells["Frame10"].Value)));
                                    score = Convert.ToInt32(dtScore.Compute("max([Value])", string.Empty));

                                    SqlCommand cmdP = new SqlCommand("update ScoreLog set " +
                                                                        "PlayerName = @PlayerName," +
                                                                        "Frame1Box1 = @Frame1Box1, " +
                                                                        "Frame1Box2 = @Frame1Box2, " +
                                                                        "Frame1Total = @Frame1Total, " +
                                                                        "Frame2Box1 = @Frame2Box1, " +
                                                                        "Frame2Box2 = @Frame2Box2, " +
                                                                        "Frame2Total = @Frame2Total, " +
                                                                        "Frame3Box1 = @Frame3Box1, " +
                                                                        "Frame3Box2 = @Frame3Box2, " +
                                                                        "Frame3Total = @Frame3Total, " +
                                                                        "Frame4Box1 = @Frame4Box1, " +
                                                                        "Frame4Box2 = @Frame4Box2, " +
                                                                        "Frame4Total = @Frame4Total, " +
                                                                        "Frame5Box1 = @Frame5Box1, " +
                                                                        "Frame5Box2 = @Frame5Box2, " +
                                                                        "Frame5Total = @Frame5Total, " +
                                                                        "Frame6Box1 = @Frame6Box1, " +
                                                                        "Frame6Box2 = @Frame6Box2, " +
                                                                        "Frame6Total = @Frame6Total, " +
                                                                        "Frame7Box1 = @Frame7Box1, " +
                                                                        "Frame7Box2 = @Frame7Box2, " +
                                                                        "Frame7Total = @Frame7Total, " +
                                                                        "Frame8Box1 = @Frame8Box1, " +
                                                                        "Frame8Box2 = @Frame8Box2, " +
                                                                        "Frame8Total = @Frame8Total, " +
                                                                        "Frame9Box1 = @Frame9Box1, " +
                                                                        "Frame9Box2 = @Frame9Box2, " +
                                                                        "Frame9Total = @Frame9Total, " +
                                                                        "Frame10Box1 = @Frame10Box1, " +
                                                                        "Frame10Box2 = @Frame10Box2, " +
                                                                        "Frame10Box3 = @Frame10Box3, " +
                                                                        "Frame10Total = @Frame10Total, " +
                                                                        "pins_knocked_down = @pins_knocked_down " +
                                                                    "where Id = @Id ", conn);
                                    cmdP.Parameters.AddWithValue("@PlayerName", row.Cells["PlayerName"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame1Box1", row.Cells["Frame1Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame1Box2", row.Cells["Frame1Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame1Total", row.Cells["Frame1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame2Box1", row.Cells["Frame2Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame2Box2", row.Cells["Frame2Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame2Total", row.Cells["Frame2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame3Box1", row.Cells["Frame3Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame3Box2", row.Cells["Frame3Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame3Total", row.Cells["Frame3"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame4Box1", row.Cells["Frame4Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame4Box2", row.Cells["Frame4Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame4Total", row.Cells["Frame4"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame5Box1", row.Cells["Frame5Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame5Box2", row.Cells["Frame5Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame5Total", row.Cells["Frame5"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame6Box1", row.Cells["Frame6Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame6Box2", row.Cells["Frame6Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame6Total", row.Cells["Frame6"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame7Box1", row.Cells["Frame7Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame7Box2", row.Cells["Frame7Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame7Total", row.Cells["Frame7"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame8Box1", row.Cells["Frame8Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame8Box2", row.Cells["Frame8Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame8Total", row.Cells["Frame8"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame9Box1", row.Cells["Frame9Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame9Box2", row.Cells["Frame9Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame9Total", row.Cells["Frame9"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame10Box1", row.Cells["Frame10Box1"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame10Box2", row.Cells["Frame10Box2"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame10Box3", row.Cells["Frame10Box3"].Value);
                                    cmdP.Parameters.AddWithValue("@Frame10Total", row.Cells["Frame10"].Value);
                                    cmdP.Parameters.AddWithValue("@pins_knocked_down", GetValue(Convert.ToString(score)));
                                    cmdP.Parameters.AddWithValue("@Id", row.Cells["Id"].Value);
                                    cmdP.Transaction = trans;
                                    cmdP.ExecuteNonQuery();
                                }

                                trans.Commit();

                                frmRecordLog f1 = (frmRecordLog)Application.OpenForms["frmRecordLog"];
                                f1.btnFilter.PerformClick();
                                MessageBox.Show("Score log successfully saved!", "Bowling Scoring Log",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                                trans.Rollback();
                            }
                        }
                    }
                }
            }
        }

        private void txtNoOfPlayers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
