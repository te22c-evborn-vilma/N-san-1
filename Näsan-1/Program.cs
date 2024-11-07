// Punkt 1
if (6 > 3 || 6 == 3)
{
    Console.WriteLine("Hello World!");
}

// Punkt 2 och 3
Console.WriteLine("Please write your username");
string answer1 = Console.ReadLine();
Console.WriteLine("Please write your password");
string answer2 = Console.ReadLine();

if (answer1 == "noname" && answer2 == "nopass")
{
    Console.WriteLine("Welcome");
}
else 
{
    Console.WriteLine("Wrong username or password");
}

// Punkt 4
for (int i = 0; i < 32; i++)
{
    Console.WriteLine("Hello, World");
}



Console.ReadLine();