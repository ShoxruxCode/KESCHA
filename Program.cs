
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