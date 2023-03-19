
void AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthday.Year;
    
    if(birthday > today.AddYears(-age))
    {
        age--;
        Console.WriteLine($"I am {age} years old");
    }
    else if(birthday.AddYears(age) == today)
    {
        Console.WriteLine($"Today is my {age}th birthday");
    }
    else
    {
        Console.WriteLine($"I am {age} years old");
    }
}
Console.WriteLine("Enter your date of birth (YYYY-MM-DD)");
string inputDate = Console.ReadLine();
DateTime convertInputDate = Convert.ToDateTime(inputDate);
AgeCalculator(convertInputDate);