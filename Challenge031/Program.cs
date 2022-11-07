Console.WriteLine("Enter the radius of a circle in metres");

double radius = Convert.ToDouble(Console.ReadLine());

double area = Math.PI * radius * radius;

Console.WriteLine("The area of the circle is {0}m^2", area);