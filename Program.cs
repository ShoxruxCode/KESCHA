
Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
Console.WriteLine(greeting);

Console.Write("Enter your age: ");
string ageAsString = Console.ReadLine();
Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
Console.WriteLine($"Successfully converted! {age}");
int keschasAge = 2;
int ageDifference = age - keschasAge;
Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");
if(age < keschasAge)
{
    Console.WriteLine("You are younger!");
} else if(age == keschasAge)
{
    Console.WriteLine("You are equal!");
} else 
{
    Console.WriteLine("You are older!");
}
string message = 
    age >= keschasAge 
        ? "You are older than or equal to Kescha" 
        : "You are younger than Kescha";
Console.WriteLine(message);
string message1 = 
    age >= 0 && keschasAge >=0
        ? "Your and Kescha's age are positive" 
        : "Your and/or Kescha's age are negative";
Console.WriteLine(message1);
string message2 = 
    age >= keschasAge || keschasAge >=0
        ? "Your and/or Kescha's age are positive" 
        : "Your and Kescha's age are negative";
Console.WriteLine(message2);
string message3 = 
    !(ageDifference >=0)
        ? "Kescha is older than you" 
        : "Kescha is not older than you";
Console.WriteLine(message3);
// logical operator : &&, ||, !