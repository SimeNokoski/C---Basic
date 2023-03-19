
Console.WriteLine("Enter a sentence:");
string inputString = Console.ReadLine();
string[] splitString = inputString.Split(" ");

foreach (string line in splitString)
{
    Console.WriteLine(line);
}
