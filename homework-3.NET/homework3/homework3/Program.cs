
double Sum(double num1,double num2)
{
    return num1 + num2;
}
double Subtract(double num1, double num2)
{
    return num1 - num2;
}
double Divide(double num1, double num2)
{
return num1 / num2;
}
double Multiply(double num1, double num2)
{
    return num1 * num2;
}

void Calculator(char operation,double num1,double num2)
{
    double result;
    switch (operation)
    {
        case '+':
            result = Sum(num1,num2);
            Console.WriteLine($"The result is: {result}");
            break;
        case '-':
            result = Subtract(num1,num2);
            Console.WriteLine($"The result is: {result}");
            break;
        case '/':
            if(num2 == 0)
            {
                Console.WriteLine("The number 0 is not a divisible number");
            }
            else
            {
                result = Divide(num1, num2);
                Console.WriteLine($"The result is: {result}");
            }
            break;
        case '*':
            result = Multiply(num1,num2);
            Console.WriteLine($"The result is: {result}");
            break;
        default:
            Console.WriteLine("Invalid operation");
            break;
    }
}
Console.WriteLine("Enter number 1:");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter number 2:");
double number2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an operator(+, -, / or *)");
char operation = char.Parse(Console.ReadLine());
 
Calculator(operation, number1, number2); 
