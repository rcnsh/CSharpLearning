Console.WriteLine("1) Triangle");
Console.WriteLine("2) Square");
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Please enter your choice: ");

int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine("Enter the length of the side of the triangle: ");
    
    int side = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("The area of the triangle is: " + (side * side * 1/2));
    
}
else if (choice == 2)
{
    Console.WriteLine("Enter the length of the side of the square: ");
    
    int side = Convert.ToInt32(Console.ReadLine());
    double area = (int)Math.Pow(side, 2);
    
    Console.WriteLine("The area of the square is: " + area);
}
else
{
    Console.WriteLine("Invalid choice");
}