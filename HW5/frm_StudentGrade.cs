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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string result = "姓名\t\t國文\t英文\t數學\t總分\t平均\t最低\t最高\t\r\n";
            result += txtName.Text + "\t\t" + txtChinese.Text + "\t" + txtEnglish.Text + "\t" + txtMath.Text;
            txtResult.Text = result;

        }
    }
}
