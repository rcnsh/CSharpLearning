Console.WriteLine("Is it raining?");
string answer = Console.ReadLine();

if (answer.ToLower() == "yes")
{
    Console.WriteLine("Is it windy?");
    answer = Console.ReadLine();
    if (answer.ToLower() == "yes")
    {
        Console.WriteLine("It's too windy for an umbrella.");
    }
    else
    {
        Console.WriteLine("Bring an Umbrella");
    }
}
else
{
    Console.WriteLine("Enjoy your day!");
}