using Task_2;

User[] users = new User[3]
{
    new User { Id = 1,Username = "Sime",Password = "Sime123",Messages = new string[] {"Messages1","Messages2"}},
    new User { Id = 2,Username = "Rozeta",Password = "Rozeta123",Messages = new string[] {"Messages3","Messages4"}},
    new User { Id = 3,Username = "Marko",Password = "Marko123",Messages = new string[] {"Messages5","Messages6"}},
};
Console.WriteLine("1-Log in or 2-Register");
int oneOrTwo = Convert.ToInt32(Console.ReadLine());
if(oneOrTwo == 1)
{
    Console.WriteLine("Enter Username");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Password");
    string password = Console.ReadLine();
    User user1 = null;
    foreach(User user in users)
    {
        if(user.Username == username &&  user.Password == password)
        {
         user1 = user;
            break;
        }
    }
    if(user1 == null)
    {
        Console.WriteLine("Err");
    }
    else
    {
        Console.WriteLine($"Welcome {user1.Username}.Here are your messages:");
       foreach(string msg in user1.Messages)
        {
            Console.WriteLine (msg);
        }
    }
}
else if(oneOrTwo == 2)
{
    Console.WriteLine("Enter Id");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Username");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Password");
    string password = Console.ReadLine();

    foreach(User user in users)
    {
        if(user.Username == username)
        {
            Console.WriteLine("Existing Username");
            break;
        }
        else
        {
            User newUser = new User { Id = id,Username = username,Password = password,Messages = new string[] {"NewMessage1","NewMessage2" } };
            Array.Resize(ref users , users.Length+1);
            users[users.Length-1] = newUser;
            foreach(User name in users)
            {
                Console.WriteLine(name.Username);
            }
            break;
        }
    }

}
else
{
    Console.WriteLine("Invalid input");
}