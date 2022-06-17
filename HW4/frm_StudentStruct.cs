using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class frm_StudentStruct : Form
    {
        private string name = "";
        Dictionary<string, int> grade = new Dictionary<string, int>();
        public frm_StudentStruct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            grade.Clear();
            grade.Add("數學", Int32.Parse(txtMath.Text));
            grade.Add("國文", Int32.Parse(txtChinese.Text));
            grade.Add("英文", Int32.Parse(txtEnglish.Text));
        }

        private void btnDisplaySave_Click(object sender, EventArgs e)
        {
            txtGrade.Text = "姓名：" + name + "\r\n國文：" + grade["國文"] + "分\r\n英文：" + grade["英文"] + "分\r\n數學：" + grade["數學"] + "分";
        }

        private void btnDisplayMaxMin_Click(object sender, EventArgs e)
        {
            if (grade.Count == 0)
            {
                return;
            }
            txtMaxMin.Text = "最高科目成績為：" + grade.FirstOrDefault(x => x.Value == grade.Values.Max()).Key + grade.Values.Max() + "分\r\n"
                              + "最低科目成績為：" + grade.FirstOrDefault(x => x.Value == grade.Values.Min()).Key + grade.Values.Min() + "分";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
