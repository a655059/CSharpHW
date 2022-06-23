using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW10
{
    public partial class XOgame : Form
    {
        public XOgame()
        {
            InitializeComponent();
        }
        void ResetButton()
        {
            for (int i =0;i<9;i++)
            {
                OXbuttons[i].Text = "";
                OXbuttons[i].Enabled = true;
                Ostatus.Clear();
                Xstatus.Clear();
            }
            phase = false;
        }
        bool SearchPair(List<int> st, int[] pair)
        {
            return st.Contains(pair[0]) && st.Contains(pair[1]) && st.Contains(pair[2]);          
        }
        void CheckWinner()
        {
            for(int i=0;i<8;i++)
            {
                if (SearchPair(Ostatus,wincondition[i]))
                {
                    MessageBox.Show("O 手獲勝", "完局");
                    ResetButton();
                }
                if (SearchPair(Xstatus, wincondition[i]))
                {
                    MessageBox.Show("X 手獲勝", "完局");
                    ResetButton();
                }
            }
            if(Ostatus.Count + Xstatus.Count == 9)
            {
                MessageBox.Show("平手！按下確定重新開始","完局");
                ResetButton();
            }
        }
        List<int> Xstatus = new List<int>(), Ostatus = new List<int>();
        bool phase = false;
        Button[] OXbuttons;
        int[][] wincondition = new int[][] { new int[] { 1,2,3}, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 3, 6, 9 }, new int[] { 1, 5, 9 }, new int[] { 7, 5, 3 } };
        private void OXbutton1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(((Button)sender).Name[6].ToString());
            ((Button)sender).Enabled = false;
            if (phase)
            {
                Ostatus.Add(num);
            }
            else
            {
                Xstatus.Add(num);
            }
            OXbuttons[num-1].Text = phase ? "O" : "X";
            phase = !phase;
            CheckWinner();
        }

        private void XOgame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
            if (e.KeyCode == Keys.R)
            {
                btnReset.PerformClick();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetButton();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XOgame_Load(object sender, EventArgs e)
        {
            OXbuttons = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            ResetButton();
        }
    }
}
