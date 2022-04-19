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
    public partial class frmRecordLog : Form
    {
        public DataTable dt = new DataTable();
        public BindingSource bs = new BindingSource();

        SqlTransaction trans;

        public frmRecordLog()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void frmRecordLog_Load(object sender, EventArgs e)
        {
            InitGridViewForGames();
            InitGridViewForPlayers();
            LoadData();
            //this.DoubleBuffered = true;
        }

        private void InitGridViewForGames()
        {
            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn NameOfGame = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn NumberOfPlayers = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Remarks = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn SystemDate = new DataGridViewTextBoxColumn();

            using (DataGridViewTextBoxColumn c = Id)
            {
                c.Name = "Id";
                c.DataPropertyName = "Id";
                c.HeaderText = "Id";
                c.ValueType = typeof(System.Int32);
                c.Width = 90;
                c.ReadOnly = true;
                c.Visible = false;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = NameOfGame)
            {
                c.Name = "NameOfGame";
                c.DataPropertyName = "NameOfGame";
                c.HeaderText = "Name of Game";
                c.ValueType = typeof(System.String);
                c.Width = 200;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            using (DataGridViewTextBoxColumn c = NumberOfPlayers)
            {
                c.Name = "NumberOfPlayers";
                c.DataPropertyName = "NumberOfPlayers";
                c.HeaderText = "Number of Players";
                c.ValueType = typeof(System.String);
                c.Width = 65;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = Remarks)
            {
                c.Name = "Remarks";
                c.DataPropertyName = "Remarks";
                c.HeaderText = "Remarks";
                c.ValueType = typeof(System.String);
                //c.Width = 110;
                c.ReadOnly = true;
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = SystemDate)
            {
                c.Name = "SystemDate";
                c.DataPropertyName = "SystemDate";
                c.HeaderText = "System Date";
                c.ValueType = typeof(System.String);
                c.Width = 120;
                c.DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvGames.Columns.Clear();
            dgvGames.Columns.AddRange(
                new DataGridViewColumn[]{
                Id,
                NameOfGame,
                NumberOfPlayers,
                Remarks,
                SystemDate});

            dgvGames.ColumnHeadersHeight = 40;
            dgvGames.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGames.DefaultCellStyle.Font = new Font("Segoe UI", 7);

            pnlFunctionTab.Padding = new Padding(0, dgvGames.ColumnHeadersHeight, 0, 0);

            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id", typeof(Int32)),
                                                   new DataColumn("NameOfGame", typeof(string)),
                                                   new DataColumn("NumberOfPlayers", typeof(int)),
                                                   new DataColumn("Remarks", typeof(string)),
                                                   new DataColumn("SystemDate", typeof(DateTime))});

            cboSearchBy.Items.Clear();
            foreach (DataGridViewColumn c in dgvGames.Columns)
            {
                if (c.Visible == true)
                {
                    cboSearchBy.Items.Add(c.Name);
                }
            }
            cboSearchBy.SelectedIndex = 0;

            foreach (DataGridViewColumn col in dgvGames.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //bs.DataSource = dt;
            //dgvGames.DataSource = bs;
        }

        private void InitGridViewForPlayers()
        {
            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn PlayerName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Score = new DataGridViewTextBoxColumn();

            using (DataGridViewTextBoxColumn c = Id)
            {
                c.Name = "Id";
                c.DataPropertyName = "Id";
                c.HeaderText = "Id";
                c.ValueType = typeof(System.Int32);
                c.Width = 90;
                c.ReadOnly = true;
                c.Visible = false;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            using (DataGridViewTextBoxColumn c = PlayerName)
            {
                c.Name = "PlayerName";
                c.DataPropertyName = "PlayerName";
                c.HeaderText = "Player Name";
                c.ValueType = typeof(System.String);
                c.ReadOnly = true;
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            using (DataGridViewTextBoxColumn c = Score)
            {
                c.Name = "Score";
                c.DataPropertyName = "Score";
                c.HeaderText = "Score";
                c.ValueType = typeof(System.String);
                c.Width = 100;
                c.ReadOnly = true;
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvPlayers.Columns.Clear();
            dgvPlayers.Columns.AddRange(
                new DataGridViewColumn[]{
                Id,
                PlayerName,
                Score});

            dgvPlayers.ColumnHeadersHeight = 40;
            dgvPlayers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPlayers.DefaultCellStyle.Font = new Font("Segoe UI", 7);

            foreach (DataGridViewColumn col in dgvPlayers.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dgvGames_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvGames.Rows.Count == 0)
            {
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    if (this.dgvGames.Rows[rowSelected].Selected == true)
                    {
                        return;
                    }
                    this.dgvGames.Rows[rowSelected].Selected = true;
                    this.dgvGames.CurrentCell = this.dgvGames.Rows[rowSelected].Cells[2];
                }
            }
        }

        private void dgvGames_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvGames.Columns.Count > 0)
                {
                    int currentMouseOverRow = dgvGames.HitTest(e.X, e.Y).RowIndex;
                    cmsRecordLog.Show(dgvGames, new Point(e.X, e.Y));
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmScoringLogData f = new frmScoringLogData();
            f.saveMode = 0;
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                frmScoringLogData f = new frmScoringLogData();
                f.id = Convert.ToInt32(dgvGames.CurrentRow.Cells["Id"].Value);
                f.saveMode = 1;
                f.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this data?", "Bowling Score Log",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (SqlConnection conn = Database.DefSQLConnection())
                {
                    using (trans = conn.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmdG = new SqlCommand("delete from Games where Id = @Id", conn);
                            cmdG.Parameters.AddWithValue("@Id", dgvGames.CurrentRow.Cells["Id"].Value);
                            cmdG.Transaction = trans;
                            cmdG.ExecuteNonQuery();

                            SqlCommand cmdP = new SqlCommand("delete from ScoreLog where GId = @GId", conn);
                            cmdP.Parameters.AddWithValue("@GId", dgvGames.CurrentRow.Cells["Id"].Value);
                            cmdP.Transaction = trans;
                            cmdP.ExecuteNonQuery();

                            trans.Commit();

                            MessageBox.Show("Score log successfully deleted!", "Bowling Scoring Log",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            btnFilter.PerformClick();
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

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate.PerformClick();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPrintPreview.PerformClick();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                //dgvGames.Rows.Clear();
                dt.Rows.Clear();
                dgvPlayers.Rows.Clear();
                //dt.Rows.Clear();
                string dateFrom = dtpFrom.Text + " 12:00:00 AM";
                string dateTo = dtpTo.Text + " 11:59:59 PM";
                using (SqlConnection conn = Database.DefSQLConnection())
                {
                    SqlCommand cmd = new SqlCommand("select " +
                                                        "Id 'Id', " +
                                                        "NameOfGame 'NameOfGame', " +
                                                        "NumberOfPlayers 'NumberOfPlayers', " +
                                                        "Remarks 'Remarks', " +
                                                        "SystemDate 'SystemDate' " +
                                                    "from Games " +
                                                    "where SystemDate between @DateFrom and @DateTo " +
                                                    "order by Id asc", conn);
                    cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmd.Parameters.AddWithValue("@DateTo", dateTo);
                    //dt = Database.GetRecords(cmd);
                    //bs.DataSource = dt;
                    //dgvGames.DataSource = bs;
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            dt.Rows.Add(rdr["Id"],
                                        rdr["NameOfGame"],
                                        rdr["NumberOfPlayers"],
                                        rdr["Remarks"],
                                        rdr["SystemDate"]);
                        }
                        rdr.Close();
                        bs.DataSource = dt;
                        dgvGames.DataSource = bs;
                        dgvGames.Rows[0].Selected = true;
                        dgvGames_CellEnter(dgvGames, new DataGridViewCellEventArgs(0, 0));
                    }
                    //dt = Database.GetRecords(cmd);
                    //bs.DataSource = dt;
                    //dgvGames.DataSource = dt;
                    //dt.AcceptChanges();
                }
                txtSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSearchBy.Text) == true ||
                dgvGames.Rows.Count == 0)
            {

            }
            else
            {
                string SearchOption = "[" + cboSearchBy.Text + "]" + " like '%{0}%'";
                bs.Filter = string.Format(SearchOption, txtSearch.Text);
            }
        }

        private void dgvGames_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvGames.SelectedRows.Count > 0)
                {
                    dgvPlayers.Rows.Clear();
                    using (SqlConnection conn = Database.DefSQLConnection())
                    {
                        SqlCommand cmd = new SqlCommand("select " +
                                                            "Id 'Id', " +
                                                            "PlayerName 'PlayerName', " +
                                                            "pins_knocked_down 'Score' " +
                                                        "from ScoreLog " +
                                                        "where GId = @GId " +
                                                        "order by Score desc", conn);
                        cmd.Parameters.AddWithValue("@GId", dgvGames.CurrentRow.Cells["Id"].Value);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                dgvPlayers.Rows.Add(rdr["Id"],
                                                    rdr["PlayerName"],
                                                    rdr["Score"]);
                            }
                        }
                        rdr.Close();
                    }

                    if (dgvPlayers.Rows.Count > 0)
                    {
                        dgvPlayers.Rows[0].Cells["Score"].Style.BackColor = Color.SpringGreen;
                    }

                    dgvPlayers.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }
    }
}
