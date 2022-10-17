Console.WriteLine("Enter a number between 10 and 20");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 20)
{
    Console.WriteLine("Thanks!");
}
else
{
    Console.WriteLine("Incorrect answer.");
}