
namespace HW2
{
    partial class Loan
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
            this.labAmount = new System.Windows.Forms.Label();
            this.labDue = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labDown = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Location = new System.Drawing.Point(59, 47);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(53, 12);
            this.labAmount.TabIndex = 0;
            this.labAmount.Text = "貸款金額";
            // 
            // labDue
            // 
            this.labDue.AutoSize = true;
            this.labDue.Location = new System.Drawing.Point(59, 59);
            this.labDue.Name = "labDue";
            this.labDue.Size = new System.Drawing.Size(49, 12);
            this.labDue.TabIndex = 1;
            this.labDue.Text = "期限(年)";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Location = new System.Drawing.Point(59, 71);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(46, 12);
            this.labRate.TabIndex = 2;
            this.labRate.Text = "利率(%)";
            // 
            // labDown
            // 
            this.labDown.AutoSize = true;
            this.labDown.Location = new System.Drawing.Point(59, 83);
            this.labDown.Name = "labDown";
            this.labDown.Size = new System.Drawing.Size(41, 12);
            this.labDown.TabIndex = 3;
            this.labDown.Text = "頭期款";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(149, 44);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Text = "100000";
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(149, 73);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 22);
            this.txtDue.TabIndex = 5;
            this.txtDue.Text = "2";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(149, 101);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "10";
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(149, 129);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(100, 22);
            this.txtDown.TabIndex = 7;
            this.txtDown.Text = "0";
            // 
            // btnPMT
            // 
            this.btnPMT.Location = new System.Drawing.Point(61, 171);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(75, 23);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "月付";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtDown);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labDown);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labDue);
            this.Controls.Add(this.labAmount);
            this.Name = "Loan";
            this.Text = "貸款金額計算";
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
    }
}

