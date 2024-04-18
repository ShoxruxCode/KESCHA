
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
Console.WriteLine("Let me tell you about my friends");
string[] friendsName = new string[3];
friendsName[0] = "Vasya";
friendsName[1] = "Kasee";
friendsName[2] = name;
int[] friendsAge = { 1, 2, age};
string[] friendsAddress = { "Russian", "French", "Uzbek",};
foreach (string friendName in friendsName)
{
    Console.WriteLine(friendName);
}
for(int iteration = 0; iteration < friendsName.Length; iteration++)
{
    Console.WriteLine($"{friendsName[iteration]} is {friendsAddress[iteration]} and he is {friendsAge[iteration]} years old");
}
int[] number = new int[100];
Random random= new Random();
for (int i = 0; i < number.Length; i++)
{
    number[i] = random.Next(1,101);
}
for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine($"array[{i+1}]={number[i]}");
}