using System.Globalization;

Console.WriteLine("Enter your first name and surname in lowercase");

string name = Console.ReadLine();

string titleCaseName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);

Console.WriteLine(titleCaseName);