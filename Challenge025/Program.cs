Console.WriteLine("Enter your first name");

string firstName = Console.ReadLine();

if (firstName.Length < 5){
    Console.WriteLine("Enter your last name");
    string lastName = Console.ReadLine();
    String fullname = firstName + lastName;
    Console.WriteLine(fullname.ToUpper());
}
else{
    Console.WriteLine(firstName.ToLower());
}