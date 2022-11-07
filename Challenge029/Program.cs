Console.WriteLine("Enter a number over 500");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 500)
{
    double squareRoot = Math.Sqrt(number);
    Console.WriteLine("The square root of {0} is {1}", number, squareRoot);
}

else
{
    Console.WriteLine("Number is not over 500");
}