// See https://aka.ms/new-console-template for more information
Console.WriteLine("Information Input");

Console.WriteLine("what is your first name?");
string firstname = Console.ReadLine();//first name

Console.WriteLine("what is your last name?");
string lastname = Console.ReadLine();//last name


Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());// age


Console.WriteLine("What is your favorate color?");
string color = Console.ReadLine();// color




Console.WriteLine("Hello," + firstname + lastname + "! You are" + age + "year old and your favorite color is " + color);