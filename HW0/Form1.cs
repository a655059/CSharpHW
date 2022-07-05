using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_HW1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW1.frm_HelloCS nform = new HW1.frm_HelloCS();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }

        private void btn_HW2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW2.frm_Loan nform = new HW2.frm_Loan();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }

        private void btn_HW3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW3.frm_BarPOS nform = new HW3.frm_BarPOS();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }

        private void btn_HW4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW4.frm_StudentStruct nform = new HW4.frm_StudentStruct();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }

        private void btn_HW5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW5.frm_StudentGrade nform = new HW5.frm_StudentGrade();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }

        private void btn_HW6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW6.Form1 nform = new HW6.Form1();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }

        private void btn_HW7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW7.Myhomework_Method nform = new HW7.Myhomework_Method();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }

        private void btn_HW8_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW8.Mycalc nform = new HW8.Mycalc();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }

        private void btn_HW9_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW9.Myhomework_Method2 nform = new HW9.Myhomework_Method2();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }

        private void btn_HW10_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HW10.XOgame nform = new HW10.XOgame();
            nform.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(nform);
            nform.Show();
        }
        
        private void btn_HW11_Click(object sender, EventArgs e)
        {
            Form2 nform = new Form2();
            nform.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
