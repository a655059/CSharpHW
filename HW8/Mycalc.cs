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
        double n1, n2;
        bool GetNumbers()
        {
            bool flag = Double.TryParse(txtNum1.Text,out n1);
            flag &= Double.TryParse(txtNum2.Text, out n2);
            return flag;


        }
        string CheckDigits(double num)
        {
            string[] strs = num.ToString().Split('.');
            string tstr1;
            int i = 0;
            if(strs.Length == 2)
            {
                if(strs[0].Length >8)
                {
                    return "";
                }
                else if(strs[0].Length >=7)
                {
                    return strs[0];
                }
                else
                {
                    tstr1 = strs[0] + ".";
                    strs[1] = Math.Round(double.Parse("0." + strs[1]), 8 - tstr1.Length).ToString().Split('.')[1];
                    while (tstr1.Length < 8 && i < strs[1].Length)
                    {
                        tstr1 += strs[1][i];
                        i++;
                    }
                    return tstr1;
                }
            }
            else
            {
                if (strs[0].Length > 8)
                {
                    return "";
                }
                else
                {
                    return strs[0];
                }
            }

        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(!GetNumbers())
            {
                MessageBox.Show("請輸入數值。");
                return;
            }
            txtAnswer.Text = CheckDigits(n1 + n2);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!GetNumbers())
            {
                MessageBox.Show("請輸入數值。");
                return;
            }
            txtAnswer.Text = CheckDigits(n1 - n2);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (!GetNumbers())
            {
                MessageBox.Show("請輸入數值。");
                return;
            }
            txtAnswer.Text = CheckDigits(Math.Round(n1 * n2,4));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!GetNumbers())
            {
                MessageBox.Show("請輸入數值。");
                return;
            }
            txtAnswer.Text = CheckDigits(Math.Round(n1 / n2,4));
        }
    }
}
