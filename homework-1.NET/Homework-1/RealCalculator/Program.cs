// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the First number");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Second number");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Operation(+,-,*,/)");
string operation = Console.ReadLine();

double result;
if(operation == "+")
{
    result = num1 + num2;
    Console.WriteLine("The result is: " + result);
}
else if(operation == "-")
{
    result = num1 - num2;
    Console.WriteLine("The result is: " + result);
}
else if (operation == "*")
{
    result = num1 * num2;
    Console.WriteLine("The result is: " + result);
}
else if (operation == "/")
{
    result = num1 / num2;
    Console.WriteLine("The result is: " + result);
}
else
{
    Console.WriteLine("Invalid operation");
}