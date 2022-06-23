using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
    public partial class Myhomework_Method : Form
    {
        public Myhomework_Method()
        {
            InitializeComponent();
        }
        int[] arr0711 = new int[] {1,5,6,8,7,97,54,887,65,578 };
        string[] arr0711_Str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker"};
        private void btnOddorEven_Click(object sender, EventArgs e)
        {
            int tint;
            bool flag = int.TryParse(txtNumber.Text, out tint);
            if(!flag)
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if(tint % 2 == 1)
            {
                labShowResult.Text = "輸入的數 " + txtNumber.Text + "為 奇數。";
            }
            else 
            {
                labShowResult.Text = "輸入的數 " + txtNumber.Text + "為 偶數。";
            }
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "int陣列arr0711[ ";
            labShowResult.Text += arr0711[0].ToString();
            for (int i=1;i<arr0711.Length;i++)
            {
                labShowResult.Text += ", " + arr0711[i].ToString();
            }
            labShowResult.Text += "]\r\n";
            labShowResult.Text += "最大值為 " + arr0711.Max().ToString() + "\r\n";
            labShowResult.Text += "最小值為 " + arr0711.Min().ToString();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int ccount = 0;
            labShowResult.Text = "arr0711_Str陣列：";
            for (int i = 0; i < arr0711_Str.Length; i++)
            {
                labShowResult.Text += "  " + arr0711_Str[i];
                if(arr0711_Str[i].Contains("C") || arr0711_Str[i].Contains("c"))
                {
                    ccount++;
                }
            }
            labShowResult.Text += "\r\n有C 及 c的名字共有 "+ ccount.ToString() +" 個";

        }

        private void btnArrOddorEven_Click(object sender, EventArgs e)
        {
            int ocount = 0;
            int ecount = 0;
            labShowResult.Text = "int陣列arr0711[ ";
            labShowResult.Text += arr0711[0].ToString();
            if (arr0711[0] % 2 == 1)
            {
                ocount++;
            }
            else
            {
                ecount++;
            }
            for (int i = 1; i < arr0711.Length; i++)
            {
                labShowResult.Text += ", " + arr0711[i].ToString();
                if (arr0711[i] % 2 == 1)
                {
                    ocount++;
                }
                else
                {
                    ecount++;
                }
            }
            labShowResult.Text += "]\r\n";
            labShowResult.Text += "奇數共 " + ocount.ToString() + "\r\n";
            labShowResult.Text += "偶數共 " + ecount.ToString();
        }

        private void btnLongName_Click(object sender, EventArgs e)
        {
            int longindex = 0;
            labShowResult.Text = "陣列arr0711_Str [ ";
            labShowResult.Text += arr0711_Str[0];
            for (int i = 1; i < arr0711_Str.Length; i++)
            {
                labShowResult.Text += "," + arr0711_Str[i];
                if (arr0711_Str[i].Length > arr0711_Str[longindex].Length)
                {
                    longindex = i;
                }
            }
            labShowResult.Text += "]\r\n最長的名字為" + arr0711_Str[longindex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] temp = new int[10,10];
            labShowResult.Text = "";
            for (int i=0;i<10;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if((i % 9) * (j % 9) == 0)
                    {
                        temp[i, j] = 1;                   
                    }
                    else
                    {
                        temp[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labShowResult.Text += temp[i, j];
                    if (j != 9)
                    {
                        labShowResult.Text += " ";
                    }
                }
                labShowResult.Text += "\r\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] temp = new int[10, 10];
            labShowResult.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i % 9) * (j % 9) == 0)
                    {
                        temp[i, j] = 0;
                    }
                    else
                    {
                        temp[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labShowResult.Text += temp[i, j];
                    if (j != 9)
                    {
                        labShowResult.Text += " ";
                    }
                }
                labShowResult.Text += "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] temp = new int[10, 10];
            labShowResult.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (((i % 2) + (j % 2)) % 2 == 0)
                    {
                        temp[i, j] = 1;
                    }
                    else
                    {
                        temp[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labShowResult.Text += temp[i, j];
                    if (j != 9)
                    {
                        labShowResult.Text += " ";
                    }
                }
                labShowResult.Text += "\r\n";
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200, t;
            labShowResult.Text = "換位前n1=" + n1 + " , n2=" + n2 + "\r\n";
            t = n2;
            n2 = n1;
            n1 = t;
            labShowResult.Text += "換位後n1=" + n1 + " , n2=" + n2;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "int陣列arr0711[ ";
            labShowResult.Text += arr0711[0].ToString();
            for (int i = 1; i < arr0711.Length; i++)
            {
                labShowResult.Text += ", " + arr0711[i].ToString();
            }
            labShowResult.Text += "]\r\n加總為 " + arr0711.Sum();

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "int陣列arr0711[ ";
            labShowResult.Text += arr0711[0].ToString();
            for (int i = 1; i < arr0711.Length; i++)
            {
                labShowResult.Text += ", " + arr0711[i].ToString();
            }
            labShowResult.Text += "]\r\n最大值為 " + arr0711.Max();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "int陣列arr0711[ ";
            labShowResult.Text += arr0711[0].ToString();
            for (int i = 1; i < arr0711.Length; i++)
            {
                labShowResult.Text += ", " + arr0711[i].ToString();
            }
            labShowResult.Text += "]\r\n最小值為 " + arr0711.Min();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "結果";
        }
    }
}
