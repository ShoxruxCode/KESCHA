using KESCHA.Classes;
using KESCHA.Enums;

namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            try
            {
                Animal kescha = new Bird(name: "Kescha", age: 3);
                Pet kasee = new Pet(name: "Kasee", age: 5);
                kasee.Type = PetType.Cat;
                Console.WriteLine(kasee.Type);
                Console.WriteLine("Kescha was created " + kescha.CreatedDate);
                Console.WriteLine("Kasee was created " + kasee.CreatedDate);

                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Kescha says");
                kescha.Greet(userName);
                Console.WriteLine("Kasee says");
                kasee.Greet(userName);
                Console.Write("Enter your age: ");
                int userAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Converting...");
                Console.WriteLine($"Successfully converted! {userAge}");

                kescha.CalculateAgeDifferenceWithNoReturns(userAge);
                kescha.Print();
                kescha.CompareAges(userAge);
                kescha.TellAboutFriends(userName, userAge);
            }
            catch(FormatException formatException)
            {
                Console.WriteLine($"Error was thrown. Message {formatException.Message}");
            }
            catch(Exception exception)
            {
                Console.WriteLine("Error was thrown");
            }
            Console.WriteLine("Programm ended");
            
        }
    }
}