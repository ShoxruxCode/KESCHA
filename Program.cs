Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
Console.WriteLine(greeting);

Console.Write("Enter your age: ");
string ageAsString = Console.ReadLine();
Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
Console.WriteLine($"Successfully converted! {age}");
int KeschasAge = 2;
int ageDifference = age - KeschasAge;
Console.WriteLine($"Men KESCHAdan {ageDifference} yosh kattaman");
Console.WriteLine($"KESCHA mendan {ageDifference} yosh kichik");
Console.WriteLine($"Men va KESCHAni oramizdagi yosh tafovut {ageDifference} ga teng");
// Uyga vazifa bu Kescha va userning yoshlari orasidagi tafovutni hisoblash