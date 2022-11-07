Console.WriteLine("Enter two numbers");

int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());

double answer = a / b;

double remainder = a % b;

Console.WriteLine("The answer is {0} with a remainder of {1}", answer, remainder);