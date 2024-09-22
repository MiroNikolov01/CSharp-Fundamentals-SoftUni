string username = Console.ReadLine();
string password = string.Empty;
for (int i = username.Length - 1; i >= 0; i--)
{
    password += username[i];
}
int attempt = 4;
while (attempt > 0)
{
    string typePassword = Console.ReadLine();
    attempt -= 1;
    if (typePassword == password)
    {
    Console.WriteLine($"User {username} logged in.");
        break;
    }
    if (attempt == 0)
    {
        Console.WriteLine($"User {username} blocked!");
        break; ;
    }
    Console.WriteLine("Incorrect password. Try again.");
}
