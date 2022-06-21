using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    public partial class Mycalc : Form
    {
        public Mycalc()
        {
            InitializeComponent();
        }
        //string CheckDigit(double a)
        //{
        //    string sa = a.ToString();
        //    string[] subsa = sa.Split('.');
        //    if (subsa.Length == 1 )
        //    {
        //        if(subsa>)
        //    }
        //    else
        //    {

        //    }
        //}
        private void btnPlus_Click(object sender, EventArgs e)
        {
            //txtAnswer.Text = Math.Round(Double.Parse(txtNum1.Text) + Double.Parse(txtNum2.Text));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = Math.Round(Double.Parse(txtNum1.Text) - Double.Parse(txtNum2.Text), 5).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = Math.Round(Double.Parse(txtNum1.Text) * Double.Parse(txtNum2.Text), 5).ToString();
        }
    }
}
