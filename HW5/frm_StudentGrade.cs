using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5
{

    public partial class frm_StudentGrade : Form
    {
        public frm_StudentGrade()
        {
            InitializeComponent();
        }
        string[] strNameList = new string[0];
        int[] intChineseList = new int[0];
        int[] intEnglishList = new int[0];
        int[] intMathList = new int[0];
        void AddStudent(string name, int chinese, int english, int math)
        {
            int len = strNameList.Length;
            Array.Resize(ref strNameList, len + 1);
            strNameList[len] = name;
            Array.Resize(ref intChineseList, len + 1);
            intChineseList[len] = chinese;
            Array.Resize(ref intEnglishList, len + 1);
            intEnglishList[len] = english;
            Array.Resize(ref intMathList, len + 1);
            intMathList[len] = math;
        }
        void DisplayStudent(int len)
        {
            Dictionary<string, int> grade = new Dictionary<string, int>();
            int total;
            double average;
            grade.Add("數學", intMathList[len]);
            grade.Add("國文", intChineseList[len]);
            grade.Add("英文", intEnglishList[len]);
            total = intMathList[len] + intChineseList[len] + intEnglishList[len];
            average = Math.Round(total / 3.0, 1);
            txtResult.Text += strNameList[len] + "\t\t" + intChineseList[len].ToString() + "\t" + intEnglishList[len].ToString() + "\t" + intMathList[len].ToString() + "\t"
                + total.ToString() + "\t" + average.ToString() + "\t" + grade.FirstOrDefault(x => x.Value == grade.Values.Min()).Key + grade.Values.Min() + "\t" + grade.FirstOrDefault(x => x.Value == grade.Values.Max()).Key + grade.Values.Max() + "\r\n";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent(txtName.Text, Int32.Parse(txtChinese.Text), Int32.Parse(txtEnglish.Text), Int32.Parse(txtMath.Text));
            DisplayStudent(strNameList.Length - 1);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_StudentGrade_Load(object sender, EventArgs e)
        {
            txtResult.Text = "姓名\t\t國文\t英文\t數學\t總分\t平均\t最低\t最高\t\r\n";
        }

        private void btnRandomAdd_Click(object sender, EventArgs e)
        {
            AddStudent(strNameList.Length, Int32.Parse(txtChinese.Text), Int32.Parse(txtEnglish.Text), Int32.Parse(txtMath.Text));
            DisplayStudent(strNameList.Length - 1);
        }
    }
}
