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
        double dobeuros = pounds * 1.14;

        Math.Round(dobeuros);
        int euros = Convert.ToInt32(dobeuros);
        
        int fiftynotes = euros / 50;
        int fiftyremainder = euros % 50;

        int twentynotes = fiftyremainder / 20;
        int twentyremainder = fiftyremainder % 20;

        int tennernotes = twentyremainder / 10;
        int tennerremainder = twentyremainder % 10;

        int fivernotes = tennerremainder / 5;
        int fiverremainder = tennerremainder % 5;
        
        Console.WriteLine("You would need " + fiftynotes + " fifty euro notes, " + twentynotes + " twenty euro notes, " + tennernotes + " ten euro notes, and " + fivernotes + " five euro notes to make this amount of money, with €" + fiverremainder + " left over.");
    }
    
    if (choice == 2)
    {
        Console.WriteLine("Enter a number of euros to convert to pounds." + Environment.NewLine);
        double euros = Convert.ToDouble(Console.ReadLine());
        double dobpounds = euros / 1.14;
        Math.Round(dobpounds);
        int pounds = Convert.ToInt32(dobpounds);
        
        int fiftynotes = pounds / 50;
        int fiftyremainder = pounds % 50;

        int twentynotes = fiftyremainder / 20;
        int twentyremainder = fiftyremainder % 20;

        int tennernotes = twentyremainder / 10;
        int tennerremainder = twentyremainder % 10;

        int fivernotes = tennerremainder / 5;
        int fiverremainder = tennerremainder % 5;
        
        Console.WriteLine("You would need " + fiftynotes + " fifty pounds notes, " + twentynotes + " twenty pounds notes, " + tennernotes + " ten pound notes, and " + fivernotes + " five pound notes to make this amount of money, with £" + fiverremainder + " left over.");
    }

    if (choice == 3)
    {
        x += 1;
    }

}
//uncompleted