Console.WriteLine("Enter 1, 2 or 3.");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Thank you!");
}
else if (num == 2)
{
    Console.WriteLine("Well done!");
}
else if (num == 3)
{
    Console.WriteLine("Correct");
}
else
{
    Console.WriteLine("Error: 1, 2 or 3 not entered");
}