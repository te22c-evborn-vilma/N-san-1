// Punkt 1
if (6 > 3 || 6 == 3)
{
    Console.WriteLine("Hello World!");
}

// Punkt 4
for (int i = 0; i < 32; i++)
{
    Console.WriteLine("Hello, World");
}

// Punkt 2 och 3
Console.WriteLine("Please write your username");
string answer1 = Console.ReadLine();

string answer2 = ""; // Punkt 5
while (answer2 != "nopass")
{
    Console.WriteLine("Please write your password");
    answer2 = Console.ReadLine();
}

if (answer1 == "noname" && answer2 == "nopass")
{
    Console.WriteLine("Welcome");
}
else 
{
    Console.WriteLine("Wrong username or password");
}

// Punkt 6
for (int j = 0; j < 5; j++)
{
    Console.WriteLine("Please write a number");
    string answer3 = Console.ReadLine();
    int number;
    bool success = int.TryParse(answer3, out number);
    if (number > 5)
    {
        Console.WriteLine("högre än 5!");
    }
}

// Punkt 7 - osäker på tryparse
bool successful = false;
while (successful == false)
{
    Console.WriteLine("Please write a number or something");
    string convert = Console.ReadLine();
    int number;
    successful = int.TryParse(convert, out number);
}

// Punkt 8 - SLUTÖVNING
int rNum= Random.Shared.Next();
// string guess = "";
// while (guess == )
// {
//     Console.WriteLine("Guess the number");
//     guess = Console.ReadLine();
//     int guessedNum;
//     bool success = int.TryParse(guess, out guessedNum);
    
//     if (guessedNum > rNum)
//     {
//         Console.WriteLine("Your guess is too high");
//     }
//     else if (guessedNum < rNum)
//     {
//         Console.WriteLine("Your guess is too low");
//     }
//     else 
//     {
//         Console.WriteLine("Your guess is correct");
//     }
// }


Console.ReadLine();