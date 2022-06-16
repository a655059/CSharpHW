
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan));
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnPMT = new System.Windows.Forms.Button();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labDown = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labDue = new System.Windows.Forms.Label();
            this.labAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            this.btnTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotal.BackgroundImage")));
            this.btnTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTotal.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(160, 166);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(120, 40);
            this.btnTotal.TabIndex = 19;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // btnPMT
            // 
            this.btnPMT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPMT.BackgroundImage")));
            this.btnPMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPMT.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(34, 166);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(120, 40);
            this.btnPMT.TabIndex = 18;
            this.btnPMT.Text = "月付(PMT)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // txtDown
            // 
            this.txtDown.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDown.Location = new System.Drawing.Point(167, 115);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(100, 27);
            this.txtDown.TabIndex = 17;
            this.txtDown.Text = "0";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(167, 87);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 27);
            this.txtRate.TabIndex = 16;
            this.txtRate.Text = "10";
            // 
            // txtDue
            // 
            this.txtDue.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDue.Location = new System.Drawing.Point(167, 59);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 27);
            this.txtDue.TabIndex = 15;
            this.txtDue.Text = "2";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(167, 31);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 27);
            this.txtAmount.TabIndex = 14;
            this.txtAmount.Text = "100000";
            // 
            // labDown
            // 
            this.labDown.AutoSize = true;
            this.labDown.BackColor = System.Drawing.Color.Transparent;
            this.labDown.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDown.Location = new System.Drawing.Point(34, 118);
            this.labDown.Name = "labDown";
            this.labDown.Size = new System.Drawing.Size(56, 16);
            this.labDown.TabIndex = 13;
            this.labDown.Text = "頭期款";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.BackColor = System.Drawing.Color.Transparent;
            this.labRate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(34, 90);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(64, 16);
            this.labRate.TabIndex = 12;
            this.labRate.Text = "利率(%)";
            // 
            // labDue
            // 
            this.labDue.AutoSize = true;
            this.labDue.BackColor = System.Drawing.Color.Transparent;
            this.labDue.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDue.Location = new System.Drawing.Point(34, 62);
            this.labDue.Name = "labDue";
            this.labDue.Size = new System.Drawing.Size(72, 16);
            this.labDue.TabIndex = 11;
            this.labDue.Text = "期限(年)";
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.BackColor = System.Drawing.Color.Transparent;
            this.labAmount.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAmount.Location = new System.Drawing.Point(34, 34);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(72, 16);
            this.labAmount.TabIndex = 10;
            this.labAmount.Text = "貸款金額";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(286, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(444, 240);
            this.Controls.Add(this.button1);
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
            this.Name = "Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labDown;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labDue;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Button button1;
    }
}

