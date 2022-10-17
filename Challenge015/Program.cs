Console.WriteLine("What's your favourite colour?");
string answer = Console.ReadLine();

if("red" == answer.ToLower()){
    Console.WriteLine("I like red too!");
    
}
else
{
    Console.WriteLine(answer + " is cool, but i prefer red tbh");
}