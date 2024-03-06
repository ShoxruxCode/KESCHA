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
Console.WriteLine($"You are older than KESCHA: {age > keschasAge}");
Console.WriteLine($"You are younger than KESCHA: {age < keschasAge}");
Console.WriteLine($"You are older than or equal to KESCHA: {age >= keschasAge}");
Console.WriteLine($"You are younger than or equal to KESCHA: {age <= keschasAge}");
Console.WriteLine($"You are not equal to KESCHA: {age != keschasAge}");
Console.WriteLine($"You are equal to KESCHA: {age == keschasAge}");