// See https://aka.ms/new-console-template for more information

using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Transaction transaction = new Transaction();


        transaction.setdate(new DateTime (2008, 6, 1));
        transaction.setval ( 10.5f);

        Console.WriteLine("Transaction value is " + transaction.getval() + "at time "+ transaction.getDate().ToString() );

    }
}

