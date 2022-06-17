using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
    public partial class frm_BarPOS : Form
    {
        private int beercount = 0;
        private int tequilacount = 0;
        private int whiskycount = 0;
        private int winecount = 0;
        private int totalprice = 0;

        public frm_BarPOS()
        {
            InitializeComponent();
        }
        private void RefreshAll()
        {
            totalprice = beercount * 120 + tequilacount * 180 + whiskycount * 350 + winecount * 320;
            string listtext = "";
            if(beercount > 0)
            {
                listtext += "啤酒Beer x" + beercount + ",共NT$ " + beercount * 120 + " 元\r\n";
            }
            if (tequilacount > 0)
            {
                listtext += "龍舌蘭Tequila x" + tequilacount + ",共NT$ " + tequilacount * 180 + " 元\r\n";
            }
            if (whiskycount > 0)
            {
                listtext += "威士忌Whisky x" + whiskycount + ",共NT$ " + whiskycount * 350 + " 元\r\n";
            }
            if (winecount > 0)
            {
                listtext += "紅酒Wine x" + winecount + ",共NT$ " + winecount * 320 + " 元\r\n";
            }
            if (beercount == 0 && tequilacount == 0 && whiskycount == 0 && winecount == 0)
            {
                listtext = "尚未點餐";
            }
            txtTotalPrice.Text = "NT$ " + totalprice;
            txtList.Text = listtext;
        }
        private void btnBeer_Click(object sender, EventArgs e)
        {
            beercount += 1;
            RefreshAll();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            tequilacount += 1;
            RefreshAll();
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            whiskycount += 1;
            RefreshAll();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            winecount += 1;
            RefreshAll();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            beercount = 0;
            tequilacount = 0;
            whiskycount = 0;
            winecount = 0;
            RefreshAll();
        }

        private void btnByCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額: NT$" + totalprice);
        }

        private void btnByCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額: NT$" + totalprice + "\n折扣後金額: NT$" + Math.Round(totalprice*0.9));
        }
    }
}
