int x = 0;
while (x == 0)
{
    Console.WriteLine("Do you want to convert pounds to euros or euros to pounds?");
    Console.WriteLine("1. Pounds to Euros");
    Console.WriteLine("2. Euros to Pounds");
    Console.WriteLine("3. Exit" + Environment.NewLine);
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine("Enter a number of pounds to convert to euros." + Environment.NewLine);

        double pounds = Convert.ToDouble(Console.ReadLine());
        double euros = pounds * 1.14;

        Console.WriteLine("£" + pounds + " is equal to € " + euros + Environment.NewLine);
    }
    
    if (choice == 2)
    {
        Console.WriteLine("Enter a number of euros to convert to pounds." + Environment.NewLine);
        double euros = Convert.ToDouble(Console.ReadLine());
        double pounds = euros / 1.14;
        
        Console.WriteLine("€" + euros + " is equal to £ " + pounds + Environment.NewLine);
    }

    if (choice == 3)
    {
        x += 1;
    }

}
