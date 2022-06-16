
namespace HW1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labName = new System.Windows.Forms.Label();
            this.labEnglishName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labSign = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(42, 53);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(48, 16);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labEnglishName
            // 
            this.labEnglishName.AutoSize = true;
            this.labEnglishName.BackColor = System.Drawing.Color.Transparent;
            this.labEnglishName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglishName.Location = new System.Drawing.Point(42, 81);
            this.labEnglishName.Name = "labEnglishName";
            this.labEnglishName.Size = new System.Drawing.Size(120, 16);
            this.labEnglishName.TabIndex = 1;
            this.labEnglishName.Text = "English Name: ";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.Location = new System.Drawing.Point(42, 109);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(56, 16);
            this.labGender.TabIndex = 2;
            this.labGender.Text = "性別: ";
            // 
            // labSign
            // 
            this.labSign.AutoSize = true;
            this.labSign.BackColor = System.Drawing.Color.Transparent;
            this.labSign.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSign.Location = new System.Drawing.Point(42, 137);
            this.labSign.Name = "labSign";
            this.labSign.Size = new System.Drawing.Size(56, 16);
            this.labSign.TabIndex = 3;
            this.labSign.Text = "星座: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(175, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "王小明";
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglishName.Location = new System.Drawing.Point(175, 78);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(100, 27);
            this.txtEnglishName.TabIndex = 5;
            this.txtEnglishName.Text = "Ming";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGender.Location = new System.Drawing.Point(175, 106);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 27);
            this.txtGender.TabIndex = 6;
            this.txtGender.Text = "戰鬥直升機";
            // 
            // txtSign
            // 
            this.txtSign.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSign.Location = new System.Drawing.Point(175, 134);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(100, 27);
            this.txtSign.TabIndex = 7;
            this.txtSign.Text = "蛇夫座";
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSayHello.BackgroundImage")));
            this.btnSayHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSayHello.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Location = new System.Drawing.Point(42, 185);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(120, 40);
            this.btnSayHello.TabIndex = 8;
            this.btnSayHello.Text = "Say Hello!";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSayHi.BackgroundImage")));
            this.btnSayHi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSayHi.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Location = new System.Drawing.Point(168, 185);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(120, 40);
            this.btnSayHi.TabIndex = 9;
            this.btnSayHi.Text = "Say Hi!";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(333, 265);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labSign);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labEnglishName);
            this.Controls.Add(this.labName);
            this.Name = "Form1";
            this.Text = "你好! C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labEnglishName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labSign;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
    }
}

