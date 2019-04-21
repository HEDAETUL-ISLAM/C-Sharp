using System;

namespace Simple_Management
{

    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                System.Console.WriteLine("For Account press 'a' , For Contact press 'c', For Book press 'b': ");
                string userOption = Console.ReadLine();
                if(userOption == "a" || userOption == "A"){
                    System.Console.WriteLine("Enter First Account Name, ID, Balance: ");
                    Account account = new Account(Console.ReadLine(), Console.ReadLine(), Double.Parse(Console.ReadLine()));
                    account.ShowAccountDetails();

                    System.Console.WriteLine("For Deposite press 'd' For Withdraw press 'w' For Transfer press 't': ");
                    string AccountInput = Console.ReadLine();
                    if (AccountInput == "d" || AccountInput == "D")
                    {
                        Console.WriteLine("Enter deposite balance: ");
                        account.Deposite(Double.Parse(Console.ReadLine()));
                        account.ShowAccountDetails();
                    }
                    else if (AccountInput == "w" || AccountInput == "W")
                    {
                        Console.WriteLine("Enter Withdraw balance: ");
                        account.Withdraw(Double.Parse(Console.ReadLine()));
                        account.ShowAccountDetails();
                    }
                    else if (AccountInput == "t" || AccountInput == "T")
                    {
                        System.Console.WriteLine("Enter Second Account Name, ID, Balance: ");
                        Account account2 = new Account(Console.ReadLine(), Console.ReadLine(), Double.Parse(Console.ReadLine()));
                        account2.ShowAccountDetails();

                        Console.WriteLine("Do u want to transfer money? y or n : ");
                        string transferMoney = Console.ReadLine();
                        if (transferMoney == "y" || transferMoney == "Y")
                        {
                            Console.Write("Enter amount for transfer: ");
                            account2.BalanceTransfer(Double.Parse(Console.ReadLine()), account);
                        }
                        account.ShowAccountDetails();
                        account2.ShowAccountDetails();
                    }
                }
                else if(userOption == "b" || userOption == "B"){
                    System.Console.WriteLine("Enter Book name, author, id, type, book copy: ");
                    Book book = new Book(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                    book.ShowInfo();

                    book.AddBookCopy(Convert.ToInt32(Console.ReadLine()));
                    book.ShowInfo();
                }
                else if(userOption == "c" || userOption == "C"){
                    System.Console.WriteLine("Enter Person Name, id, age, mobile no, gender: ");
                    Contact contact = new Contact(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Char.Parse(Console.ReadLine()));
                    contact.ShowPersonInfo();
                    contact.DetectorMobileOperator();
                }

            }
            catch (Exception)
            {
                System.Console.WriteLine("Sorry wrong input");
            }



        }

    }

}