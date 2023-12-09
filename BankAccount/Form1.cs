//Scott Winchester
//CS351
//Programming Assignment 5 - Bank Account GUI
//Program goal - Allows user to input money into bank account, withdraw money from
//bank account and check bank account balance.  Program handles exceptions
//which include negative balances and invalid inputs from user.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment5_BankAccount
{

    public partial class BankForm : Form

    {

        BankAccount _bankAccount;

        public BankForm()

        {

            InitializeComponent();

            _bankAccount = new BankAccount("First Account", "8675309", 0);  //creates a new bank account each time form is opened.

        }

        private void btnDeposit_Click(object sender, EventArgs e)

        {

            //allows user to input in text box and deposit whatever was in text box into their bank account total

            try

            {

                double amount = Convert.ToDouble(txtAmount.Text);

                _bankAccount.Add(amount);

                lblMessage.Text = "Deposit successful!  Thank you!";

                txtAmount.Text = string.Empty;

            }

            catch (Exception ex)

            {

                //if nothing was in text box, exception follows

                lblMessage.Text = ex.Message;

            }

        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)

        {

            //If clicked, this allows user to withdraw money that they entered in the text box

            try
            {

                double amount = Convert.ToDouble(txtAmount.Text);

                _bankAccount.Withdraw(amount); 

                lblMessage.Text = "Withdrawal successful!  Thank you!";

                txtAmount.Text = string.Empty;

            }

            catch (Exception ex)

            {

                //if nothing was in text box, exception follows

                lblMessage.Text = ex.Message;

            }

        }

        private void btnCheckAccountBalance_Click(object sender, EventArgs e)

        {

            //This checks the account balance that the bank account currently has if clicked.

            lblMessage.Text = "This account balace : " + _bankAccount.AccountBalance.ToString();

            txtAmount.Text = string.Empty;

        }

    }


    public class BankAccount

    {

        
        public BankAccount(string name, string iD, double accountBalance)

        {

            Name = name;

            ID = iD;

            AccountBalance = accountBalance;

        }


        public string ID { get; set; }

        public double AccountBalance { get; set; }

        public string Name { get; set; }

        

        

        public void Add(double amount)

        {

            if (amount > 0)

            {

                if (amount < 1000)

                {

                    AccountBalance = AccountBalance + amount;

                }

                else

                {

                    //if input user makes is over 1000 then this shows that the amount was over 1000.

                    throw new TooLargeException("Input is too large.  Please input a smaller amount.");

                }

            }

            else

            {

               

                throw new NegativeDepositException("Invalid input.  Please enter a valid amount.");

            }

        }

        

        public void Withdraw(double amount)

        {

            if (AccountBalance - amount > 0)

            {

                AccountBalance = AccountBalance - amount;

            }

            else

            {

                //if a negative bank account balance will follow then this error will show to the user

                throw new NegativeBalanceException("Error, account balance cannot be negative.");

            }

        }

    }

    
        public class NegativeDepositException : Exception

        {

            

            

            

            public NegativeDepositException(String message)

              : base(message)

            {

            }

            

            

    }


    

    public class TooLargeException : Exception

    {


        public TooLargeException(String message)

          : base(message)

        {

        }

    }


    public class NegativeBalanceException : Exception

    {


        public NegativeBalanceException(String message)

          : base(message)

        {

        }

        

    }


    





}