using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Lift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /* Judge Vote */

        private void buttonJudgeVote_Click(object sender, EventArgs e)
        {
            int floor = 7;
            int labelnumber = int.Parse(lblJudgeVote.Text.Trim());
            float n = (float.Parse(txtJudgeVote.Text.Trim()) / float.Parse(toolStriptxtbxJudge.Text.Trim())) / 2;
            float count = float.Parse(lblJudgeVote.Text.Trim());

            if (n <= 5 && n >= 0)
            {
                if (n > labelnumber)                /* Graph Up */
                {
                    for (int i = ((floor - labelnumber) * 50); i >= ((floor - n + 1) * 50) - 49; i--)
                    {
                        pnlJudge.Location = new Point(116, i);

                        if (i % 50 == 0)
                        {
                            count++;
                            //lblJudgeVote.Text = count.ToString();
                        }

                        Thread.Sleep(15);
                        Application.DoEvents();
                    }
                }
                else if (n < labelnumber)           /* Graph Down */
                {
                    for (int i = ((floor - labelnumber) * 50); i <= ((floor - n) * 50); i++)
                    {
                        pnlJudge.Location = new Point(116, i);

                        if (i % 50 == 0)
                        {
                            count--;
                            //lblJudgeVote.Text = count.ToString();
                        }

                        Thread.Sleep(15);
                        Application.DoEvents();
                    }
                    //lblJudgeVote.Text = n.ToString();
                }


                lblJudgeVote.Text = Math.Round(((float.Parse(txtJudgeVote.Text.Trim()) / float.Parse(toolStriptxtbxJudge.Text.Trim())) / 2),2).ToString();
            }
            else
            {
                MessageBox.Show("Out of Reach !", "Warning");
            }
        }



        /* Audience Vote */

        private void buttonAudienceVote_Click(object sender, EventArgs e)
        {
            int floor = 7;
            int labelnumber = int.Parse(lblAudienceVote.Text.Trim());
            float n = float.Parse(txtAudienceVote.Text.Trim()) / 20;
            int count = int.Parse(lblAudienceVote.Text.Trim());

            if (n <= 5 && n >= 0)
            {
                if (n > labelnumber)                /* Graph Up */
                {
                    for (int i = ((floor - labelnumber) * 50); i >= ((floor - n + 1) * 50) - 49; i--)
                    {
                        pnlAudience.Location = new Point(116, i);

                        if (i % 50 == 0)
                        {
                            count++;
                            //lblAudienceVote.Text = count.ToString();
                        }

                        Thread.Sleep(15);
                        Application.DoEvents();
                    }
                }
                else if (n < labelnumber)           /* Graph Down */
                {
                    for (int i = ((floor - labelnumber) * 50); i <= ((floor - n) * 50); i++)
                    {
                        pnlAudience.Location = new Point(116, i);

                        if (i % 50 == 0)
                        {
                            count--;
                            //lblAudienceVote.Text = count.ToString();
                        }

                        Thread.Sleep(15);
                        Application.DoEvents();
                    }
                    //lblAudienceVote.Text = n.ToString();
                }


                lblAudienceVote.Text = Math.Round(((float.Parse(txtAudienceVote.Text.Trim())) / 20), 2).ToString();
            }
            else
            {
                MessageBox.Show("Out of Reach !", "Warning");
            }
        }



        /* Total Vote */

        private void buttonTotalVote_Click(object sender, EventArgs e)
        {
            int floor = 7;
            int labelnumber = int.Parse(lblTotalVote.Text.Trim());
            float n = (float.Parse(lblJudgeVote.Text.Trim()) + float.Parse(lblAudienceVote.Text.Trim())) / 2;
            int count = int.Parse(lblTotalVote.Text.Trim());

            if (n <= 5 && n >= 0)
            {
                if (n > labelnumber)                /* Graph Up */
                {
                    for (int i = ((floor - labelnumber) * 50); i >= ((floor - n + 1) * 50) - 49; i--)
                    {
                        pnlTotal.Location = new Point(116, i);

                        if (i % 50 == 0)
                        {
                            count++;
                            //lblTotalVote.Text = count.ToString();
                        }

                        Thread.Sleep(15);
                        Application.DoEvents();
                    }
                }
                else if (n < labelnumber)           /* Graph Down */
                {
                    for (int i = ((floor - labelnumber) * 50); i <= ((floor - n) * 50); i++)
                    {
                        pnlTotal.Location = new Point(116, i);

                        if (i % 50 == 0)
                        {
                            count--;
                            //lblTotalVote.Text = count.ToString();
                        }

                        Thread.Sleep(15);
                        Application.DoEvents();
                    }
                }



                //lblTotalVote.Text = Math.Round((float.Parse(lblJudgeVote.Text.Trim()) + float.Parse(lblAudienceVote.Text.Trim()) / 2), 2).ToString();
                lblTotalVote.Text = Math.Round((((float.Parse(txtJudgeVote.Text.Trim()) / float.Parse(toolStriptxtbxJudge.Text.Trim())) / 2) + ((float.Parse(txtAudienceVote.Text.Trim())) / 20)) / 2, 2).ToString();
            }
            else
            {
                MessageBox.Show("Out of Reach !", "Warning");
            }
        }



        /* Tool Strip Menu */

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        /* Footer Button */

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtJudgeVote.Text = "";
            txtAudienceVote.Text = "";

            pnlJudge.Location = new Point(116, 351);
            pnlAudience.Location = new Point(116, 351);
            pnlTotal.Location = new Point(116, 351);

            lblJudgeVote.Text = "0";
            lblAudienceVote.Text = "0";
            lblTotalVote.Text = "0";

            pnlJudgeMain.Refresh();
            pnlJudge.Refresh();

            pnlAudienceMain.Refresh();
            pnlAudience.Refresh();

            pnlTotalMain.Refresh();
            pnlTotal.Refresh();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, want to Dismiss the Voting?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        /* Main Form Load */

        private void Form1_Load(object sender, EventArgs e)
        {
            FormFlash ff = new FormFlash();
            ff.ShowDialog();
        }
    }
}
