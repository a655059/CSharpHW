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
    public partial class frm_LoanReport : Form
    {
        public frm_LoanReport()
        {
            InitializeComponent();
        }

        private void frm_LoanReport_Load(object sender, EventArgs e)
        {
            txtAmount.Text = frm_Loan.gAmount.ToString();
            txtDue.Text = frm_Loan.gDue.ToString();
            txtRate.Text = frm_Loan.gRate.ToString();
            txtMonthlyPay.Text = frm_Loan.gMonthlyPay.ToString();
            txtTotalPay.Text = frm_Loan.gTotalPay.ToString();
            Size size = TextRenderer.MeasureText(txtAmount.Text, txtAmount.Font);
            txtAmount.Width = size.Width;

            size = TextRenderer.MeasureText(txtDue.Text, txtDue.Font);
            txtDue.Width = size.Width;

            size = TextRenderer.MeasureText(txtRate.Text, txtRate.Font);
            txtRate.Width = size.Width;

            size = TextRenderer.MeasureText(txtMonthlyPay.Text, txtMonthlyPay.Font);
            txtMonthlyPay.Width = size.Width;

            size = TextRenderer.MeasureText(txtTotalPay.Text, txtTotalPay.Font);
            txtTotalPay.Width = size.Width;
        }
    }
}
