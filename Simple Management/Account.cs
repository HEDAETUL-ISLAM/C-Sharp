using System;

namespace Simple_Management
{
    public class Account
    {
        private string accountName;
        private string accountId;
        private double balance;

        public Account()
        {

        }
        public Account(string accountName, string accountId, double balance)
        {
            this.accountName = accountName;
            this.accountId = accountId;
            this.balance = balance;
        }
        public string GetAccountName()
        {
            return accountName;
        }
        public string GetAccountId()
        {
            return accountId;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Deposite(double depositeAmmount)
        {
            balance += depositeAmmount;
        }
        public void Withdraw(double withdrawBalance)
        {
            if (balance < withdrawBalance)
            {
                System.Console.WriteLine("Not enough balance. ");
            }
            else
            {
                balance -= withdrawBalance;
            }
        }
        public void BalanceTransfer(double transferAmount, Account receiver)
        {
            if (transferAmount > balance)
            {
                System.Console.WriteLine("Not enough balance. ");
            }
            else
            {
                balance -= transferAmount;
                receiver.balance += transferAmount;
            }
        }
        public void ShowAccountDetails()
        {
            Console.WriteLine("Account Name: " + GetAccountName() + " ," + "Account ID: " + GetAccountId() + " ," + "Balance: " + GetBalance() + " ");
        }



    }
}
