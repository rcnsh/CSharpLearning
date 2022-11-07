Console.WriteLine("Enter a number with lots of decimal places");

double input = Convert.ToDouble(Console.ReadLine());

input = Math.Round(input, 2);

Console.WriteLine(input);