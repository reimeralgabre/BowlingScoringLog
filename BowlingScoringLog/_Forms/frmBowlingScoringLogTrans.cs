using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowlingScoringLog
{
    public partial class frmBowlingScoringLogTrans : Form
    {
        public int id;

        int frame1Box1Val;
        int frame1Box2Val;
        int frame1TotalVal;

        int frame2Box1Val;
        int frame2Box2Val;
        int frame2TotalVal;

        int frame3Box1Val;
        int frame3Box2Val;
        int frame3TotalVal;

        int frame4Box1Val;
        int frame4Box2Val;
        int frame4TotalVal;

        int frame5Box1Val;
        int frame5Box2Val;
        int frame5TotalVal;

        int frame6Box1Val;
        int frame6Box2Val;
        int frame6TotalVal;

        int frame7Box1Val;
        int frame7Box2Val;
        int frame7TotalVal;

        int frame8Box1Val;
        int frame8Box2Val;
        int frame8TotalVal;

        int frame9Box1Val;
        int frame9Box2Val;
        int frame9TotalVal;

        int frame10Box1Val;
        int frame10Box2Val;
        int frame10Box3Val;
        int frame10TotalVal;

        public frmBowlingScoringLogTrans()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            txtFrame1Box1.Focus();
        }

        private void frmBowlingScoringLogTrans_Load(object sender, EventArgs e)
        {
            GetScoreData();
        }

        private void GetScoreData()
        {
            frmScoringLogData f1 = (frmScoringLogData)Application.OpenForms["frmScoringLogData"];
            txtFrame1Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame1Box1"].Value);
            txtFrame1Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame1Box2"].Value);
            txtFrame2Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame2Box1"].Value);
            txtFrame2Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame2Box2"].Value);
            txtFrame3Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame3Box1"].Value);
            txtFrame3Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame3Box2"].Value);
            txtFrame4Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame4Box1"].Value);
            txtFrame4Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame4Box2"].Value);
            txtFrame5Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame5Box1"].Value);
            txtFrame5Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame5Box2"].Value);
            txtFrame6Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame6Box1"].Value);
            txtFrame6Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame6Box2"].Value);
            txtFrame7Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame7Box1"].Value);
            txtFrame7Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame7Box2"].Value);
            txtFrame8Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame8Box1"].Value);
            txtFrame8Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame8Box2"].Value);
            txtFrame9Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame9Box1"].Value);
            txtFrame9Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame9Box2"].Value);
            txtFrame10Box1.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame10Box1"].Value);
            txtFrame10Box2.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame10Box2"].Value);
            txtFrame10Box3.Text = Convert.ToString(f1.dgvScoringLog.CurrentRow.Cells["Frame10Box3"].Value);
        }

        private void ComputeScore()
        {
            frame1Box1Val = GetValue(txtFrame1Box1.Text);
            frame1Box2Val = GetValue(txtFrame1Box2.Text);
            frame1TotalVal = 0;

            frame2Box1Val = GetValue(txtFrame2Box1.Text);
            frame2Box2Val = GetValue(txtFrame2Box2.Text);
            frame2TotalVal = 0;

            frame3Box1Val = GetValue(txtFrame3Box1.Text);
            frame3Box2Val = GetValue(txtFrame3Box2.Text);
            frame3TotalVal = 0;

            frame4Box1Val = GetValue(txtFrame4Box1.Text);
            frame4Box2Val = GetValue(txtFrame4Box2.Text);
            frame4TotalVal = 0;

            frame5Box1Val = GetValue(txtFrame5Box1.Text);
            frame5Box2Val = GetValue(txtFrame5Box2.Text);
            frame5TotalVal = 0;

            frame6Box1Val = GetValue(txtFrame6Box1.Text);
            frame6Box2Val = GetValue(txtFrame6Box2.Text);
            frame6TotalVal = 0;

            frame7Box1Val = GetValue(txtFrame7Box1.Text);
            frame7Box2Val = GetValue(txtFrame7Box2.Text);
            frame7TotalVal = 0;

            frame8Box1Val = GetValue(txtFrame8Box1.Text);
            frame8Box2Val = GetValue(txtFrame8Box2.Text);
            frame8TotalVal = 0;

            frame9Box1Val = GetValue(txtFrame9Box1.Text);
            frame9Box2Val = GetValue(txtFrame9Box2.Text);
            frame9TotalVal = 0;

            frame10Box1Val = GetValue(txtFrame10Box1.Text);
            frame10Box2Val = GetValue(txtFrame10Box2.Text);
            frame10Box3Val = GetValue(txtFrame10Box3.Text);
            frame10TotalVal = 0;

            //Get Frame 1 Total Score
            if (txtFrame1Box1.Text == "X" || txtFrame1Box1.Text == "x")
            {
                frame1Box1Val = 10;
                if (txtFrame2Box1.Text == "X" || txtFrame2Box1.Text == "x")
                {
                    frame2Box1Val = 10;
                    if (txtFrame3Box1.Text == "X" || txtFrame3Box1.Text == "x")
                    {
                        frame3Box1Val = 10;

                        frame1TotalVal = frame1Box1Val + frame2Box1Val + frame3Box1Val;
                        lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
                    }
                    else if (frame3Box1Val > 0 && frame3Box1Val < 10)
                    {
                        frame1TotalVal = frame1Box1Val + frame2Box1Val + frame3Box1Val;
                        lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
                    }
                    else if (txtFrame3Box1.Text == "0")
                    {
                        frame1TotalVal = frame1Box1Val + frame2Box1Val + frame3Box1Val;
                        lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
                    }
                    else
                    {
                        lblFrame1Score.Text = "";
                    }
                }
                else if (txtFrame2Box1.Text == "0" && txtFrame2Box2.Text == "/")
                {
                    frame2Box2Val = 10 - frame2Box1Val;
                    frame1TotalVal = frame1Box1Val + frame2Box1Val + frame2Box2Val;
                    lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
                }
                else if (frame2Box1Val > 0 && txtFrame2Box2.Text == "/")
                {
                    frame2Box2Val = 10 - frame2Box1Val;
                    frame1TotalVal = frame1Box1Val + frame2Box1Val + frame2Box2Val;
                    lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
                }
                else if (txtFrame2Box1.Text == "0" && frame2Box2Val > 0)
                {
                    frame1TotalVal = frame1Box1Val + frame2Box1Val + frame2Box2Val;
                    lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
                }
                else if (frame2Box1Val > 0 && txtFrame2Box2.Text == "0")
                {
                    frame1TotalVal = frame1Box1Val + frame2Box1Val + frame2Box2Val;
                    lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
                }
                else if (frame2Box1Val > 0 && frame2Box2Val > 0)
                {
                    frame1TotalVal = frame1Box1Val + frame2Box1Val + frame2Box2Val;
                    lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
                }
                else if (txtFrame2Box1.Text == "0" && txtFrame2Box2.Text == "0")
                {
                    frame1TotalVal = frame1Box1Val + frame2Box1Val + frame2Box2Val;
                    lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
                }
                else
                {
                    lblFrame1Score.Text = "";
                }
            }
            else if (txtFrame1Box1.Text == "0" && txtFrame1Box2.Text == "0")
            {
                frame1TotalVal = 0;
                lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
            }
            else if (txtFrame1Box1.Text == "0" && txtFrame1Box2.Text == "/" && txtFrame2Box1.Text.Trim().Length > 0)
            {
                frame1Box2Val = 10;
                if (txtFrame2Box1.Text == "X" || txtFrame2Box1.Text == "x")
                {
                    frame2Box1Val = 10;
                }
                frame1TotalVal = frame1Box1Val + frame1Box2Val + frame2Box1Val;
                lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
            }
            else if (frame1Box1Val > 0 && txtFrame1Box2.Text == "/" && txtFrame2Box1.Text.Trim().Length > 0)
            {
                frame1Box2Val = 10 - frame1Box1Val;
                if (txtFrame2Box1.Text == "X" || txtFrame2Box1.Text == "x")
                {
                    frame2Box1Val = 10;
                }
                frame1TotalVal = frame1Box1Val + frame1Box2Val + frame2Box1Val;
                lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
            }
            else if (frame1Box1Val > 0 && frame1Box2Val > 0 && txtFrame1Box2.Text != "/")
            {
                frame1TotalVal = frame1Box1Val + frame1Box2Val;
                lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
            }
            else if (txtFrame1Box1.Text == "0" && frame1Box2Val > 0)
            {
                frame1TotalVal = frame1Box1Val + frame1Box2Val;
                lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
            }
            else if (frame1Box1Val > 0 && txtFrame1Box2.Text == "0")
            {
                frame1TotalVal = frame1Box1Val + frame1Box2Val;
                lblFrame1Score.Text = Convert.ToString(frame1TotalVal);
            }
            else
            {
                lblFrame1Score.Text = "";
            }

            //Get Frame 2 Total Score
            if (txtFrame2Box1.Text == "X" || txtFrame2Box1.Text == "x")
            {
                frame2Box1Val = 10;
                if (txtFrame3Box1.Text == "X" || txtFrame3Box1.Text == "x")
                {
                    frame3Box1Val = 10;
                    if (txtFrame4Box1.Text == "X" || txtFrame4Box1.Text == "x")
                    {
                        frame4Box1Val = 10;

                        frame2TotalVal = frame2Box1Val + frame3Box1Val + frame4Box1Val + frame1TotalVal;
                        lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
                    }
                    else if (frame4Box1Val > 0 && frame4Box1Val < 10)
                    {
                        frame2TotalVal = frame2Box1Val + frame3Box1Val + frame4Box1Val + frame1TotalVal;
                        lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
                    }
                    else if (txtFrame4Box1.Text == "0")
                    {
                        frame2TotalVal = frame2Box1Val + frame3Box1Val + frame4Box1Val + frame1TotalVal;
                        lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
                    }
                    else
                    {
                        lblFrame2Score.Text = "";
                    }
                }
                else if (txtFrame3Box1.Text == "0" && txtFrame3Box2.Text == "/")
                {
                    frame3Box2Val = 10 - frame3Box1Val;
                    frame2TotalVal = frame2Box1Val + frame3Box1Val + frame3Box2Val + frame1TotalVal;
                    lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
                }
                else if (frame3Box1Val > 0 && txtFrame3Box2.Text == "/")
                {
                    frame3Box2Val = 10 - frame3Box1Val;
                    frame2TotalVal = frame2Box1Val + frame3Box1Val + frame3Box2Val + frame1TotalVal;
                    lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
                }
                else if (txtFrame3Box1.Text == "0" && frame3Box2Val > 0)
                {
                    frame2TotalVal = frame2Box1Val + frame3Box1Val + frame3Box2Val + frame1TotalVal;
                    lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
                }
                else if (frame3Box1Val > 0 && txtFrame3Box2.Text == "0")
                {
                    frame2TotalVal = frame2Box1Val + frame3Box1Val + frame3Box2Val + frame1TotalVal;
                    lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
                }
                else if (frame3Box1Val > 0 && frame3Box2Val > 0)
                {
                    frame2TotalVal = frame2Box1Val + frame3Box1Val + frame3Box2Val + frame1TotalVal;
                    lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
                }
                else if (txtFrame3Box1.Text == "0" && txtFrame3Box2.Text == "0")
                {
                    frame2TotalVal = frame2Box1Val + frame3Box1Val + frame3Box2Val + frame1TotalVal;
                    lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
                }
                else
                {
                    lblFrame2Score.Text = "";
                }
            }
            else if (txtFrame2Box1.Text == "0" && txtFrame2Box2.Text == "0")
            {
                frame2TotalVal = 0 + frame1TotalVal;
                lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
            }
            else if (txtFrame2Box1.Text == "0" && txtFrame2Box2.Text == "/" && txtFrame3Box1.Text.Trim().Length > 0)
            {
                frame2Box2Val = 10;
                if (txtFrame3Box1.Text == "X" || txtFrame3Box1.Text == "x")
                {
                    frame3Box1Val = 10;
                }
                frame2TotalVal = frame2Box1Val + frame2Box2Val + frame3Box1Val + frame1TotalVal;
                lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
            }
            else if (frame2Box1Val > 0 && txtFrame2Box2.Text == "/" && txtFrame3Box1.Text.Trim().Length > 0)
            {
                frame2Box2Val = 10 - frame2Box1Val;
                if (txtFrame3Box1.Text == "X" || txtFrame3Box1.Text == "x")
                {
                    frame3Box1Val = 10;
                }
                frame2TotalVal = frame2Box1Val + frame2Box2Val + frame3Box1Val + frame1TotalVal;
                lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
            }
            else if (frame2Box1Val > 0 && frame2Box2Val > 0 && txtFrame2Box2.Text != "/")
            {
                frame2TotalVal = frame2Box1Val + frame2Box2Val + frame1TotalVal;
                lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
            }
            else if (txtFrame2Box1.Text == "0" && frame2Box2Val > 0)
            {
                frame2TotalVal = frame2Box1Val + frame2Box2Val + frame1TotalVal;
                lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
            }
            else if (frame2Box1Val > 0 && txtFrame2Box2.Text == "0")
            {
                frame2TotalVal = frame2Box1Val + frame2Box2Val + frame1TotalVal;
                lblFrame2Score.Text = Convert.ToString(frame2TotalVal);
            }
            else
            {
                lblFrame2Score.Text = "";
            }


            //Get Frame 3 Total Score
            if (txtFrame3Box1.Text == "X" || txtFrame3Box1.Text == "x")
            {
                frame3Box1Val = 10;
                if (txtFrame4Box1.Text == "X" || txtFrame4Box1.Text == "x")
                {
                    frame4Box1Val = 10;
                    if (txtFrame5Box1.Text == "X" || txtFrame5Box1.Text == "x")
                    {
                        frame5Box1Val = 10;

                        frame3TotalVal = frame3Box1Val + frame4Box1Val + frame5Box1Val + frame2TotalVal;
                        lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
                    }
                    else if (frame5Box1Val > 0 && frame5Box1Val < 10)
                    {
                        frame3TotalVal = frame3Box1Val + frame4Box1Val + frame5Box1Val + frame2TotalVal;
                        lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
                    }
                    else if (txtFrame5Box1.Text == "0")
                    {
                        frame3TotalVal = frame3Box1Val + frame4Box1Val + frame5Box1Val + frame2TotalVal;
                        lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
                    }
                    else
                    {
                        lblFrame3Score.Text = "";
                    }
                }
                else if (txtFrame4Box1.Text == "0" && txtFrame4Box2.Text == "/")
                {
                    frame4Box2Val = 10 - frame4Box1Val;
                    frame3TotalVal = frame3Box1Val + frame4Box1Val + frame4Box2Val + frame2TotalVal;
                    lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
                }
                else if (frame4Box1Val > 0 && txtFrame4Box2.Text == "/")
                {
                    frame4Box2Val = 10 - frame4Box1Val;
                    frame3TotalVal = frame3Box1Val + frame4Box1Val + frame4Box2Val + frame2TotalVal;
                    lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
                }
                else if (txtFrame4Box1.Text == "0" && frame4Box2Val > 0)
                {
                    frame3TotalVal = frame3Box1Val + frame4Box1Val + frame4Box2Val + frame2TotalVal;
                    lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
                }
                else if (frame4Box1Val > 0 && txtFrame4Box2.Text == "0")
                {
                    frame3TotalVal = frame3Box1Val + frame4Box1Val + frame4Box2Val + frame2TotalVal;
                    lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
                }
                else if (frame4Box1Val > 0 && frame4Box2Val > 0)
                {
                    frame3TotalVal = frame3Box1Val + frame4Box1Val + frame4Box2Val + frame2TotalVal;
                    lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
                }
                else if (txtFrame4Box1.Text == "0" && txtFrame4Box2.Text == "0")
                {
                    frame3TotalVal = frame3Box1Val + frame4Box1Val + frame4Box2Val + frame2TotalVal;
                    lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
                }
                else
                {
                    lblFrame3Score.Text = "";
                }
            }
            else if (txtFrame3Box1.Text == "0" && txtFrame3Box2.Text == "0")
            {
                frame3TotalVal = 0 + frame2TotalVal;
                lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
            }
            else if (txtFrame3Box1.Text == "0" && txtFrame3Box2.Text == "/" && txtFrame4Box1.Text.Trim().Length > 0)
            {
                frame3Box2Val = 10;
                if (txtFrame4Box1.Text == "X" || txtFrame4Box1.Text == "x")
                {
                    frame4Box1Val = 10;
                }
                frame3TotalVal = frame3Box1Val + frame3Box2Val + frame4Box1Val + frame2TotalVal;
                lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
            }

            else if (frame3Box1Val > 0 && txtFrame3Box2.Text == "/" && txtFrame4Box1.Text.Trim().Length > 0)
            {
                frame3Box2Val = 10 - frame3Box1Val;
                if (txtFrame4Box1.Text == "X" || txtFrame4Box1.Text == "x")
                {
                    frame4Box1Val = 10;
                }
                frame3TotalVal = frame3Box1Val + frame3Box2Val + frame4Box1Val + frame2TotalVal;
                lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
            }

            else if (frame3Box1Val > 0 && frame3Box2Val > 0 && txtFrame3Box2.Text != "/")
            {
                frame3TotalVal = frame3Box1Val + frame3Box2Val + frame2TotalVal;
                lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
            }
            else if (txtFrame3Box1.Text == "0" && frame3Box2Val > 0)
            {
                frame3TotalVal = frame3Box1Val + frame3Box2Val + frame2TotalVal;
                lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
            }
            else if (frame3Box1Val > 0 && txtFrame3Box2.Text == "0")
            {
                frame3TotalVal = frame3Box1Val + frame3Box2Val + frame2TotalVal;
                lblFrame3Score.Text = Convert.ToString(frame3TotalVal);
            }
            else
            {
                lblFrame3Score.Text = "";
            }

            //Get Frame 4 Total Score
            if (txtFrame4Box1.Text == "X" || txtFrame4Box1.Text == "x")
            {
                frame4Box1Val = 10;
                if (txtFrame5Box1.Text == "X" || txtFrame5Box1.Text == "x")
                {
                    frame5Box1Val = 10;
                    if (txtFrame6Box1.Text == "X" || txtFrame6Box1.Text == "x")
                    {
                        frame6Box1Val = 10;

                        frame4TotalVal = frame4Box1Val + frame5Box1Val + frame6Box1Val + frame3TotalVal;
                        lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
                    }
                    else if (frame6Box1Val > 0 && frame6Box1Val < 10)
                    {
                        frame4TotalVal = frame4Box1Val + frame5Box1Val + frame6Box1Val + frame3TotalVal;
                        lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
                    }
                    else if (txtFrame6Box1.Text == "0")
                    {
                        frame4TotalVal = frame4Box1Val + frame5Box1Val + frame6Box1Val + frame3TotalVal;
                        lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
                    }
                    else
                    {
                        lblFrame4Score.Text = "";
                    }
                }
                else if (txtFrame5Box1.Text == "0" && txtFrame5Box2.Text == "/")
                {
                    frame5Box2Val = 10 - frame5Box1Val;
                    frame4TotalVal = frame4Box1Val + frame5Box1Val + frame5Box2Val + frame3TotalVal;
                    lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
                }
                else if (frame5Box1Val > 0 && txtFrame5Box2.Text == "/")
                {
                    frame5Box2Val = 10 - frame5Box1Val;
                    frame4TotalVal = frame4Box1Val + frame5Box1Val + frame5Box2Val + frame3TotalVal;
                    lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
                }
                else if (txtFrame5Box1.Text == "0" && frame5Box2Val > 0)
                {
                    frame4TotalVal = frame4Box1Val + frame5Box1Val + frame5Box2Val + frame3TotalVal;
                    lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
                }
                else if (frame5Box1Val > 0 && txtFrame5Box2.Text == "0")
                {
                    frame4TotalVal = frame4Box1Val + frame5Box1Val + frame5Box2Val + frame3TotalVal;
                    lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
                }
                else if (frame5Box1Val > 0 && frame5Box2Val > 0)
                {
                    frame4TotalVal = frame4Box1Val + frame5Box1Val + frame5Box2Val + frame3TotalVal;
                    lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
                }
                else if (txtFrame5Box1.Text == "0" && txtFrame5Box2.Text == "0")
                {
                    frame4TotalVal = frame4Box1Val + frame5Box1Val + frame5Box2Val + frame3TotalVal;
                    lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
                }
                else
                {
                    lblFrame4Score.Text = "";
                }
            }
            else if (txtFrame4Box1.Text == "0" && txtFrame4Box2.Text == "0")
            {
                frame4TotalVal = 0 + frame3TotalVal;
                lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
            }
            else if (txtFrame4Box1.Text == "0" && txtFrame4Box2.Text == "/" && txtFrame5Box1.Text.Trim().Length > 0)
            {
                frame4Box2Val = 10;
                if (txtFrame5Box1.Text == "X" || txtFrame5Box1.Text == "x")
                {
                    frame5Box1Val = 10;
                }
                frame4TotalVal = frame4Box1Val + frame4Box2Val + frame5Box1Val + frame3TotalVal;
                lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
            }
            else if (frame4Box1Val > 0 && txtFrame4Box2.Text == "/" && txtFrame5Box1.Text.Trim().Length > 0)
            {
                frame4Box2Val = 10 - frame4Box1Val;
                if (txtFrame5Box1.Text == "X" || txtFrame5Box1.Text == "x")
                {
                    frame5Box1Val = 10;
                }
                frame4TotalVal = frame4Box1Val + frame4Box2Val + frame5Box1Val + frame3TotalVal;
                lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
            }
            else if (frame4Box1Val > 0 && frame4Box2Val > 0 && txtFrame4Box2.Text != "/")
            {
                frame4TotalVal = frame4Box1Val + frame4Box2Val + frame3TotalVal;
                lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
            }
            else if (txtFrame4Box1.Text == "0" && frame4Box2Val > 0)
            {
                frame4TotalVal = frame4Box1Val + frame4Box2Val + frame3TotalVal;
                lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
            }
            else if (frame4Box1Val > 0 && txtFrame4Box2.Text == "0")
            {
                frame4TotalVal = frame4Box1Val + frame4Box2Val + frame3TotalVal;
                lblFrame4Score.Text = Convert.ToString(frame4TotalVal);
            }
            else
            {
                lblFrame4Score.Text = "";
            }

            //Get Frame 5 Total Score
            if (txtFrame5Box1.Text == "X" || txtFrame5Box1.Text == "x")
            {
                frame5Box1Val = 10;
                if (txtFrame6Box1.Text == "X" || txtFrame6Box1.Text == "x")
                {
                    frame6Box1Val = 10;
                    if (txtFrame7Box1.Text == "X" || txtFrame7Box1.Text == "x")
                    {
                        frame7Box1Val = 10;

                        frame5TotalVal = frame5Box1Val + frame6Box1Val + frame7Box1Val + frame4TotalVal;
                        lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
                    }
                    else if (frame7Box1Val > 0 && frame7Box1Val < 10)
                    {
                        frame5TotalVal = frame5Box1Val + frame6Box1Val + frame7Box1Val + frame4TotalVal;
                        lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
                    }
                    else if (txtFrame7Box1.Text == "0")
                    {
                        frame5TotalVal = frame5Box1Val + frame6Box1Val + frame7Box1Val + frame4TotalVal;
                        lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
                    }
                    else
                    {
                        lblFrame5Score.Text = "";
                    }
                }
                else if (txtFrame6Box1.Text == "0" && txtFrame6Box2.Text == "/")
                {
                    frame6Box2Val = 10 - frame6Box1Val;
                    frame5TotalVal = frame5Box1Val + frame6Box1Val + frame6Box2Val + frame4TotalVal;
                    lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
                }
                else if (frame6Box1Val > 0 && txtFrame6Box2.Text == "/")
                {
                    frame6Box2Val = 10 - frame6Box1Val;
                    frame5TotalVal = frame5Box1Val + frame6Box1Val + frame6Box2Val + frame4TotalVal;
                    lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
                }
                else if (txtFrame6Box1.Text == "0" && frame6Box2Val > 0)
                {
                    frame5TotalVal = frame5Box1Val + frame6Box1Val + frame6Box2Val + frame4TotalVal;
                    lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
                }
                else if (frame6Box1Val > 0 && txtFrame6Box2.Text == "0")
                {
                    frame5TotalVal = frame5Box1Val + frame6Box1Val + frame6Box2Val + frame4TotalVal;
                    lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
                }
                else if (frame6Box1Val > 0 && frame6Box2Val > 0)
                {
                    frame5TotalVal = frame5Box1Val + frame6Box1Val + frame6Box2Val + frame4TotalVal;
                    lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
                }
                else if (txtFrame6Box1.Text == "0" && txtFrame6Box2.Text == "0")
                {
                    frame5TotalVal = frame5Box1Val + frame6Box1Val + frame6Box2Val + frame4TotalVal;
                    lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
                }
                else
                {
                    lblFrame5Score.Text = "";
                }
            }
            else if (txtFrame5Box1.Text == "0" && txtFrame5Box2.Text == "0")
            {
                frame5TotalVal = 0 + frame4TotalVal;
                lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
            }
            else if (txtFrame5Box1.Text == "0" && txtFrame5Box2.Text == "/" && txtFrame6Box1.Text.Trim().Length > 0)
            {
                frame5Box2Val = 10;
                if (txtFrame6Box1.Text == "X" || txtFrame6Box1.Text == "x")
                {
                    frame6Box1Val = 10;
                }
                frame5TotalVal = frame5Box1Val + frame5Box2Val + frame6Box1Val + frame4TotalVal;
                lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
            }
            else if (frame5Box1Val > 0 && txtFrame5Box2.Text == "/" && txtFrame6Box1.Text.Trim().Length > 0)
            {
                frame5Box2Val = 10 - frame5Box1Val;
                if (txtFrame6Box1.Text == "X" || txtFrame6Box1.Text == "x")
                {
                    frame6Box1Val = 10;
                }
                frame5TotalVal = frame5Box1Val + frame5Box2Val + frame6Box1Val + frame4TotalVal;
                lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
            }
            else if (frame5Box1Val > 0 && frame5Box2Val > 0 && txtFrame5Box2.Text != "/")
            {
                frame5TotalVal = frame5Box1Val + frame5Box2Val + frame4TotalVal;
                lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
            }
            else if (txtFrame5Box1.Text == "0" && frame5Box2Val > 0)
            {
                frame5TotalVal = frame5Box1Val + frame5Box2Val + frame4TotalVal;
                lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
            }
            else if (frame5Box1Val > 0 && txtFrame5Box2.Text == "0")
            {
                frame5TotalVal = frame5Box1Val + frame5Box2Val + frame4TotalVal;
                lblFrame5Score.Text = Convert.ToString(frame5TotalVal);
            }
            else
            {
                lblFrame5Score.Text = "";
            }

            //Get Frame 6 Total Score
            if (txtFrame6Box1.Text == "X" || txtFrame6Box1.Text == "x")
            {
                frame6Box1Val = 10;
                if (txtFrame7Box1.Text == "X" || txtFrame7Box1.Text == "x")
                {
                    frame7Box1Val = 10;
                    if (txtFrame8Box1.Text == "X" || txtFrame8Box1.Text == "x")
                    {
                        frame8Box1Val = 10;

                        frame6TotalVal = frame6Box1Val + frame7Box1Val + frame8Box1Val + frame5TotalVal;
                        lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
                    }
                    else if (frame8Box1Val > 0 && frame8Box1Val < 10)
                    {
                        frame6TotalVal = frame6Box1Val + frame7Box1Val + frame8Box1Val + frame5TotalVal;
                        lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
                    }
                    else if (txtFrame8Box1.Text == "0")
                    {
                        frame6TotalVal = frame6Box1Val + frame7Box1Val + frame8Box1Val + frame5TotalVal;
                        lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
                    }
                    else
                    {
                        lblFrame6Score.Text = "";
                    }
                }
                else if (txtFrame7Box1.Text == "0" && txtFrame7Box2.Text == "/")
                {
                    frame7Box2Val = 10 - frame7Box1Val;
                    frame6TotalVal = frame6Box1Val + frame7Box1Val + frame7Box2Val + frame5TotalVal;
                    lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
                }
                else if (frame7Box1Val > 0 && txtFrame7Box2.Text == "/")
                {
                    frame7Box2Val = 10 - frame7Box1Val;
                    frame6TotalVal = frame6Box1Val + frame7Box1Val + frame7Box2Val + frame5TotalVal;
                    lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
                }
                else if (txtFrame7Box1.Text == "0" && frame7Box2Val > 0)
                {
                    frame6TotalVal = frame6Box1Val + frame7Box1Val + frame7Box2Val + frame5TotalVal;
                    lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
                }
                else if (frame7Box1Val > 0 && txtFrame7Box2.Text == "0")
                {
                    frame6TotalVal = frame6Box1Val + frame7Box1Val + frame7Box2Val + frame5TotalVal;
                    lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
                }
                else if (frame7Box1Val > 0 && frame7Box2Val > 0)
                {
                    frame6TotalVal = frame6Box1Val + frame7Box1Val + frame7Box2Val + frame5TotalVal;
                    lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
                }
                else if (txtFrame7Box1.Text == "0" && txtFrame7Box2.Text == "0")
                {
                    frame6TotalVal = frame6Box1Val + frame7Box1Val + frame7Box2Val + frame5TotalVal;
                    lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
                }
                else
                {
                    lblFrame6Score.Text = "";
                }
            }
            else if (txtFrame6Box1.Text == "0" && txtFrame6Box2.Text == "0")
            {
                frame6TotalVal = 0 + frame5TotalVal;
                lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
            }
            else if (txtFrame6Box1.Text == "0" && txtFrame6Box2.Text == "/" && txtFrame7Box1.Text.Trim().Length > 0)
            {
                frame6Box2Val = 10;
                if (txtFrame7Box1.Text == "X" || txtFrame7Box1.Text == "x")
                {
                    frame7Box1Val = 10;
                }
                frame6TotalVal = frame6Box1Val + frame6Box2Val + frame7Box1Val + frame5TotalVal;
                lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
            }
            else if (frame6Box1Val > 0 && txtFrame6Box2.Text == "/" && txtFrame7Box1.Text.Trim().Length > 0)
            {
                frame6Box2Val = 10 - frame6Box1Val;
                if (txtFrame7Box1.Text == "X" || txtFrame7Box1.Text == "x")
                {
                    frame7Box1Val = 10;
                }
                frame6TotalVal = frame6Box1Val + frame6Box2Val + frame7Box1Val + frame5TotalVal;
                lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
            }
            else if (frame6Box1Val > 0 && frame6Box2Val > 0 && txtFrame6Box2.Text != "/")
            {
                frame6TotalVal = frame6Box1Val + frame6Box2Val + frame5TotalVal;
                lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
            }
            else if (txtFrame6Box1.Text == "0" && frame6Box2Val > 0)
            {
                frame6TotalVal = frame6Box1Val + frame6Box2Val + frame5TotalVal;
                lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
            }
            else if (frame6Box1Val > 0 && txtFrame6Box2.Text == "0")
            {
                frame6TotalVal = frame6Box1Val + frame6Box2Val + frame5TotalVal;
                lblFrame6Score.Text = Convert.ToString(frame6TotalVal);
            }
            else
            {
                lblFrame6Score.Text = "";
            }

            //Get Frame 7 Total Score
            if (txtFrame7Box1.Text == "X" || txtFrame7Box1.Text == "x")
            {
                frame7Box1Val = 10;
                if (txtFrame8Box1.Text == "X" || txtFrame8Box1.Text == "x")
                {
                    frame8Box1Val = 10;
                    if (txtFrame9Box1.Text == "X" || txtFrame9Box1.Text == "x")
                    {
                        frame9Box1Val = 10;

                        frame7TotalVal = frame7Box1Val + frame8Box1Val + frame9Box1Val + frame6TotalVal;
                        lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
                    }
                    else if (frame9Box1Val > 0 && frame9Box1Val < 10)
                    {
                        frame7TotalVal = frame7Box1Val + frame8Box1Val + frame9Box1Val + frame6TotalVal;
                        lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
                    }
                    else if (txtFrame9Box1.Text == "0")
                    {
                        frame7TotalVal = frame7Box1Val + frame8Box1Val + frame9Box1Val + frame6TotalVal;
                        lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
                    }
                    else
                    {
                        lblFrame7Score.Text = "";
                    }
                }
                else if (txtFrame8Box1.Text == "0" && txtFrame8Box2.Text == "/")
                {
                    frame8Box2Val = 10 - frame8Box1Val;
                    frame7TotalVal = frame7Box1Val + frame8Box1Val + frame8Box2Val + frame6TotalVal;
                    lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
                }
                else if (frame8Box1Val > 0 && txtFrame8Box2.Text == "/")
                {
                    frame8Box2Val = 10 - frame8Box1Val;
                    frame7TotalVal = frame7Box1Val + frame8Box1Val + frame8Box2Val + frame6TotalVal;
                    lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
                }
                else if (txtFrame8Box1.Text == "0" && frame8Box2Val > 0)
                {
                    frame7TotalVal = frame7Box1Val + frame8Box1Val + frame8Box2Val + frame6TotalVal;
                    lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
                }
                else if (frame8Box1Val > 0 && txtFrame8Box2.Text == "0")
                {
                    frame7TotalVal = frame7Box1Val + frame8Box1Val + frame8Box2Val + frame6TotalVal;
                    lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
                }
                else if (frame8Box1Val > 0 && frame8Box2Val > 0)
                {
                    frame7TotalVal = frame7Box1Val + frame8Box1Val + frame8Box2Val + frame6TotalVal;
                    lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
                }
                else if (txtFrame8Box1.Text == "0" && txtFrame8Box2.Text == "0")
                {
                    frame7TotalVal = frame7Box1Val + frame8Box1Val + frame8Box2Val + frame6TotalVal;
                    lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
                }
                else
                {
                    lblFrame7Score.Text = "";
                }
            }
            else if (txtFrame7Box1.Text == "0" && txtFrame7Box2.Text == "0")
            {
                frame7TotalVal = 0 + frame6TotalVal;
                lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
            }
            else if (txtFrame7Box1.Text == "0" && txtFrame7Box2.Text == "/" && txtFrame8Box1.Text.Trim().Length > 0)
            {
                frame7Box2Val = 10;
                if (txtFrame8Box1.Text == "X" || txtFrame8Box1.Text == "x")
                {
                    frame8Box1Val = 10;
                }
                frame7TotalVal = frame7Box1Val + frame7Box2Val + frame8Box1Val + frame6TotalVal;
                lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
            }
            else if (frame7Box1Val > 0 && txtFrame7Box2.Text == "/" && txtFrame8Box1.Text.Trim().Length > 0)
            {
                frame7Box2Val = 10 - frame7Box1Val;
                if (txtFrame8Box1.Text == "X" || txtFrame8Box1.Text == "x")
                {
                    frame8Box1Val = 10;
                }
                frame7TotalVal = frame7Box1Val + frame7Box2Val + frame8Box1Val + frame6TotalVal;
                lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
            }
            else if (frame7Box1Val > 0 && frame7Box2Val > 0 && txtFrame7Box2.Text != "/")
            {
                frame7TotalVal = frame7Box1Val + frame7Box2Val + frame6TotalVal;
                lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
            }
            else if (txtFrame7Box1.Text == "0" && frame7Box2Val > 0)
            {
                frame7TotalVal = frame7Box1Val + frame7Box2Val + frame6TotalVal;
                lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
            }
            else if (frame7Box1Val > 0 && txtFrame7Box2.Text == "0")
            {
                frame7TotalVal = frame7Box1Val + frame7Box2Val + frame6TotalVal;
                lblFrame7Score.Text = Convert.ToString(frame7TotalVal);
            }
            else
            {
                lblFrame7Score.Text = "";
            }

            //Get Frame 8 Total Score
            if (txtFrame8Box1.Text == "X" || txtFrame8Box1.Text == "x")
            {
                frame8Box1Val = 10;
                if (txtFrame9Box1.Text == "X" || txtFrame9Box1.Text == "x")
                {
                    frame9Box1Val = 10;
                    if (txtFrame10Box1.Text == "X" || txtFrame10Box1.Text == "x")
                    {
                        frame10Box1Val = 10;

                        frame8TotalVal = frame8Box1Val + frame9Box1Val + frame10Box1Val + frame7TotalVal;
                        lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
                    }
                    else if (frame10Box1Val > 0 && frame10Box1Val < 10)
                    {
                        frame8TotalVal = frame8Box1Val + frame9Box1Val + frame10Box1Val + frame7TotalVal;
                        lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
                    }
                    else if (txtFrame10Box1.Text == "0")
                    {
                        frame8TotalVal = frame8Box1Val + frame9Box1Val + frame10Box1Val + frame7TotalVal;
                        lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
                    }
                    else
                    {
                        lblFrame8Score.Text = "";
                    }
                }
                else if (txtFrame9Box1.Text == "0" && txtFrame9Box2.Text == "/")
                {
                    frame9Box2Val = 10 - frame9Box1Val;
                    frame8TotalVal = frame8Box1Val + frame9Box1Val + frame9Box2Val + frame7TotalVal;
                    lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
                }
                else if (frame9Box1Val > 0 && txtFrame9Box2.Text == "/")
                {
                    frame9Box2Val = 10 - frame9Box1Val;
                    frame8TotalVal = frame8Box1Val + frame9Box1Val + frame9Box2Val + frame7TotalVal;
                    lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
                }
                else if (txtFrame9Box1.Text == "0" && frame9Box2Val > 0)
                {
                    frame8TotalVal = frame8Box1Val + frame9Box1Val + frame9Box2Val + frame7TotalVal;
                    lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
                }
                else if (frame9Box1Val > 0 && txtFrame9Box2.Text == "0")
                {
                    frame8TotalVal = frame8Box1Val + frame9Box1Val + frame9Box2Val + frame7TotalVal;
                    lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
                }
                else if (frame9Box1Val > 0 && frame9Box2Val > 0)
                {
                    frame8TotalVal = frame8Box1Val + frame9Box1Val + frame9Box2Val + frame7TotalVal;
                    lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
                }
                else if (txtFrame9Box1.Text == "0" && txtFrame9Box2.Text == "0")
                {
                    frame8TotalVal = frame8Box1Val + frame9Box1Val + frame9Box2Val + frame7TotalVal;
                    lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
                }
                else
                {
                    lblFrame8Score.Text = "";
                }
            }
            else if (txtFrame8Box1.Text == "0" && txtFrame8Box2.Text == "0")
            {
                frame8TotalVal = 0 + frame7TotalVal;
                lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
            }
            else if (txtFrame8Box1.Text == "0" && txtFrame8Box2.Text == "/" && txtFrame9Box1.Text.Trim().Length > 0)
            {
                frame8Box2Val = 10;
                if (txtFrame9Box1.Text == "X" || txtFrame9Box1.Text == "x")
                {
                    frame9Box1Val = 10;
                }
                frame8TotalVal = frame8Box1Val + frame8Box2Val + frame9Box1Val + frame7TotalVal;
                lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
            }
            else if (frame8Box1Val > 0 && txtFrame8Box2.Text == "/" && txtFrame9Box1.Text.Trim().Length > 0)
            {
                frame8Box2Val = 10 - frame8Box1Val;
                if (txtFrame9Box1.Text == "X" || txtFrame9Box1.Text == "x")
                {
                    frame9Box1Val = 10;
                }
                frame8TotalVal = frame8Box1Val + frame8Box2Val + frame9Box1Val + frame7TotalVal;
                lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
            }
            else if (frame8Box1Val > 0 && frame8Box2Val > 0 && txtFrame8Box2.Text != "/")
            {
                frame8TotalVal = frame8Box1Val + frame8Box2Val + frame7TotalVal;
                lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
            }
            else if (txtFrame8Box1.Text == "0" && frame8Box2Val > 0)
            {
                frame8TotalVal = frame8Box1Val + frame8Box2Val + frame7TotalVal;
                lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
            }
            else if (frame8Box1Val > 0 && txtFrame8Box2.Text == "0")
            {
                frame8TotalVal = frame8Box1Val + frame8Box2Val + frame7TotalVal;
                lblFrame8Score.Text = Convert.ToString(frame8TotalVal);
            }
            else
            {
                lblFrame8Score.Text = "";
            }

            //Get Frame 9 Total Score
            if (txtFrame9Box1.Text == "X" || txtFrame9Box1.Text == "x")
            {
                frame9Box1Val = 10;
                if (txtFrame10Box1.Text == "X" || txtFrame10Box1.Text == "x")
                {
                    frame10Box1Val = 10;
                    if (txtFrame10Box2.Text == "X" || txtFrame10Box2.Text == "x")
                    {
                        frame10Box2Val = 10;

                        frame9TotalVal = frame9Box1Val + frame10Box1Val + frame10Box2Val + frame8TotalVal;
                        lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
                    }
                    else if (frame10Box2Val > 0 && frame10Box2Val < 10)
                    {
                        frame9TotalVal = frame9Box1Val + frame10Box1Val + frame10Box2Val + frame8TotalVal;
                        lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
                    }
                    else if (txtFrame10Box2.Text == "0")
                    {
                        frame9TotalVal = frame9Box1Val + frame10Box1Val + frame10Box2Val + frame8TotalVal;
                        lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
                    }
                    else
                    {
                        lblFrame9Score.Text = "";
                    }
                }
                else if (txtFrame10Box1.Text == "0" && txtFrame10Box2.Text == "/")
                {
                    frame10Box2Val = 10 - frame10Box1Val;
                    frame9TotalVal = frame9Box1Val + frame10Box1Val + frame10Box2Val + frame8TotalVal;
                    lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
                }
                else if (frame10Box1Val > 0 && txtFrame10Box2.Text == "/")
                {
                    frame10Box2Val = 10 - frame10Box1Val;
                    frame9TotalVal = frame9Box1Val + frame10Box1Val + frame10Box2Val + frame8TotalVal;
                    lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
                }
                else if (txtFrame10Box1.Text == "0" && frame10Box2Val > 0)
                {
                    frame9TotalVal = frame9Box1Val + frame10Box1Val + frame10Box2Val + frame8TotalVal;
                    lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
                }
                else if (frame10Box1Val > 0 && txtFrame10Box2.Text == "0")
                {
                    frame9TotalVal = frame9Box1Val + frame10Box1Val + frame10Box2Val + frame8TotalVal;
                    lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
                }
                else if (frame10Box1Val > 0 && frame10Box2Val > 0)
                {
                    frame9TotalVal = frame9Box1Val + frame10Box1Val + frame10Box2Val + frame8TotalVal;
                    lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
                }
                else if (txtFrame10Box1.Text == "0" && txtFrame10Box2.Text == "0")
                {
                    frame9TotalVal = frame9Box1Val + frame10Box1Val + frame10Box2Val + frame8TotalVal;
                    lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
                }
                else
                {
                    lblFrame9Score.Text = "";
                }
            }
            else if (txtFrame9Box1.Text == "0" && txtFrame9Box2.Text == "0")
            {
                frame9TotalVal = 0 + frame8TotalVal;
                lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
            }
            else if (txtFrame9Box1.Text == "0" && txtFrame9Box2.Text == "/" && txtFrame10Box1.Text.Trim().Length > 0)
            {
                frame9Box2Val = 10;
                if (txtFrame10Box1.Text == "X" || txtFrame10Box1.Text == "x")
                {
                    frame10Box1Val = 10;
                }
                frame9TotalVal = frame9Box1Val + frame9Box2Val + frame10Box1Val + frame8TotalVal;
                lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
            }
            else if (frame9Box1Val > 0 && txtFrame9Box2.Text == "/" && txtFrame10Box1.Text.Trim().Length > 0)
            {
                frame9Box2Val = 10 - frame9Box1Val;
                if (txtFrame10Box1.Text == "X" || txtFrame10Box1.Text == "x")
                {
                    frame10Box1Val = 10;
                }
                frame9TotalVal = frame9Box1Val + frame9Box2Val + frame10Box1Val + frame8TotalVal;
                lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
            }
            else if (frame9Box1Val > 0 && frame9Box2Val > 0 && txtFrame9Box2.Text != "/")
            {
                frame9TotalVal = frame9Box1Val + frame9Box2Val + frame8TotalVal;
                lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
            }
            else if (txtFrame9Box1.Text == "0" && frame9Box2Val > 0)
            {
                frame9TotalVal = frame9Box1Val + frame9Box2Val + frame8TotalVal;
                lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
            }
            else if (frame9Box1Val > 0 && txtFrame9Box2.Text == "0")
            {
                frame9TotalVal = frame9Box1Val + frame9Box2Val + frame8TotalVal;
                lblFrame9Score.Text = Convert.ToString(frame9TotalVal);
            }
            else
            {
                lblFrame9Score.Text = "";
            }

            //Get Frame 10 Total Score
            if (txtFrame10Box1.Text == "X" || txtFrame10Box1.Text == "x")
            {
                frame10Box1Val = 10;
                if (txtFrame10Box2.Text == "X" || txtFrame10Box2.Text == "x")
                {
                    frame10Box2Val = 10;
                    if (txtFrame10Box3.Text == "X" || txtFrame10Box3.Text == "x")
                    {
                        frame10Box3Val = 10;

                        frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                        lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                    }
                    else if (frame10Box3Val > 0 && frame10Box3Val < 10)
                    {
                        frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                        lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                    }
                    else if (txtFrame10Box3.Text == "0")
                    {
                        frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                        lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                    }
                    else
                    {
                        lblFrame10Score.Text = "";
                    }
                }
                else if (txtFrame10Box2.Text == "0" && txtFrame10Box3.Text == "/")
                {
                    frame10Box3Val = 10 - frame10Box2Val;
                    frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                    lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                }
                else if (frame10Box2Val > 0 && txtFrame10Box3.Text == "/")
                {
                    frame10Box3Val = 10 - frame10Box2Val;
                    frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                    lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                }
                else if (txtFrame10Box2.Text == "0" && frame10Box3Val > 0)
                {
                    frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                    lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                }
                else if (frame10Box2Val > 0 && txtFrame10Box3.Text == "0")
                {
                    frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                    lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                }
                else if (frame10Box2Val > 0 && frame10Box3Val > 0)
                {
                    frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                    lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                }
                else if (txtFrame10Box2.Text == "0" && txtFrame10Box3.Text == "0")
                {
                    frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                    lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                }
                else if (txtFrame10Box2.Text == "0" && txtFrame10Box3.Text == "0")
                {
                    frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                    lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
                }
                else
                {
                    lblFrame10Score.Text = "";
                }
            }
            else if (txtFrame10Box1.Text == "0" && txtFrame10Box2.Text == "0")
            {
                frame10TotalVal = 0 + frame9TotalVal;
                lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
            }
            else if (txtFrame10Box1.Text == "0" && txtFrame10Box2.Text == "/" && txtFrame10Box3.Text.Trim().Length > 0)
            {
                frame10Box2Val = 10;
                if (txtFrame10Box2.Text == "X" || txtFrame10Box2.Text == "x")
                {
                    frame10Box3Val = 10;
                }
                frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
            }
            else if (frame10Box1Val > 0 && txtFrame10Box2.Text == "/" && txtFrame10Box3.Text.Trim().Length > 0)
            {
                frame10Box2Val = 10 - frame10Box1Val;
                if (txtFrame10Box3.Text == "X" || txtFrame10Box3.Text == "x")
                {
                    frame10Box3Val = 10;
                }
                frame10TotalVal = frame10Box1Val + frame10Box2Val + frame10Box3Val + frame9TotalVal;
                lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
            }
            else if (frame10Box1Val > 0 && frame10Box2Val > 0 && txtFrame10Box2.Text != "/")
            {
                frame10TotalVal = frame10Box1Val + frame10Box2Val + frame9TotalVal;
                lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
            }
            else if (txtFrame10Box1.Text == "0" && frame10Box2Val > 0)
            {
                frame10TotalVal = frame10Box1Val + frame10Box2Val + frame9TotalVal;
                lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
            }
            else if (frame10Box1Val > 0 && txtFrame10Box2.Text == "0")
            {
                frame10TotalVal = frame10Box1Val + frame10Box2Val + frame9TotalVal;
                lblFrame10Score.Text = Convert.ToString(frame10TotalVal);
            }
            else
            {
                lblFrame10Score.Text = "";
            }
        }

        private void txtFrame1Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame1Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame2Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame2Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame3Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame3Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame4Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame4Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame5Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame5Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame6Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame6Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame7Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame7Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame8Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame8Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame9Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame9Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame10Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame10Box1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame1Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame1Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame2Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame2Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame3Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame3Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame4Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame4Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame5Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame5Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame6Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame6Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame7Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame7Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame8Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame8Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame9Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame9Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame10Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame10Box2.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtFrame10Box3_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFrame10Box3.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 88) && (e.KeyChar != 'x') && (e.KeyChar != '/'))
            {
                e.Handled = true;
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

        private void btnCompute_Click(object sender, EventArgs e)
        {
            ComputeScore();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }
        private void ResetData()
        {
            txtFrame1Box1.Clear();
            txtFrame1Box1.Focus();
        }

        private void txtFrame1Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame1Box1.Text == "X" ||
                txtFrame1Box1.Text == "x")
            {
                txtFrame1Box2.Clear();
                txtFrame1Box2.ReadOnly = true;

                txtFrame2Box1.ReadOnly = false;

                txtFrame2Box1.Focus();
            }
            else if (txtFrame1Box1.Text.Trim().Length == 0)
            {
                txtFrame1Box2.Clear();
                txtFrame1Box2.ReadOnly = true;

                txtFrame2Box1.Clear();
                txtFrame2Box1.ReadOnly = true;
            }
            else
            {
                txtFrame1Box2.ReadOnly = false;
                txtFrame1Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame2Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame2Box1.Text == "X" ||
                txtFrame2Box1.Text == "x")
            {
                txtFrame2Box2.Clear();
                txtFrame2Box2.ReadOnly = true;

                txtFrame3Box1.ReadOnly = false;
                txtFrame3Box1.Focus();
            }
            else if (txtFrame2Box1.Text.Trim().Length == 0)
            {
                txtFrame2Box2.Clear();
                txtFrame2Box2.ReadOnly = true;

                txtFrame3Box1.Clear();
                txtFrame3Box1.ReadOnly = true;
            }
            else
            {
                txtFrame2Box2.ReadOnly = false;
                txtFrame2Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame3Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame3Box1.Text == "X" ||
                txtFrame3Box1.Text == "x")
            {
                txtFrame3Box2.Clear();
                txtFrame3Box2.ReadOnly = true;

                txtFrame4Box1.ReadOnly = false;
                txtFrame4Box1.Focus();
            }
            else if (txtFrame3Box1.Text.Trim().Length == 0)
            {
                txtFrame3Box2.Clear();
                txtFrame3Box2.ReadOnly = true;

                txtFrame4Box1.Clear();
                txtFrame4Box1.ReadOnly = true;
            }
            else
            {
                txtFrame3Box2.ReadOnly = false;
                txtFrame3Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame4Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame4Box1.Text == "X" ||
                txtFrame4Box1.Text == "x")
            {
                txtFrame4Box2.Clear();
                txtFrame4Box2.ReadOnly = true;

                txtFrame5Box1.ReadOnly = false;
                txtFrame5Box1.Focus();
            }
            else if (txtFrame4Box1.Text.Trim().Length == 0)
            {
                txtFrame4Box2.Clear();
                txtFrame4Box2.ReadOnly = true;

                txtFrame5Box1.Clear();
                txtFrame5Box1.ReadOnly = true;
            }
            else
            {
                txtFrame4Box2.ReadOnly = false;
                txtFrame4Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame5Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame5Box1.Text == "X" ||
                txtFrame5Box1.Text == "x")
            {
                txtFrame5Box2.Clear();
                txtFrame5Box2.ReadOnly = true;

                txtFrame6Box1.ReadOnly = false;
                txtFrame6Box1.Focus();
            }
            else if (txtFrame5Box1.Text.Trim().Length == 0)
            {
                txtFrame5Box2.Clear();
                txtFrame5Box2.ReadOnly = true;

                txtFrame6Box1.Clear();
                txtFrame6Box1.ReadOnly = true;
            }
            else
            {
                txtFrame5Box2.ReadOnly = false;
                txtFrame5Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame6Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame6Box1.Text == "X" ||
                txtFrame6Box1.Text == "x")
            {
                txtFrame6Box2.Clear();
                txtFrame6Box2.ReadOnly = true;

                txtFrame7Box1.ReadOnly = false;
                txtFrame7Box1.Focus();
            }
            else if (txtFrame6Box1.Text.Trim().Length == 0)
            {
                txtFrame6Box2.Clear();
                txtFrame6Box2.ReadOnly = true;

                txtFrame7Box1.Clear();
                txtFrame7Box1.ReadOnly = true;
            }
            else
            {
                txtFrame6Box2.ReadOnly = false;
                txtFrame6Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame7Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame7Box1.Text == "X" ||
                txtFrame7Box1.Text == "x")
            {
                txtFrame7Box2.Clear();
                txtFrame7Box2.ReadOnly = true;

                txtFrame8Box1.ReadOnly = false;
                txtFrame8Box1.Focus();
            }
            else if (txtFrame7Box1.Text.Trim().Length == 0)
            {
                txtFrame7Box2.Clear();
                txtFrame7Box2.ReadOnly = true;

                txtFrame8Box1.Clear();
                txtFrame8Box1.ReadOnly = true;
            }
            else
            {
                txtFrame7Box2.ReadOnly = false;
                txtFrame7Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame8Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame8Box1.Text == "X" ||
                txtFrame8Box1.Text == "x")
            {
                txtFrame8Box2.Clear();
                txtFrame8Box2.ReadOnly = true;

                txtFrame9Box1.ReadOnly = false;
                txtFrame9Box1.Focus();
            }
            else if (txtFrame8Box1.Text.Trim().Length == 0)
            {
                txtFrame8Box2.Clear();
                txtFrame8Box2.ReadOnly = true;

                txtFrame9Box1.Clear();
                txtFrame9Box1.ReadOnly = true;
            }
            else
            {
                txtFrame8Box2.ReadOnly = false;
                txtFrame8Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame9Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame9Box1.Text == "X" ||
                txtFrame9Box1.Text == "x")
            {
                txtFrame9Box2.Clear();
                txtFrame9Box2.ReadOnly = true;

                txtFrame10Box1.ReadOnly = false;
                txtFrame10Box1.Focus();
            }
            else if (txtFrame9Box1.Text.Trim().Length == 0)
            {
                txtFrame9Box2.Clear();
                txtFrame9Box2.ReadOnly = true;

                txtFrame10Box1.Clear();
                txtFrame10Box1.ReadOnly = true;
            }
            else
            {
                txtFrame9Box2.ReadOnly = false;
                txtFrame9Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame1Box2_TextChanged(object sender, EventArgs e)
        {
            if ((GetValue(txtFrame1Box1.Text) + GetValue(txtFrame1Box2.Text)) >= 10)
            {
                txtFrame1Box2.Text = "/";
            }

            if (txtFrame1Box1.Text == "X" ||
                txtFrame1Box1.Text == "x")
            {

            }
            else if (txtFrame1Box2.Text.Trim().Length == 0)
            {
                txtFrame2Box1.Clear();
                txtFrame2Box1.ReadOnly = true;
            }
            else
            {
                txtFrame2Box1.ReadOnly = false;
                txtFrame2Box1.Focus();
            }
            ComputeScore();
        }

        private void txtFrame2Box2_TextChanged(object sender, EventArgs e)
        {
            if ((GetValue(txtFrame2Box1.Text) + GetValue(txtFrame2Box2.Text)) >= 10)
            {
                txtFrame2Box2.Text = "/";
            }

            if (txtFrame2Box1.Text == "X" ||
                txtFrame2Box1.Text == "x")
            {

            }
            else if (txtFrame2Box2.Text.Trim().Length == 0)
            {
                txtFrame3Box1.Clear();
                txtFrame3Box1.ReadOnly = true;
            }
            else
            {
                txtFrame3Box1.ReadOnly = false;
                txtFrame3Box1.Focus();
            }
            ComputeScore();
        }

        private void txtFrame3Box2_TextChanged(object sender, EventArgs e)
        {
            if ((GetValue(txtFrame3Box1.Text) + GetValue(txtFrame3Box2.Text)) >= 10)
            {
                txtFrame3Box2.Text = "/";
            }

            if (txtFrame3Box1.Text == "X" ||
                txtFrame3Box1.Text == "x")
            {

            }
            else if (txtFrame3Box2.Text.Trim().Length == 0)
            {
                txtFrame4Box1.Clear();
                txtFrame4Box1.ReadOnly = true;
            }
            else
            {
                txtFrame4Box1.ReadOnly = false;
                txtFrame4Box1.Focus();
            }
            ComputeScore();
        }

        private void txtFrame4Box2_TextChanged(object sender, EventArgs e)
        {
            if ((GetValue(txtFrame4Box1.Text) + GetValue(txtFrame4Box2.Text)) >= 10)
            {
                txtFrame4Box2.Text = "/";
            }

            if (txtFrame4Box1.Text == "X" ||
                txtFrame4Box1.Text == "x")
            {

            }
            else if (txtFrame4Box2.Text.Trim().Length == 0)
            {
                txtFrame5Box1.Clear();
                txtFrame5Box1.ReadOnly = true;
            }
            else
            {
                txtFrame5Box1.ReadOnly = false;
                txtFrame5Box1.Focus();
            }
            ComputeScore();
        }

        private void txtFrame5Box2_TextChanged(object sender, EventArgs e)
        {
            if ((GetValue(txtFrame5Box1.Text) + GetValue(txtFrame5Box2.Text)) >= 10)
            {
                txtFrame5Box2.Text = "/";
            }

            if (txtFrame5Box1.Text == "X" ||
                txtFrame5Box1.Text == "x")
            {

            }
            else if (txtFrame5Box2.Text.Trim().Length == 0)
            {
                txtFrame6Box1.Clear();
                txtFrame6Box1.ReadOnly = true;
            }
            else
            {
                txtFrame6Box1.ReadOnly = false;
                txtFrame6Box1.Focus();
            }
            ComputeScore();
        }

        private void txtFrame6Box2_TextChanged(object sender, EventArgs e)
        {
            if ((GetValue(txtFrame6Box1.Text) + GetValue(txtFrame6Box2.Text)) >= 10)
            {
                txtFrame6Box2.Text = "/";
            }

            if (txtFrame6Box1.Text == "X" ||
                txtFrame6Box1.Text == "x")
            {

            }
            else if (txtFrame6Box2.Text.Trim().Length == 0)
            {
                txtFrame7Box1.Clear();
                txtFrame7Box1.ReadOnly = true;
            }
            else
            {
                txtFrame7Box1.ReadOnly = false;
                txtFrame7Box1.Focus();
            }
            ComputeScore();
        }

        private void txtFrame7Box2_TextChanged(object sender, EventArgs e)
        {
            if ((GetValue(txtFrame7Box1.Text) + GetValue(txtFrame7Box2.Text)) >= 10)
            {
                txtFrame7Box2.Text = "/";
            }

            if (txtFrame7Box1.Text == "X" ||
                txtFrame7Box1.Text == "x")
            {

            }
            else if (txtFrame7Box2.Text.Trim().Length == 0)
            {
                txtFrame8Box1.Clear();
                txtFrame8Box1.ReadOnly = true;
            }
            else
            {
                txtFrame8Box1.ReadOnly = false;
                txtFrame8Box1.Focus();
            }
            ComputeScore();
        }

        private void txtFrame8Box2_TextChanged(object sender, EventArgs e)
        {
            if ((GetValue(txtFrame8Box1.Text) + GetValue(txtFrame8Box2.Text)) >= 10)
            {
                txtFrame8Box2.Text = "/";
            }

            if (txtFrame8Box1.Text == "X" ||
                txtFrame8Box1.Text == "x")
            {

            }
            else if (txtFrame8Box2.Text.Trim().Length == 0)
            {
                txtFrame9Box1.Clear();
                txtFrame9Box1.ReadOnly = true;
            }
            else
            {
                txtFrame9Box1.ReadOnly = false;
                txtFrame9Box1.Focus();
            }
            ComputeScore();
        }

        private void txtFrame9Box2_TextChanged(object sender, EventArgs e)
        {
            if ((GetValue(txtFrame9Box1.Text) + GetValue(txtFrame9Box2.Text)) >= 10)
            {
                txtFrame9Box2.Text = "/";
            }

            if (txtFrame9Box1.Text == "X" ||
                txtFrame9Box1.Text == "x")
            {

            }
            else if (txtFrame9Box2.Text.Trim().Length == 0)
            {
                txtFrame10Box1.Clear();
                txtFrame10Box1.ReadOnly = true;
            }
            else
            {
                txtFrame10Box1.ReadOnly = false;
                txtFrame10Box1.Focus();
            }
            ComputeScore();
        }

        private void txtFrame10Box1_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame10Box1.Text.Trim().Length == 0)
            {
                txtFrame10Box2.Clear();
                txtFrame10Box2.ReadOnly = true;
            }
            else if (txtFrame10Box1.Text == "X" ||
                     txtFrame10Box1.Text == "x")
            {
                txtFrame10Box2.ReadOnly = false;
                txtFrame10Box2.Focus();
                //txtFrame10Box3.ReadOnly = false;
            }
            else if (GetValue(txtFrame10Box1.Text) > 0)
            {
                txtFrame10Box2.ReadOnly = false;
                txtFrame10Box2.Focus();
            }
            else if (txtFrame10Box1.Text == "0")
            {
                txtFrame10Box2.ReadOnly = false;
                txtFrame10Box2.Focus();
            }
            ComputeScore();
        }

        private void txtFrame10Box2_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame10Box1.Text == "X" ||
                txtFrame10Box1.Text == "x")
            {
                if (txtFrame10Box2.Text == "/")
                {
                    txtFrame10Box2.Text = "X";
                    txtFrame10Box3.ReadOnly = false;
                    txtFrame10Box3.Focus();
                }
            }
            else if (txtFrame10Box2.Text == "X" ||
                     txtFrame10Box2.Text == "x")
            {
                if (txtFrame10Box1.Text.Trim().Length > 0 && GetValue(txtFrame10Box1.Text) > 0)
                {
                    txtFrame10Box2.Text = "/";
                }
            }

            if (GetValue(txtFrame10Box1.Text) + GetValue(txtFrame10Box2.Text) >= 10)
            {
                txtFrame10Box2.Text = "/";
                txtFrame10Box3.ReadOnly = false;
                txtFrame10Box3.Focus();
            }

            if (txtFrame10Box2.Text == "X" ||
                txtFrame10Box2.Text == "x" ||
                txtFrame10Box2.Text == "/")
            {
                txtFrame10Box3.ReadOnly = false;
                txtFrame10Box3.Focus();
            }
            else if (GetValue(txtFrame10Box1.Text) > 0 &&
                     txtFrame10Box2.Text == "/")
            {
                txtFrame10Box3.ReadOnly = false;
                txtFrame10Box3.Focus();
            }
            else if (txtFrame10Box2.Text.Trim().Length == 0)
            {
                txtFrame10Box3.Clear();
                txtFrame10Box3.ReadOnly = true;
            }
            else if ((GetValue(txtFrame10Box1.Text) + GetValue(txtFrame10Box2.Text)) < 10)
            {
                if (txtFrame10Box1.Text == "X" ||
                    txtFrame10Box1.Text == "x")
                {
                    if (txtFrame10Box2.Text.Trim().Length > 0)
                    {
                        txtFrame10Box3.ReadOnly = false;
                        txtFrame10Box3.Focus();
                    }
                }
                else
                {
                    txtFrame10Box3.Clear();
                    txtFrame10Box3.ReadOnly = true;
                }
            }
            ComputeScore();
        }

        private void txtFrame10Box3_TextChanged(object sender, EventArgs e)
        {
            if (txtFrame10Box2.Text == "X" ||
                txtFrame10Box2.Text == "x")
            {
                if (txtFrame10Box3.Text == "/")
                {
                    txtFrame10Box3.Text = "X";
                }
            }

            if (txtFrame10Box2.Text == "/")
            {
                if (txtFrame10Box3.Text == "/")
                {
                    txtFrame10Box3.Text = "X";
                }
            }
            ComputeScore();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            frmFAQ f = new frmFAQ();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmScoringLogData f1 = (frmScoringLogData)Application.OpenForms["frmScoringLogData"];
                f1.dgvScoringLog.CurrentRow.Cells["Frame1Box1"].Value = txtFrame1Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame1Box2"].Value = txtFrame1Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame1"].Value = lblFrame1Score.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame2Box1"].Value = txtFrame2Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame2Box2"].Value = txtFrame2Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame2"].Value = lblFrame2Score.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame3Box1"].Value = txtFrame3Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame3Box2"].Value = txtFrame3Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame3"].Value = lblFrame3Score.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame4Box1"].Value = txtFrame4Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame4Box2"].Value = txtFrame4Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame4"].Value = lblFrame4Score.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame5Box1"].Value = txtFrame5Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame5Box2"].Value = txtFrame5Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame5"].Value = lblFrame5Score.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame6Box1"].Value = txtFrame6Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame6Box2"].Value = txtFrame6Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame6"].Value = lblFrame6Score.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame7Box1"].Value = txtFrame7Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame7Box2"].Value = txtFrame7Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame7"].Value = lblFrame7Score.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame8Box1"].Value = txtFrame8Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame8Box2"].Value = txtFrame8Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame8"].Value = lblFrame8Score.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame9Box1"].Value = txtFrame9Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame9Box2"].Value = txtFrame9Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame9"].Value = lblFrame9Score.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame10Box1"].Value = txtFrame10Box1.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame10Box2"].Value = txtFrame10Box2.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame10Box3"].Value = txtFrame10Box3.Text;
                f1.dgvScoringLog.CurrentRow.Cells["Frame10"].Value = lblFrame10Score.Text;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
