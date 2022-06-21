Console.Write("Enter your name:  ");
string username = Console.ReadLine();

if(username.ToLower() == "diana")
{
    Console.WriteLine("Cool, Diana");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}