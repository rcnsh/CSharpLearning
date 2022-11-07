Console.WriteLine("What is your first name");
String firstName = Console.ReadLine();

Console.WriteLine("What is your last name");
String lastName = Console.ReadLine();

String fullname = firstName + lastName;

int length = fullname.Length;

String printfullname = firstName + " " + lastName;

Console.WriteLine("Your full name is " + printfullname + " and it is " + length + " characters long");