
namespace HW5
{
    partial class frm_StudentGrade
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
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRandomAdd = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandomAdd20 = new System.Windows.Forms.Button();
            this.txtStatistics = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(56, 96);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(70, 25);
            this.txtMath.TabIndex = 15;
            this.txtMath.Text = "100";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(56, 68);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(70, 25);
            this.txtEnglish.TabIndex = 14;
            this.txtEnglish.Text = "100";
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(56, 40);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(70, 25);
            this.txtChinese.TabIndex = 13;
            this.txtChinese.Text = "100";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(56, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(70, 25);
            this.txtName.TabIndex = 12;
            this.txtName.Text = "王小明";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(15, 99);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(45, 15);
            this.labMath.TabIndex = 11;
            this.labMath.Text = "數學: ";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(15, 71);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(45, 15);
            this.labEnglish.TabIndex = 10;
            this.labEnglish.Text = "英文: ";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(15, 43);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(45, 15);
            this.labChinese.TabIndex = 9;
            this.labChinese.Text = "國文: ";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(15, 15);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(45, 15);
            this.labName.TabIndex = 8;
            this.labName.Text = "姓名: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRandomAdd
            // 
            this.btnRandomAdd.Location = new System.Drawing.Point(18, 156);
            this.btnRandomAdd.Name = "btnRandomAdd";
            this.btnRandomAdd.Size = new System.Drawing.Size(108, 23);
            this.btnRandomAdd.TabIndex = 17;
            this.btnRandomAdd.Text = "隨機儲存資料";
            this.btnRandomAdd.UseVisualStyleBackColor = true;
            this.btnRandomAdd.Click += new System.EventHandler(this.btnRandomAdd_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Location = new System.Drawing.Point(18, 185);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(108, 23);
            this.btnStatistics.TabIndex = 18;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(18, 249);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRandomAdd20
            // 
            this.btnRandomAdd20.Location = new System.Drawing.Point(18, 278);
            this.btnRandomAdd20.Name = "btnRandomAdd20";
            this.btnRandomAdd20.Size = new System.Drawing.Size(108, 23);
            this.btnRandomAdd20.TabIndex = 20;
            this.btnRandomAdd20.Text = "隨機加入20筆";
            this.btnRandomAdd20.UseVisualStyleBackColor = true;
            this.btnRandomAdd20.Click += new System.EventHandler(this.btnRandomAdd20_Click);
            // 
            // txtStatistics
            // 
            this.txtStatistics.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStatistics.Location = new System.Drawing.Point(132, 214);
            this.txtStatistics.Multiline = true;
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.ReadOnly = true;
            this.txtStatistics.Size = new System.Drawing.Size(449, 112);
            this.txtStatistics.TabIndex = 22;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(132, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(449, 196);
            this.txtResult.TabIndex = 23;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // frm_StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 338);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtStatistics);
            this.Controls.Add(this.btnRandomAdd20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRandomAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Name = "frm_StudentGrade";
            this.Text = "Myhomework";
            this.Load += new System.EventHandler(this.frm_StudentGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRandomAdd;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandomAdd20;
        private System.Windows.Forms.TextBox txtStatistics;
        private System.Windows.Forms.TextBox txtResult;
    }
}

