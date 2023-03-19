
Console.WriteLine("Enter a string");
string inputString = Console.ReadLine();

if (inputString.Length > 4)
{
    string last5Characters = inputString.Substring(inputString.Length - 5);
    Console.WriteLine($"Last 5 characters: {last5Characters}");
}
else
{
    Console.WriteLine("String has less than 5 characters");
}