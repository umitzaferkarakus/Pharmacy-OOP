namespace Ödev21_12
{
    partial class Form2
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
            this.btnStoreProcess = new System.Windows.Forms.Button();
            this.btnSalesProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStoreProcess
            // 
            this.btnStoreProcess.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStoreProcess.Location = new System.Drawing.Point(187, 116);
            this.btnStoreProcess.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnStoreProcess.Name = "btnStoreProcess";
            this.btnStoreProcess.Size = new System.Drawing.Size(135, 64);
            this.btnStoreProcess.TabIndex = 11;
            this.btnStoreProcess.Text = "Store Process";
            this.btnStoreProcess.UseVisualStyleBackColor = true;
            this.btnStoreProcess.Click += new System.EventHandler(this.btnStoreProcess_Click);
            // 
            // btnSalesProcess
            // 
            this.btnSalesProcess.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesProcess.Location = new System.Drawing.Point(56, 116);
            this.btnSalesProcess.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalesProcess.Name = "btnSalesProcess";
            this.btnSalesProcess.Size = new System.Drawing.Size(120, 64);
            this.btnSalesProcess.TabIndex = 10;
            this.btnSalesProcess.Text = "Sales Process";
            this.btnSalesProcess.UseVisualStyleBackColor = true;
            this.btnSalesProcess.Click += new System.EventHandler(this.btnSalesProcess_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnStoreProcess);
            this.Controls.Add(this.btnSalesProcess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Select Process";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStoreProcess;
        private System.Windows.Forms.Button btnSalesProcess;
    }
}