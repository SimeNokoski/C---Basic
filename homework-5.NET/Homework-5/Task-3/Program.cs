
using Task_3;
Customer[] customers = new Customer[3]
{
    new Customer("Sime",1234123412341234,1234,5000),
    new Customer("Marko",1111111111111111,1111,1000),
    new Customer("Dajo",2222222222222222,2222,2000)
};
while (true)
{
    Console.WriteLine("Enter 1-Log in / 2-Register /3-Exit");
    int regOrLog = Convert.ToInt32(Console.ReadLine());
    if (regOrLog == 1)
    {

        Console.WriteLine("Welcome to the ATM app");
        Console.WriteLine("Please enter your card numer:");
        long cardNumber = long.Parse(Console.ReadLine().Replace("-", ""));
        Console.WriteLine("Enter Pin");
        int pin = Convert.ToInt32(Console.ReadLine());
        Customer customer1 = null;
        foreach (Customer customer in customers)
        {
            if (customer.CardNumber == cardNumber && customer.Pin == pin)
            {
                customer1 = customer;
                break;
            }
        }

        if (customer1 == null)
        {
            Console.WriteLine("Err");
        }
        else
        {
            Console.WriteLine($"Welcome {customer1.Name}");
            while (true)
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("1-Check Balance");
                Console.WriteLine("2-Cash Withdrawal");
                Console.WriteLine("3-Cash Deposit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"You have {customer1.Balance}$.");
                        break;
                    case 2:
                        Console.WriteLine("How much money to withdraw");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        if (withdraw > customer1.Balance)
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        else
                        {
                            customer1.Balance -= withdraw;
                            Console.WriteLine($"You withdrew {withdraw}$. You have {customer1.Balance}$ left on your account.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the amount to deposit:");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        customer1.Balance += deposit;
                        Console.WriteLine($"You deposited {deposit}$.New balance is {customer1.Balance}$.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Do you want to do another action Y/N");
                string YorN = Console.ReadLine();
                if (YorN.ToUpper() == "N")
                {
                    Console.WriteLine($"Goodbye {customer1.Name}");
                    Console.WriteLine("Thank you for using the ATM app.");
                    break;
                }
            }
        }
    }

    else if (regOrLog == 2)
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter card numer");
        long cardNum2 = Convert.ToInt64(Console.ReadLine().Replace("-", ""));
        Console.WriteLine("Enter pin");
        int pin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter balance");
        double balance = Convert.ToDouble(Console.ReadLine());
      foreach(Customer a in customers)
        {
            if(a.CardNumber == cardNum2)
            {
                Console.WriteLine("Existing card number");
                break;
            }
            else
            {
                Customer newcustomer = new Customer(name, cardNum2, pin, balance);
                Array.Resize(ref customers, customers.Length + 1);
                customers[customers.Length - 1] = newcustomer;
                Console.WriteLine("Successful registration");
                break;
            }
        }
       
    }
    else if (regOrLog == 3)
    {
        break;
    }
}