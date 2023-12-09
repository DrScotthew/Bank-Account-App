//3-27-22
//This program uses a WFA to allow user to deposit, withdraw, and see their account balance from a fictional atm/bank account
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment5_BankAccount
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BankForm());
        }
    }
}
