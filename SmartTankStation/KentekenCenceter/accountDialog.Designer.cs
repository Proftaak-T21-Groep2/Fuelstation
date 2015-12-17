namespace CarCenter
{
    partial class accountDialog
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.tbBankNumber = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.tbPincode = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.tbCredit1 = new System.Windows.Forms.TextBox();
            this.tbCredit2 = new System.Windows.Forms.TextBox();
            this.lblKomma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(268, 103);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 58);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(331, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(9, 48);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(114, 13);
            this.lblBank.TabIndex = 4;
            this.lblBank.Text = "Bankaccount Number:";
            // 
            // tbBankNumber
            // 
            this.tbBankNumber.Location = new System.Drawing.Point(12, 64);
            this.tbBankNumber.Name = "tbBankNumber";
            this.tbBankNumber.Size = new System.Drawing.Size(331, 20);
            this.tbBankNumber.TabIndex = 3;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(9, 125);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(49, 13);
            this.lblPin.TabIndex = 6;
            this.lblPin.Text = "Pincode:";
            // 
            // tbPincode
            // 
            this.tbPincode.Location = new System.Drawing.Point(12, 141);
            this.tbPincode.Name = "tbPincode";
            this.tbPincode.Size = new System.Drawing.Size(234, 20);
            this.tbPincode.TabIndex = 5;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(9, 86);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(62, 13);
            this.lblCredit.TabIndex = 8;
            this.lblCredit.Text = "Start Credit:";
            // 
            // tbCredit1
            // 
            this.tbCredit1.Location = new System.Drawing.Point(12, 102);
            this.tbCredit1.Name = "tbCredit1";
            this.tbCredit1.Size = new System.Drawing.Size(73, 20);
            this.tbCredit1.TabIndex = 7;
            // 
            // tbCredit2
            // 
            this.tbCredit2.Location = new System.Drawing.Point(104, 102);
            this.tbCredit2.Name = "tbCredit2";
            this.tbCredit2.Size = new System.Drawing.Size(32, 20);
            this.tbCredit2.TabIndex = 9;
            // 
            // lblKomma
            // 
            this.lblKomma.AutoSize = true;
            this.lblKomma.Location = new System.Drawing.Point(88, 109);
            this.lblKomma.Name = "lblKomma";
            this.lblKomma.Size = new System.Drawing.Size(13, 13);
            this.lblKomma.TabIndex = 10;
            this.lblKomma.Text = " ,";
            // 
            // accountDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 173);
            this.Controls.Add(this.lblKomma);
            this.Controls.Add(this.tbCredit2);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.tbCredit1);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.tbPincode);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.tbBankNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnConfirm);
            this.Name = "accountDialog";
            this.Text = "accountDialog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.TextBox tbBankNumber;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox tbPincode;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox tbCredit1;
        private System.Windows.Forms.TextBox tbCredit2;
        private System.Windows.Forms.Label lblKomma;
    }
}