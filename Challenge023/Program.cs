// Ask the user to type in the first line of a nursery rhyme and display the length of the string

Console.WriteLine("Please enter the first line of a nursery rhyme: ");

string rhyme = Console.ReadLine();

Console.WriteLine("The length of the string is: " + rhyme.Length);

// Ask for a starting number and an ending number and then display just that section of the text

Console.WriteLine("Please enter a starting number: ");

int start = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter an ending number: ");

int end = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The section of the string is: " + rhyme.Substring(start, end));