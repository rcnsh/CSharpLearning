Console.WriteLine("Enter a number.");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter another number.");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter another number.");
int Num3 = Convert.ToInt32(Console.ReadLine());

int firststage = Num1 + Num2;

int answer = firststage / Num3;

Console.WriteLine("The answer is " + answer);