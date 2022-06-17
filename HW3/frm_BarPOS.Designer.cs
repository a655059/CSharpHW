
namespace HW3
{
    partial class frm_BarPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BarPOS));
            this.pnlAlcohol = new System.Windows.Forms.Panel();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.labMenu = new System.Windows.Forms.Label();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.labTotalAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labDiscount = new System.Windows.Forms.Label();
            this.btnByCard = new System.Windows.Forms.Button();
            this.btnByCash = new System.Windows.Forms.Button();
            this.labPayment = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.btnClearList = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.labList = new System.Windows.Forms.Label();
            this.pnlAlcohol.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAlcohol
            // 
            this.pnlAlcohol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlcohol.Controls.Add(this.btnWine);
            this.pnlAlcohol.Controls.Add(this.btnWhisky);
            this.pnlAlcohol.Controls.Add(this.btnTequila);
            this.pnlAlcohol.Controls.Add(this.btnBeer);
            this.pnlAlcohol.Controls.Add(this.labMenu);
            this.pnlAlcohol.Location = new System.Drawing.Point(12, 12);
            this.pnlAlcohol.Name = "pnlAlcohol";
            this.pnlAlcohol.Size = new System.Drawing.Size(187, 233);
            this.pnlAlcohol.TabIndex = 0;
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.Color.White;
            this.btnWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWine.BackgroundImage")));
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.ForeColor = System.Drawing.Color.Black;
            this.btnWine.Location = new System.Drawing.Point(95, 131);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(75, 86);
            this.btnWine.TabIndex = 4;
            this.btnWine.Text = "紅酒\r\nWine\r\nNT$320";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackColor = System.Drawing.Color.White;
            this.btnWhisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhisky.BackgroundImage")));
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhisky.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.ForeColor = System.Drawing.Color.Black;
            this.btnWhisky.Location = new System.Drawing.Point(14, 131);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(75, 86);
            this.btnWhisky.TabIndex = 3;
            this.btnWhisky.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.btnWhisky.UseVisualStyleBackColor = false;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackColor = System.Drawing.Color.White;
            this.btnTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTequila.BackgroundImage")));
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.ForeColor = System.Drawing.Color.Black;
            this.btnTequila.Location = new System.Drawing.Point(95, 39);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(75, 86);
            this.btnTequila.TabIndex = 2;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.btnTequila.UseVisualStyleBackColor = false;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackColor = System.Drawing.Color.White;
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.ForeColor = System.Drawing.Color.Black;
            this.btnBeer.Location = new System.Drawing.Point(14, 39);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(75, 86);
            this.btnBeer.TabIndex = 1;
            this.btnBeer.Text = "啤酒\r\nBeer\r\nNT$120";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // labMenu
            // 
            this.labMenu.AutoSize = true;
            this.labMenu.Location = new System.Drawing.Point(12, 13);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(59, 12);
            this.labMenu.TabIndex = 0;
            this.labMenu.Text = "菜單 Menu";
            // 
            // pnlAmount
            // 
            this.pnlAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmount.Controls.Add(this.txtTotalPrice);
            this.pnlAmount.Controls.Add(this.labTotalAmount);
            this.pnlAmount.Location = new System.Drawing.Point(205, 12);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(200, 89);
            this.pnlAmount.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.Black;
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(16, 40);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(165, 28);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.Text = "NT$ 0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labTotalAmount
            // 
            this.labTotalAmount.AutoSize = true;
            this.labTotalAmount.Location = new System.Drawing.Point(14, 14);
            this.labTotalAmount.Name = "labTotalAmount";
            this.labTotalAmount.Size = new System.Drawing.Size(94, 12);
            this.labTotalAmount.TabIndex = 0;
            this.labTotalAmount.Text = "總金額 Total Price";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labDiscount);
            this.panel1.Controls.Add(this.btnByCard);
            this.panel1.Controls.Add(this.btnByCash);
            this.panel1.Controls.Add(this.labPayment);
            this.panel1.Location = new System.Drawing.Point(205, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labDiscount.Location = new System.Drawing.Point(98, 76);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(83, 14);
            this.labDiscount.TabIndex = 3;
            this.labDiscount.Text = "信用卡享九折!";
            // 
            // btnByCard
            // 
            this.btnByCard.Location = new System.Drawing.Point(98, 50);
            this.btnByCard.Name = "btnByCard";
            this.btnByCard.Size = new System.Drawing.Size(75, 23);
            this.btnByCard.TabIndex = 2;
            this.btnByCard.Text = "信用卡";
            this.btnByCard.UseVisualStyleBackColor = true;
            this.btnByCard.Click += new System.EventHandler(this.btnByCard_Click);
            // 
            // btnByCash
            // 
            this.btnByCash.Location = new System.Drawing.Point(17, 50);
            this.btnByCash.Name = "btnByCash";
            this.btnByCash.Size = new System.Drawing.Size(75, 23);
            this.btnByCash.TabIndex = 1;
            this.btnByCash.Text = "現金";
            this.btnByCash.UseVisualStyleBackColor = true;
            this.btnByCash.Click += new System.EventHandler(this.btnByCash_Click);
            // 
            // labPayment
            // 
            this.labPayment.AutoSize = true;
            this.labPayment.Location = new System.Drawing.Point(15, 9);
            this.labPayment.Name = "labPayment";
            this.labPayment.Size = new System.Drawing.Size(53, 12);
            this.labPayment.TabIndex = 0;
            this.labPayment.Text = "付款方式";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.btnClearList);
            this.pnlList.Controls.Add(this.txtList);
            this.pnlList.Controls.Add(this.labList);
            this.pnlList.Location = new System.Drawing.Point(411, 12);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(236, 257);
            this.pnlList.TabIndex = 3;
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(145, 224);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "清除清單";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(15, 34);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.Size = new System.Drawing.Size(205, 184);
            this.txtList.TabIndex = 1;
            this.txtList.Text = "尚未點餐";
            this.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labList
            // 
            this.labList.AutoSize = true;
            this.labList.Location = new System.Drawing.Point(13, 14);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(73, 12);
            this.labList.TabIndex = 0;
            this.labList.Text = "購物清單 List";
            // 
            // frm_BarPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(659, 291);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAmount);
            this.Controls.Add(this.pnlAlcohol);
            this.Name = "frm_BarPOS";
            this.Text = "Bar POS";
            this.pnlAlcohol.ResumeLayout(false);
            this.pnlAlcohol.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlcohol;
        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label labTotalAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.Button btnByCard;
        private System.Windows.Forms.Button btnByCash;
        private System.Windows.Forms.Label labPayment;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label labList;
    }
}

