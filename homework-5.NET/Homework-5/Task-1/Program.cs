
void NumberStats(double num)
{
    if(num >= 0)
    {
        Console.WriteLine("Positive");
    }
    else
    {
        Console.WriteLine("Negative");
    }
    if(num % 1 == 0)
    {
        Console.WriteLine("Integer");
    }
    else
    {
        Console.WriteLine("Decimal");
    }
    if(num % 2 == 0)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
}
    while (true)
    {
    Console.WriteLine("Enter a number:");
    string input = Console.ReadLine();
    bool validate = double.TryParse(input, out double number);
    if (validate)
    {    
        NumberStats(number); 
    }
    else
    {
        Console.WriteLine("Invalid number");
    }
    Console.WriteLine("Press Y to try again or X to exit");
    string XorY = Console.ReadLine();
    if (XorY.ToUpper() == "X")
    {
        break;
    }
    }
 
 