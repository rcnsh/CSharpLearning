Console.WriteLine("How many sweets do you have?");
int sweetsTotal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many sweets have you eaten?");
int sweetsEaten = Convert.ToInt32(Console.ReadLine());

int sweetsLeft = sweetsTotal - sweetsEaten;

Console.WriteLine("You have " + sweetsLeft + " sweets left!");