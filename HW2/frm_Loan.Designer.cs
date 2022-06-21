
namespace HW2
{
    partial class frm_Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Loan));
            this.labAmount = new System.Windows.Forms.Label();
            this.labDue = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labDown = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.BackColor = System.Drawing.Color.Transparent;
            this.labAmount.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAmount.Location = new System.Drawing.Point(38, 42);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(72, 16);
            this.labAmount.TabIndex = 0;
            this.labAmount.Text = "貸款金額";
            // 
            // labDue
            // 
            this.labDue.AutoSize = true;
            this.labDue.BackColor = System.Drawing.Color.Transparent;
            this.labDue.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDue.Location = new System.Drawing.Point(38, 68);
            this.labDue.Name = "labDue";
            this.labDue.Size = new System.Drawing.Size(72, 16);
            this.labDue.TabIndex = 1;
            this.labDue.Text = "期限(年)";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.BackColor = System.Drawing.Color.Transparent;
            this.labRate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(38, 96);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(64, 16);
            this.labRate.TabIndex = 2;
            this.labRate.Text = "利率(%)";
            // 
            // labDown
            // 
            this.labDown.AutoSize = true;
            this.labDown.BackColor = System.Drawing.Color.Transparent;
            this.labDown.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDown.Location = new System.Drawing.Point(38, 124);
            this.labDown.Name = "labDown";
            this.labDown.Size = new System.Drawing.Size(56, 16);
            this.labDown.TabIndex = 3;
            this.labDown.Text = "頭期款";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(121, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 27);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Text = "100000";
            // 
            // txtDue
            // 
            this.txtDue.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDue.Location = new System.Drawing.Point(121, 65);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 27);
            this.txtDue.TabIndex = 5;
            this.txtDue.Text = "2";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(121, 93);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 27);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "10";
            // 
            // txtDown
            // 
            this.txtDown.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDown.Location = new System.Drawing.Point(121, 121);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(100, 27);
            this.txtDown.TabIndex = 7;
            this.txtDown.Text = "0";
            // 
            // btnPMT
            // 
            this.btnPMT.Location = new System.Drawing.Point(35, 160);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(75, 23);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "月付";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(116, 160);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(197, 160);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(319, 224);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtDown);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labDown);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labDue);
            this.Controls.Add(this.labAmount);
            this.Name = "frm_Loan";
            this.Text = "貸款金額計算";
            this.Load += new System.EventHandler(this.frm_Loan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Label labDue;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labDown;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}

