
namespace HW2
{
    partial class frm_LoanReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LoanReport));
            this.txtMonthlyPay = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labMonthlyPay = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labDue = new System.Windows.Forms.Label();
            this.labAmount = new System.Windows.Forms.Label();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMonthlyPay
            // 
            this.txtMonthlyPay.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMonthlyPay.Location = new System.Drawing.Point(124, 114);
            this.txtMonthlyPay.Name = "txtMonthlyPay";
            this.txtMonthlyPay.ReadOnly = true;
            this.txtMonthlyPay.Size = new System.Drawing.Size(100, 27);
            this.txtMonthlyPay.TabIndex = 15;
            this.txtMonthlyPay.Text = "0";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(124, 86);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(100, 27);
            this.txtRate.TabIndex = 14;
            this.txtRate.Text = "10";
            // 
            // txtDue
            // 
            this.txtDue.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDue.Location = new System.Drawing.Point(124, 58);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(100, 27);
            this.txtDue.TabIndex = 13;
            this.txtDue.Text = "2";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(124, 29);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 27);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.Text = "100000";
            // 
            // labMonthlyPay
            // 
            this.labMonthlyPay.AutoSize = true;
            this.labMonthlyPay.BackColor = System.Drawing.Color.Transparent;
            this.labMonthlyPay.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMonthlyPay.Location = new System.Drawing.Point(41, 117);
            this.labMonthlyPay.Name = "labMonthlyPay";
            this.labMonthlyPay.Size = new System.Drawing.Size(56, 16);
            this.labMonthlyPay.TabIndex = 11;
            this.labMonthlyPay.Text = "月付款";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.BackColor = System.Drawing.Color.Transparent;
            this.labRate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(41, 89);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(64, 16);
            this.labRate.TabIndex = 10;
            this.labRate.Text = "利率(%)";
            // 
            // labDue
            // 
            this.labDue.AutoSize = true;
            this.labDue.BackColor = System.Drawing.Color.Transparent;
            this.labDue.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDue.Location = new System.Drawing.Point(41, 61);
            this.labDue.Name = "labDue";
            this.labDue.Size = new System.Drawing.Size(72, 16);
            this.labDue.TabIndex = 9;
            this.labDue.Text = "期限(年)";
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.BackColor = System.Drawing.Color.Transparent;
            this.labAmount.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAmount.Location = new System.Drawing.Point(41, 35);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(72, 16);
            this.labAmount.TabIndex = 8;
            this.labAmount.Text = "貸款金額";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPay.Location = new System.Drawing.Point(124, 142);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.ReadOnly = true;
            this.txtTotalPay.Size = new System.Drawing.Size(100, 27);
            this.txtTotalPay.TabIndex = 17;
            this.txtTotalPay.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(41, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "總付款";
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(132, 175);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(92, 47);
            this.btnEmail.TabIndex = 18;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // frm_LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(271, 241);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonthlyPay);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labMonthlyPay);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labDue);
            this.Controls.Add(this.labAmount);
            this.Name = "frm_LoanReport";
            this.Text = "LoanReport";
            this.Load += new System.EventHandler(this.frm_LoanReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonthlyPay;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labMonthlyPay;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labDue;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmail;
    }
}