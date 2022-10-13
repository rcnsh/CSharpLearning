Console.WriteLine("What is the price of the bill?");
decimal bill = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("How many people are paying?");
int people = Convert.ToInt32(Console.ReadLine());

decimal ppp = bill / people;

Console.WriteLine("Each person should pay £" + ppp + "!");