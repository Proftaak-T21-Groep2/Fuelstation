namespace CarCenter
{
    partial class Tankstation
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
            this.Lbl = new System.Windows.Forms.Label();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDummyTest = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(37, 107);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(36, 13);
            this.Lbl.TabIndex = 3;
            this.Lbl.Text = "server";
            // 
            // ServerLbl
            // 
            this.ServerLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerLbl.Location = new System.Drawing.Point(92, 106);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(444, 23);
            this.ServerLbl.TabIndex = 4;
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(12, 100);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(444, 121);
            this.listBoxCars.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "11-KTF-6 \r\nLPG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "40-NZ-SP \r Diesel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDummyTest
            // 
            this.btnDummyTest.Location = new System.Drawing.Point(346, 63);
            this.btnDummyTest.Name = "btnDummyTest";
            this.btnDummyTest.Size = new System.Drawing.Size(75, 23);
            this.btnDummyTest.TabIndex = 30;
            this.btnDummyTest.Text = "Betaal";
            this.btnDummyTest.UseVisualStyleBackColor = true;
            this.btnDummyTest.Click += new System.EventHandler(this.btnDummyTest_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 31;
            this.button3.Text = "59-FK-FB \r\nPetrol";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tankstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 242);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDummyTest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxCars);
            this.Name = "Tankstation";
            this.Text = "Tankstation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Button btnDummyTest;
        private System.Windows.Forms.Button button3;

    }
}

