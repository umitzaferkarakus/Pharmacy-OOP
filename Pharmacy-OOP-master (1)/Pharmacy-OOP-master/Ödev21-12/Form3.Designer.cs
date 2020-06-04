namespace Ödev21_12
{
    partial class Form3
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
            this.label = new System.Windows.Forms.Label();
            this.lblDamount = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.btnOrderCheck = new System.Windows.Forms.Button();
            this.nudUnit = new System.Windows.Forms.NumericUpDown();
            this.btnCalculateTotalAmount = new System.Windows.Forms.Button();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.labelCart = new System.Windows.Forms.Label();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.labelAmunt = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelUnit = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.btnStoreProgess = new System.Windows.Forms.Button();
            this.btnNewSaleProgess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(397, 410);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(148, 19);
            this.label.TabIndex = 73;
            this.label.Text = "Discounted Amount:\n";
            // 
            // lblDamount
            // 
            this.lblDamount.AutoSize = true;
            this.lblDamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDamount.Location = new System.Drawing.Point(539, 410);
            this.lblDamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDamount.Name = "lblDamount";
            this.lblDamount.Size = new System.Drawing.Size(64, 17);
            this.lblDamount.TabIndex = 72;
            this.lblDamount.Text = "              ";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(100, 446);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(72, 17);
            this.lblTutar.TabIndex = 71;
            this.lblTutar.Text = "                ";
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPayment.Location = new System.Drawing.Point(397, 358);
            this.labelPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(80, 21);
            this.labelPayment.TabIndex = 70;
            this.labelPayment.Text = "Payment:";
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCreditCard.Location = new System.Drawing.Point(591, 356);
            this.rbCreditCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(118, 25);
            this.rbCreditCard.TabIndex = 69;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.RbCreditCard_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCash.Location = new System.Drawing.Point(493, 356);
            this.rbCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(68, 25);
            this.rbCash.TabIndex = 68;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // btnOrderCheck
            // 
            this.btnOrderCheck.Location = new System.Drawing.Point(655, 393);
            this.btnOrderCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderCheck.Name = "btnOrderCheck";
            this.btnOrderCheck.Size = new System.Drawing.Size(139, 43);
            this.btnOrderCheck.TabIndex = 67;
            this.btnOrderCheck.Text = "Orders Check";
            this.btnOrderCheck.UseVisualStyleBackColor = true;
            this.btnOrderCheck.Visible = false;
            this.btnOrderCheck.Click += new System.EventHandler(this.btnOrderCheck_Click);
            // 
            // nudUnit
            // 
            this.nudUnit.Location = new System.Drawing.Point(92, 399);
            this.nudUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudUnit.Name = "nudUnit";
            this.nudUnit.Size = new System.Drawing.Size(72, 22);
            this.nudUnit.TabIndex = 66;
            this.nudUnit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculateTotalAmount
            // 
            this.btnCalculateTotalAmount.Location = new System.Drawing.Point(655, 287);
            this.btnCalculateTotalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculateTotalAmount.Name = "btnCalculateTotalAmount";
            this.btnCalculateTotalAmount.Size = new System.Drawing.Size(139, 43);
            this.btnCalculateTotalAmount.TabIndex = 65;
            this.btnCalculateTotalAmount.Text = "Calculate Total Amount";
            this.btnCalculateTotalAmount.UseVisualStyleBackColor = true;
            this.btnCalculateTotalAmount.Click += new System.EventHandler(this.BtnCalculateTotalAmount_Click);
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalAmount.Location = new System.Drawing.Point(397, 300);
            this.labelTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(107, 19);
            this.labelTotalAmount.TabIndex = 64;
            this.labelTotalAmount.Text = "Total Amount:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(528, 300);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 17);
            this.lblTotal.TabIndex = 63;
            this.lblTotal.Text = "              ";
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCart.Location = new System.Drawing.Point(397, 22);
            this.labelCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(62, 22);
            this.labelCart.TabIndex = 62;
            this.labelCart.Text = "CART";
            this.labelCart.Click += new System.EventHandler(this.labelCart_Click);
            // 
            // lbCart
            // 
            this.lbCart.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 18;
            this.lbCart.Location = new System.Drawing.Point(393, 49);
            this.lbCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(399, 220);
            this.lbCart.TabIndex = 61;
            this.lbCart.SelectedIndexChanged += new System.EventHandler(this.lbCart_SelectedIndexChanged);
            // 
            // btnAddCart
            // 
            this.btnAddCart.Enabled = false;
            this.btnAddCart.Location = new System.Drawing.Point(199, 437);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(135, 32);
            this.btnAddCart.TabIndex = 60;
            this.btnAddCart.Text = "Add To Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.BtnaddCart_Click);
            // 
            // labelAmunt
            // 
            this.labelAmunt.AutoSize = true;
            this.labelAmunt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAmunt.Location = new System.Drawing.Point(24, 444);
            this.labelAmunt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmunt.Name = "labelAmunt";
            this.labelAmunt.Size = new System.Drawing.Size(68, 19);
            this.labelAmunt.TabIndex = 59;
            this.labelAmunt.Text = "Amount:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(199, 393);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 36);
            this.btnCalculate.TabIndex = 58;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUnit.Location = new System.Drawing.Point(24, 404);
            this.labelUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(46, 19);
            this.labelUnit.TabIndex = 57;
            this.labelUnit.Text = "Unit :";
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 18;
            this.lbProducts.Location = new System.Drawing.Point(20, 49);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(312, 310);
            this.lbProducts.TabIndex = 56;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbUrunler_SelectedIndexChanged);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProduct.Location = new System.Drawing.Point(21, 22);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(114, 22);
            this.labelProduct.TabIndex = 55;
            this.labelProduct.Text = "PRODUCTS";
            // 
            // btnStoreProgess
            // 
            this.btnStoreProgess.Location = new System.Drawing.Point(393, 446);
            this.btnStoreProgess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStoreProgess.Name = "btnStoreProgess";
            this.btnStoreProgess.Size = new System.Drawing.Size(200, 46);
            this.btnStoreProgess.TabIndex = 74;
            this.btnStoreProgess.Text = "Store Progess";
            this.btnStoreProgess.UseVisualStyleBackColor = true;
            this.btnStoreProgess.Click += new System.EventHandler(this.btnStoreProgess_Click);
            // 
            // btnNewSaleProgess
            // 
            this.btnNewSaleProgess.Location = new System.Drawing.Point(655, 448);
            this.btnNewSaleProgess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewSaleProgess.Name = "btnNewSaleProgess";
            this.btnNewSaleProgess.Size = new System.Drawing.Size(139, 44);
            this.btnNewSaleProgess.TabIndex = 75;
            this.btnNewSaleProgess.Text = "New Sale";
            this.btnNewSaleProgess.UseVisualStyleBackColor = true;
            this.btnNewSaleProgess.Click += new System.EventHandler(this.btnNewSlaeProgess_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 505);
            this.Controls.Add(this.btnNewSaleProgess);
            this.Controls.Add(this.btnStoreProgess);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblDamount);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.rbCreditCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.btnOrderCheck);
            this.Controls.Add(this.nudUnit);
            this.Controls.Add(this.btnCalculateTotalAmount);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.labelCart);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.labelAmunt);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.labelProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "SALE PROCESS";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblDamount;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Button btnOrderCheck;
        private System.Windows.Forms.NumericUpDown nudUnit;
        private System.Windows.Forms.Button btnCalculateTotalAmount;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label labelAmunt;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Button btnStoreProgess;
        private System.Windows.Forms.Button btnNewSaleProgess;
    }
}