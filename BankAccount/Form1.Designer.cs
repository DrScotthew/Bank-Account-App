namespace ProgrammingAssignment5_BankAccount
{
    partial class BankForm
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
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.btnCheckAccountBalance = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.Location = new System.Drawing.Point(13, 13);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(187, 48);
            this.btnDepositMoney.TabIndex = 0;
            this.btnDepositMoney.Text = "Deposit";
            this.btnDepositMoney.UseVisualStyleBackColor = true;
            this.btnDepositMoney.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.Location = new System.Drawing.Point(13, 88);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(187, 48);
            this.btnWithdrawMoney.TabIndex = 1;
            this.btnWithdrawMoney.Text = "Withdrawal";
            this.btnWithdrawMoney.UseVisualStyleBackColor = true;
            this.btnWithdrawMoney.Click += new System.EventHandler(this.btnWithdrawMoney_Click);
            // 
            // btnCheckAccountBalance
            // 
            this.btnCheckAccountBalance.Location = new System.Drawing.Point(12, 167);
            this.btnCheckAccountBalance.Name = "btnCheckAccountBalance";
            this.btnCheckAccountBalance.Size = new System.Drawing.Size(188, 48);
            this.btnCheckAccountBalance.TabIndex = 2;
            this.btnCheckAccountBalance.Text = "Account Balance";
            this.btnCheckAccountBalance.UseVisualStyleBackColor = true;
            this.btnCheckAccountBalance.Click += new System.EventHandler(this.btnCheckAccountBalance_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(273, 88);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(157, 48);
            this.txtAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(269, 65);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(114, 20);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Enter amount :";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(269, 167);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 6;
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 402);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnCheckAccountBalance);
            this.Controls.Add(this.btnWithdrawMoney);
            this.Controls.Add(this.btnDepositMoney);
            this.Name = "BankForm";
            this.Text = "Bank Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.Button btnWithdrawMoney;
        private System.Windows.Forms.Button btnCheckAccountBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.Label lblMessage;
    }
}

