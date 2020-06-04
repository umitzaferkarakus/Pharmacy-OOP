namespace Ödev21_12
{
    partial class Form1
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
            this.txtInsuranceNo = new System.Windows.Forms.TextBox();
            this.labelSigortaNo = new System.Windows.Forms.Label();
            this.btnKasiyerGiris = new System.Windows.Forms.Button();
            this.txtCashierSurname = new System.Windows.Forms.TextBox();
            this.labelKasiyerSoyad = new System.Windows.Forms.Label();
            this.txtCashierName = new System.Windows.Forms.TextBox();
            this.labelKasiyerAd = new System.Windows.Forms.Label();
            this.labelKasiyerGiris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInsuranceNo
            // 
            this.txtInsuranceNo.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInsuranceNo.Location = new System.Drawing.Point(160, 156);
            this.txtInsuranceNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInsuranceNo.Name = "txtInsuranceNo";
            this.txtInsuranceNo.Size = new System.Drawing.Size(192, 28);
            this.txtInsuranceNo.TabIndex = 3;
            // 
            // labelSigortaNo
            // 
            this.labelSigortaNo.AutoSize = true;
            this.labelSigortaNo.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSigortaNo.Location = new System.Drawing.Point(37, 160);
            this.labelSigortaNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSigortaNo.Name = "labelSigortaNo";
            this.labelSigortaNo.Size = new System.Drawing.Size(117, 21);
            this.labelSigortaNo.TabIndex = 20;
            this.labelSigortaNo.Text = "Insurance No:";
            // 
            // btnKasiyerGiris
            // 
            this.btnKasiyerGiris.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasiyerGiris.Location = new System.Drawing.Point(236, 217);
            this.btnKasiyerGiris.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKasiyerGiris.Name = "btnKasiyerGiris";
            this.btnKasiyerGiris.Size = new System.Drawing.Size(117, 39);
            this.btnKasiyerGiris.TabIndex = 4;
            this.btnKasiyerGiris.Text = "Login";
            this.btnKasiyerGiris.UseVisualStyleBackColor = true;
            this.btnKasiyerGiris.Click += new System.EventHandler(this.btnCashierEntry_Click);
            // 
            // txtCashierSurname
            // 
            this.txtCashierSurname.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCashierSurname.Location = new System.Drawing.Point(160, 119);
            this.txtCashierSurname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCashierSurname.Name = "txtCashierSurname";
            this.txtCashierSurname.Size = new System.Drawing.Size(192, 28);
            this.txtCashierSurname.TabIndex = 2;
            // 
            // labelKasiyerSoyad
            // 
            this.labelKasiyerSoyad.AutoSize = true;
            this.labelKasiyerSoyad.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKasiyerSoyad.Location = new System.Drawing.Point(37, 123);
            this.labelKasiyerSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelKasiyerSoyad.Name = "labelKasiyerSoyad";
            this.labelKasiyerSoyad.Size = new System.Drawing.Size(79, 21);
            this.labelKasiyerSoyad.TabIndex = 17;
            this.labelKasiyerSoyad.Text = "Surname:";
            // 
            // txtCashierName
            // 
            this.txtCashierName.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCashierName.Location = new System.Drawing.Point(160, 82);
            this.txtCashierName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCashierName.Name = "txtCashierName";
            this.txtCashierName.Size = new System.Drawing.Size(192, 28);
            this.txtCashierName.TabIndex = 1;
            this.txtCashierName.TextChanged += new System.EventHandler(this.txtCashierName_TextChanged);
            // 
            // labelKasiyerAd
            // 
            this.labelKasiyerAd.AutoSize = true;
            this.labelKasiyerAd.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKasiyerAd.Location = new System.Drawing.Point(37, 86);
            this.labelKasiyerAd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelKasiyerAd.Name = "labelKasiyerAd";
            this.labelKasiyerAd.Size = new System.Drawing.Size(60, 21);
            this.labelKasiyerAd.TabIndex = 15;
            this.labelKasiyerAd.Text = "Name:";
            // 
            // labelKasiyerGiris
            // 
            this.labelKasiyerGiris.AutoSize = true;
            this.labelKasiyerGiris.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKasiyerGiris.Location = new System.Drawing.Point(37, 48);
            this.labelKasiyerGiris.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelKasiyerGiris.Name = "labelKasiyerGiris";
            this.labelKasiyerGiris.Size = new System.Drawing.Size(112, 21);
            this.labelKasiyerGiris.TabIndex = 14;
            this.labelKasiyerGiris.Text = "Cashier Entry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 321);
            this.Controls.Add(this.txtInsuranceNo);
            this.Controls.Add(this.labelSigortaNo);
            this.Controls.Add(this.btnKasiyerGiris);
            this.Controls.Add(this.txtCashierSurname);
            this.Controls.Add(this.labelKasiyerSoyad);
            this.Controls.Add(this.txtCashierName);
            this.Controls.Add(this.labelKasiyerAd);
            this.Controls.Add(this.labelKasiyerGiris);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PHARMACY AUTOMATİON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInsuranceNo;
        private System.Windows.Forms.Label labelSigortaNo;
        private System.Windows.Forms.Button btnKasiyerGiris;
        private System.Windows.Forms.TextBox txtCashierSurname;
        private System.Windows.Forms.Label labelKasiyerSoyad;
        private System.Windows.Forms.TextBox txtCashierName;
        private System.Windows.Forms.Label labelKasiyerAd;
        private System.Windows.Forms.Label labelKasiyerGiris;
    }
}

