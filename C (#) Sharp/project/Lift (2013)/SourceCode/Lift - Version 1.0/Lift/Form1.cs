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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, want to Crush the Lift?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonShift_Click(object sender, EventArgs e)
        {
            int floor = 7;
            int labelnumber = int.Parse(labelFloor.Text.Trim());
            int n = int.Parse(txtFloor.Text.Trim());
            int count = int.Parse(labelFloor.Text.Trim());

            if (n <= 7 && n >= 0)
            {
                if (n > labelnumber)                /* Lift Up */
                {
                    for (int i = ((floor - labelnumber) * 50); i >= ((floor - n + 1) * 50) - 49; i--)
                    {
                        panelLift.Location = new Point(116, i);

                        if (i % 50 == 0)
                        {
                            count++;
                            labelFloor.Text = count.ToString();
                        }

                        Thread.Sleep(30);
                        Application.DoEvents();
                    }
                }
                else if (n < labelnumber)           /* Lift Down */
                {
                    for (int i = ((floor - labelnumber) * 50); i <= ((floor - n) * 50); i++)
                    {
                        panelLift.Location = new Point(116, i);

                        if (i % 50 == 0)
                        {
                            count--;
                            labelFloor.Text = count.ToString();
                        }

                        Thread.Sleep(30);
                        Application.DoEvents();
                    }
                    labelFloor.Text = n.ToString();
                }
            }
            else
            {
                MessageBox.Show("Out of Reach !", "Warning");
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            FormFlash ff = new FormFlash();
            ff.ShowDialog();
        }
    }
}
