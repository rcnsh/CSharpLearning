Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You can vote.");
}
else if (age == 17)
{
    Console.WriteLine("You can learn to drive");
}
else if(age == 16)
{
    Console.WriteLine("You can buy a lottery ticket!");
}
else
{
    Console.WriteLine("You can go trick or treating!");
}