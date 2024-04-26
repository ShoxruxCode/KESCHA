using KESCHA.Classes;

Animal kescha = new Animal(name: "Kescha", age: 3);
Console.Write("Enter your name: ");
string userName = Console.ReadLine();

kescha.Greet(userName);

Console.Write("Enter your age: ");
string ageAsString = Console.ReadLine();
int userAge = Convert.ToInt32(ageAsString);


Console.WriteLine(kescha.Name);
Console.WriteLine(kescha.Age);

Console.WriteLine("Converting...");
Console.WriteLine($"Successfully converted! {userAge}");
kescha.Age = 20;
Console.WriteLine($"The difference between your and Kescha's userAge is {kescha.AgeDifference}");
kescha.Print();
kescha.CompareAges(userAge);
kescha.TellAboutFriends(userName, userAge);