
namespace HW7
{
    partial class Myhomework_Method
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnOddorEven = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.labShowResult = new System.Windows.Forms.Label();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnArrOddorEven = new System.Windows.Forms.Button();
            this.btnLongName = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(12, 10);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(46, 12);
            this.labNumber.TabIndex = 0;
            this.labNumber.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(64, 6);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(60, 22);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.Text = "55";
            // 
            // btnOddorEven
            // 
            this.btnOddorEven.Location = new System.Drawing.Point(14, 34);
            this.btnOddorEven.Name = "btnOddorEven";
            this.btnOddorEven.Size = new System.Drawing.Size(150, 40);
            this.btnOddorEven.TabIndex = 2;
            this.btnOddorEven.Text = "輸入的是奇偶數";
            this.btnOddorEven.UseVisualStyleBackColor = true;
            this.btnOddorEven.Click += new System.EventHandler(this.btnOddorEven_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(12, 214);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(37, 12);
            this.labResult.TabIndex = 3;
            this.labResult.Text = "Result:";
            // 
            // labShowResult
            // 
            this.labShowResult.AutoSize = true;
            this.labShowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labShowResult.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowResult.Location = new System.Drawing.Point(55, 214);
            this.labShowResult.Name = "labShowResult";
            this.labShowResult.Size = new System.Drawing.Size(29, 12);
            this.labShowResult.TabIndex = 4;
            this.labShowResult.Text = "結果";
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(14, 80);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(150, 40);
            this.btnMaxMin.TabIndex = 5;
            this.btnMaxMin.Text = "陣列arr0711[]最大/小值";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(14, 126);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(150, 40);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "陣列arr0711_Str[] \"C\" OR \"c\"的字樣有幾個\r\n\r\n";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnArrOddorEven
            // 
            this.btnArrOddorEven.Location = new System.Drawing.Point(170, 34);
            this.btnArrOddorEven.Name = "btnArrOddorEven";
            this.btnArrOddorEven.Size = new System.Drawing.Size(150, 40);
            this.btnArrOddorEven.TabIndex = 7;
            this.btnArrOddorEven.Text = "陣列arr0711[]統計奇偶數";
            this.btnArrOddorEven.UseVisualStyleBackColor = true;
            this.btnArrOddorEven.Click += new System.EventHandler(this.btnArrOddorEven_Click);
            // 
            // btnLongName
            // 
            this.btnLongName.Location = new System.Drawing.Point(170, 80);
            this.btnLongName.Name = "btnLongName";
            this.btnLongName.Size = new System.Drawing.Size(150, 40);
            this.btnLongName.TabIndex = 8;
            this.btnLongName.Text = "陣列arr0711_Str[]最長的名字";
            this.btnLongName.UseVisualStyleBackColor = true;
            this.btnLongName.Click += new System.EventHandler(this.btnLongName_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "[10,10]二維陣列-邊1,內0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "[10,10]二維陣列-邊0,內1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "[10,10]二維陣列-邊1,內0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(482, 34);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(150, 40);
            this.btnSwap.TabIndex = 12;
            this.btnSwap.Text = "Swap[int ,int ]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(482, 80);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(150, 40);
            this.btnSum.TabIndex = 13;
            this.btnSum.Text = "Sum(陣列arr0711[])";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(482, 126);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(150, 40);
            this.btnMax.TabIndex = 14;
            this.btnMax.Text = "Max(陣列arr0711[])";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(482, 172);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(150, 40);
            this.btnMin.TabIndex = 15;
            this.btnMin.Text = "Min(陣列arr0711[])";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(14, 172);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "清空結果欄";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Myhomework_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 404);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLongName);
            this.Controls.Add(this.btnArrOddorEven);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.labShowResult);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnOddorEven);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labNumber);
            this.Name = "Myhomework_Method";
            this.Text = "Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnOddorEven;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labShowResult;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnArrOddorEven;
        private System.Windows.Forms.Button btnLongName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnReset;
    }
}

