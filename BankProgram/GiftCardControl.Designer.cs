namespace BankProgram
{
    partial class GiftCardControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tbMakeDeposit = new System.Windows.Forms.TextBox();
            this.tbMakeWithdrawal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMakeDeposit = new System.Windows.Forms.Button();
            this.btnMakeWithdrawal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(113, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "UndefinedName";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(113, 86);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "GiftCard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(113, 134);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(95, 13);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "UndefinedBalance";
            // 
            // tbMakeDeposit
            // 
            this.tbMakeDeposit.Location = new System.Drawing.Point(39, 224);
            this.tbMakeDeposit.Name = "tbMakeDeposit";
            this.tbMakeDeposit.Size = new System.Drawing.Size(100, 20);
            this.tbMakeDeposit.TabIndex = 6;
            this.tbMakeDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMakeDeposit_KeyDown);
            // 
            // tbMakeWithdrawal
            // 
            this.tbMakeWithdrawal.Location = new System.Drawing.Point(39, 291);
            this.tbMakeWithdrawal.Name = "tbMakeWithdrawal";
            this.tbMakeWithdrawal.Size = new System.Drawing.Size(100, 20);
            this.tbMakeWithdrawal.TabIndex = 7;
            this.tbMakeWithdrawal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMakeWithdrawal_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Внести";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Снять";
            // 
            // btnMakeDeposit
            // 
            this.btnMakeDeposit.Location = new System.Drawing.Point(145, 222);
            this.btnMakeDeposit.Name = "btnMakeDeposit";
            this.btnMakeDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnMakeDeposit.TabIndex = 10;
            this.btnMakeDeposit.Text = "Выполнить";
            this.btnMakeDeposit.UseVisualStyleBackColor = true;
            this.btnMakeDeposit.Click += new System.EventHandler(this.btnMakeDeposit_Click);
            // 
            // btnMakeWithdrawal
            // 
            this.btnMakeWithdrawal.Location = new System.Drawing.Point(145, 288);
            this.btnMakeWithdrawal.Name = "btnMakeWithdrawal";
            this.btnMakeWithdrawal.Size = new System.Drawing.Size(75, 23);
            this.btnMakeWithdrawal.TabIndex = 11;
            this.btnMakeWithdrawal.Text = "Выполнить";
            this.btnMakeWithdrawal.UseVisualStyleBackColor = true;
            this.btnMakeWithdrawal.Click += new System.EventHandler(this.btnMakeWithdrawal_Click);
            // 
            // GiftCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMakeWithdrawal);
            this.Controls.Add(this.btnMakeDeposit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMakeWithdrawal);
            this.Controls.Add(this.tbMakeDeposit);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GiftCardControl";
            this.Text = "CardControl";
            this.Load += new System.EventHandler(this.GiftCardControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox tbMakeDeposit;
        private System.Windows.Forms.TextBox tbMakeWithdrawal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMakeDeposit;
        private System.Windows.Forms.Button btnMakeWithdrawal;
    }
}