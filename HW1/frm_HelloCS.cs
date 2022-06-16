using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class frm_HelloCS : Form
    {
        public frm_HelloCS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, 我是" + txtName.Text + ",\n英文名字是" + txtEnglishName.Text + ",\n性別是" + txtGender.Text + ",\n星座是" + txtSign.Text + ",\n很高興認識你。");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, 我是" + txtName.Text + ",\n英文名字是" + txtEnglishName.Text + ",\n性別是" + txtGender.Text + ",\n星座是" + txtSign.Text + ",\n很高興認識你。");
        }
    }
}
