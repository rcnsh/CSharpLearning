Console.WriteLine("Enter the radius of a circle");

double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the depth of the cylinder");

double depth = Convert.ToDouble(Console.ReadLine());

double volume = Math.PI * radius * radius * depth;

Console.WriteLine("The volume of the cylinder is {0}", volume);