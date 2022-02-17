using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lift
{
    public partial class FormFlash : Form
    {
        public FormFlash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval.Equals(1000))
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
