Console.WriteLine("Enter a number of days?");
int days = Convert.ToInt32(Console.ReadLine());
int hours = days * 24;
int minutes = hours * 60;
int seconds = minutes * 60;

Console.WriteLine("In " + days + " days, there are " + hours + " hours, " + minutes + " minutes, and " + seconds + " seconds.");
