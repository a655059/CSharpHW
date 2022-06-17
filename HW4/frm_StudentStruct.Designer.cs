
namespace HW4
{
    partial class frm_StudentStruct
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
            this.labName = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDisplaySave = new System.Windows.Forms.Button();
            this.grpGrade = new System.Windows.Forms.GroupBox();
            this.pnlMaxMin = new System.Windows.Forms.Panel();
            this.pnlGrade = new System.Windows.Forms.Panel();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnDisplayMaxMin = new System.Windows.Forms.Button();
            this.txtMaxMin = new System.Windows.Forms.TextBox();
            this.grpGrade.SuspendLayout();
            this.pnlMaxMin.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(48, 61);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(45, 15);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名: ";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(48, 89);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(45, 15);
            this.labChinese.TabIndex = 1;
            this.labChinese.Text = "國文: ";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(48, 117);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(45, 15);
            this.labEnglish.TabIndex = 2;
            this.labEnglish.Text = "英文: ";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(48, 145);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(45, 15);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(89, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "王小明";
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(89, 86);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(100, 25);
            this.txtChinese.TabIndex = 5;
            this.txtChinese.Text = "100";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(89, 114);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 25);
            this.txtEnglish.TabIndex = 6;
            this.txtEnglish.Text = "100";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(89, 142);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 25);
            this.txtMath.TabIndex = 7;
            this.txtMath.Text = "100";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(13, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDisplaySave
            // 
            this.btnDisplaySave.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisplaySave.Location = new System.Drawing.Point(131, 219);
            this.btnDisplaySave.Name = "btnDisplaySave";
            this.btnDisplaySave.Size = new System.Drawing.Size(112, 38);
            this.btnDisplaySave.TabIndex = 9;
            this.btnDisplaySave.Text = "顯示儲存內容";
            this.btnDisplaySave.UseVisualStyleBackColor = true;
            this.btnDisplaySave.Click += new System.EventHandler(this.btnDisplaySave_Click);
            // 
            // grpGrade
            // 
            this.grpGrade.Controls.Add(this.pnlMaxMin);
            this.grpGrade.Controls.Add(this.pnlGrade);
            this.grpGrade.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpGrade.Location = new System.Drawing.Point(258, 12);
            this.grpGrade.Name = "grpGrade";
            this.grpGrade.Size = new System.Drawing.Size(266, 245);
            this.grpGrade.TabIndex = 10;
            this.grpGrade.TabStop = false;
            this.grpGrade.Text = "成績";
            // 
            // pnlMaxMin
            // 
            this.pnlMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMaxMin.Controls.Add(this.txtMaxMin);
            this.pnlMaxMin.Location = new System.Drawing.Point(6, 144);
            this.pnlMaxMin.Name = "pnlMaxMin";
            this.pnlMaxMin.Size = new System.Drawing.Size(254, 95);
            this.pnlMaxMin.TabIndex = 1;
            // 
            // pnlGrade
            // 
            this.pnlGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrade.Controls.Add(this.txtGrade);
            this.pnlGrade.Location = new System.Drawing.Point(6, 25);
            this.pnlGrade.Name = "pnlGrade";
            this.pnlGrade.Size = new System.Drawing.Size(254, 113);
            this.pnlGrade.TabIndex = 0;
            // 
            // txtGrade
            // 
            this.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrade.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGrade.Location = new System.Drawing.Point(3, 3);
            this.txtGrade.Multiline = true;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(246, 105);
            this.txtGrade.TabIndex = 0;
            // 
            // btnDisplayMaxMin
            // 
            this.btnDisplayMaxMin.Location = new System.Drawing.Point(399, 258);
            this.btnDisplayMaxMin.Name = "btnDisplayMaxMin";
            this.btnDisplayMaxMin.Size = new System.Drawing.Size(125, 40);
            this.btnDisplayMaxMin.TabIndex = 11;
            this.btnDisplayMaxMin.Text = "最高分/最低分科目";
            this.btnDisplayMaxMin.UseVisualStyleBackColor = true;
            this.btnDisplayMaxMin.Click += new System.EventHandler(this.btnDisplayMaxMin_Click);
            // 
            // txtMaxMin
            // 
            this.txtMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxMin.Location = new System.Drawing.Point(3, 3);
            this.txtMaxMin.Multiline = true;
            this.txtMaxMin.Name = "txtMaxMin";
            this.txtMaxMin.ReadOnly = true;
            this.txtMaxMin.Size = new System.Drawing.Size(246, 87);
            this.txtMaxMin.TabIndex = 0;
            this.txtMaxMin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frm_StudentStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 304);
            this.Controls.Add(this.btnDisplayMaxMin);
            this.Controls.Add(this.grpGrade);
            this.Controls.Add(this.btnDisplaySave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Name = "frm_StudentStruct";
            this.Text = "Student_StructForm";
            this.grpGrade.ResumeLayout(false);
            this.pnlMaxMin.ResumeLayout(false);
            this.pnlMaxMin.PerformLayout();
            this.pnlGrade.ResumeLayout(false);
            this.pnlGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDisplaySave;
        private System.Windows.Forms.GroupBox grpGrade;
        private System.Windows.Forms.Panel pnlMaxMin;
        private System.Windows.Forms.Panel pnlGrade;
        private System.Windows.Forms.Button btnDisplayMaxMin;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtMaxMin;
    }
}

