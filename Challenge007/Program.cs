Console.WriteLine("What is your name?");
String name = Console.ReadLine();

Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());

age+=1;

Console.WriteLine(name + ", you will be " + age + " next year!");