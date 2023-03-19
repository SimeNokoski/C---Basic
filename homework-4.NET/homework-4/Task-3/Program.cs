 int Sum(int num)
{
    int sum = 0; 
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
int result = Sum(number);
Console.WriteLine($"The sum of digits in the number {number} is: {result}");