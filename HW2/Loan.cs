using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            float r=0;
            for (int i = 1; i <= Int32.Parse(txtDue.Text)*12; i++)
            {
                r += (1 + Int32.Parse(txtRate.Text) / 12)^i;
            }
            Messagebox.Show(r);
        }
    }
}
