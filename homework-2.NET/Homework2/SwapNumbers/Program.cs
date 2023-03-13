// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input the First Number: {num1}");
Console.WriteLine($"Input the Second Number: {num2}");

int temp;
temp = num1;
num1 = num2;
num2 = temp;

Console.WriteLine("After Swapping");
Console.WriteLine($"First Number: {num1}");
Console.WriteLine($"Second Number: {num2}");


