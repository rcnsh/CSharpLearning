Console.WriteLine("Enter a number.");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
{
    Console.WriteLine("Too low");
}
else if (num > 20)
{
    Console.WriteLine("Too high.");
}
else
{
    Console.WriteLine("You got it!");
}