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
            int month = Int32.Parse(txtDue.Text) * 12;
            double r = 0;
            for(int i = 1; i <= month; i++)
            {
                r += Math.Pow(1.0/(1.0 + ((Double.Parse(txtRate.Text)/12.0)/100.0)),i);
            }
            double p = Double.Parse(txtAmount.Text) / r;
            MessageBox.Show(p.ToString());
        }
    }
}
