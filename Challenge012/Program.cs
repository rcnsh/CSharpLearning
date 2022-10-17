Console.WriteLine("Enter a number");
int num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter another number");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num2);
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num1);
    Console.WriteLine(num2);
}

