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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        int xin = 1, yin = 1, timerc = 0, cursorx = MousePosition.X, cursory = MousePosition.Y;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerc = (timerc + 1) % 20;
            if (timerc == 0)
            {
                if (Math.Abs(MousePosition.X - cursorx) > 30 || Math.Abs(MousePosition.Y - cursory) > 30)
                {
                    this.Close();
                }
                cursorx = MousePosition.X;
                cursory = MousePosition.Y;
            }
            if (pictureBox1.Location.X == this.ClientSize.Width - 240)
            {
                xin = -1;
            }
            if (pictureBox1.Location.X == 0)
            {
                xin = 1;
            }
            if (pictureBox1.Location.Y == this.ClientSize.Height - 200)
            {
                yin = -1;
            }
            if (pictureBox1.Location.Y == 0)
            {
                yin = 1;
            }
            Point p = pictureBox1.Location;
            p.Offset(xin, yin);
            pictureBox1.Location = p;
        }
    }
}
