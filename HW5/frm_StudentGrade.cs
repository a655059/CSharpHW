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
            btnStatistics.Enabled = true;
            if (txtName.Text == "")
            {
                MessageBox.Show("請輸入姓名。","警告！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else if(txtChinese.Text == "")
            {
                MessageBox.Show("請輸入國文成績。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(txtEnglish.Text == "")
            {
                MessageBox.Show("請輸入英文成績。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(txtMath.Text == "")
            {
                MessageBox.Show("請輸入數學成績。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            Random rdm = new Random();
            btnStatistics.Enabled = true;
            AddStudent((strNameList.Length+1).ToString(), rdm.Next(0,101), rdm.Next(0, 101), rdm.Next(0, 101));
            DisplayStudent(strNameList.Length - 1);
        }

        private void btnRandomAdd20_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            btnStatistics.Enabled = true;
            for (int i = 0;i<20;i++)
            {
                AddStudent((strNameList.Length + 1).ToString(), rdm.Next(0, 101), rdm.Next(0, 101), rdm.Next(0, 101));
                DisplayStudent(strNameList.Length - 1);
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            int totalChinese = 0, totalEnglish = 0, totalMath = 0;
            btnAdd.Enabled = false;
            btnRandomAdd.Enabled = false;
            btnStatistics.Enabled = false;
            btnRandomAdd20.Enabled = false;
            for(int i = 0;i<intChineseList.Length;i++)
            {
                totalChinese += intChineseList[i];
                totalEnglish += intEnglishList[i];
                totalMath += intMathList[i];
            }
            double averageChinese = Math.Round(totalChinese * 1.0 / intChineseList.Length,1), averageEnglish = Math.Round(totalEnglish * 1.0 / intEnglishList.Length, 1), averageMath = Math.Round(totalMath * 1.0 / intMathList.Length, 1);
            txtStatistics.Text = "總分\t\t" + totalChinese + "\t" + totalEnglish + "\t" + totalMath + "\r\n";
            txtStatistics.Text += "平均\t\t" + averageChinese + "\t" + averageEnglish + "\t" + averageMath + "\r\n";
            txtStatistics.Text += "最高分\t\t" + intChineseList.Max() + "\t" + intEnglishList.Max() + "\t" + intMathList.Max() + "\r\n";
            txtStatistics.Text += "最低分\t\t" + intChineseList.Min() + "\t" + intEnglishList.Min() + "\t" + intMathList.Min() + "\r\n";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnRandomAdd.Enabled = true;
            btnStatistics.Enabled = false;
            btnRandomAdd20.Enabled = true;
            txtResult.Text = "姓名\t\t國文\t英文\t數學\t總分\t平均\t最低\t最高\t\r\n";
            txtStatistics.Text = "";
            strNameList = new string[0];
            intChineseList = new int[0];
            intEnglishList = new int[0];
            intMathList = new int[0];
        }
    }
}
