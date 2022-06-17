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
    public partial class frm_Loan : Form
    {
        public static int gAmount = 0;
        public static int gDue = 0;
        public static int gRate = 0;
        public static int gMonthlyPay = 0;
        public static int gTotalPay = 0;
        public frm_Loan()
        {
            InitializeComponent();
        }

        double ComputeMonth()
        {
            int month = Int32.Parse(txtDue.Text) * 12;
            double r = 0;
            for (int i = 1; i <= month; i++)
            {
                r += Math.Pow(1.0 / (1.0 + ((Double.Parse(txtRate.Text) / 12.0) / 100.0)), i);
            }
            double p = (Double.Parse(txtAmount.Text)- Double.Parse(txtDown.Text)) / r;
            return p;
        }
        public int GetMonthPay()
        {
            return Convert.ToInt32(Math.Round(ComputeMonth()));
        }
        public int GetTotalPay()
        {
            return Convert.ToInt32(Math.Round(ComputeMonth()) * Int32.Parse(txtDue.Text) * 12.0);
        }
        private void btnPMT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("月付額：" + GetMonthPay().ToString() + "元");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總付款：" + GetTotalPay().ToString() + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frm_LoanReport report = new frm_LoanReport();
            gAmount = Int32.Parse(txtAmount.Text);
            gDue = Int32.Parse(txtDue.Text); ;
            gRate = Int32.Parse(txtRate.Text); ;
            gMonthlyPay = GetMonthPay();
            gTotalPay = GetTotalPay();
            report.ShowDialog();
        }
    }
}
