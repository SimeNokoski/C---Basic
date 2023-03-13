// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = new int[6];
int sumOfEven = 0;

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Enter integer no.{i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] % 2 == 0)
    {
        sumOfEven += arr[i];
    }
}
Console.WriteLine("The result is: " + sumOfEven);