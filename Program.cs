using KESCHA.Classes;

Animal kescha = new Animal(name: "Kescha", age: 3);

Console.Write("Enter your name: ");
string userName = Console.ReadLine();
kescha.Greet(userName);

Console.Write("Enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Converting...");
Console.WriteLine($"Successfully converted! {userAge}");

kescha.CalculateAgeDifferenceWithNoReturns(userAge);
kescha.Print();
kescha.CompareAges(userAge);
kescha.TellAboutFriends(userName, userAge);