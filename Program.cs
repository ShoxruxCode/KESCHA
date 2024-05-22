using KESCHA.Classes;
namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            Car car = new Car(brand: "Mashina markasi");

            Console.Write("Mashina markasini kiriting: ");
            string brand = Console.ReadLine();

            Console.Write("Mashina modelini kiriting: ");
            string model = Console.ReadLine();

            Console.Write("Mashina ishlab chiqarilgan yilni kiriting: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mashinaning narxini kiriting: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Mashinaning maksimal tezligini kiriting: ");
            decimal speed = Convert.ToDecimal(Console.ReadLine());

            string GetCarInfo = car.GetCarInfo(brand, model, year, price, speed);
            Console.WriteLine(GetCarInfo);
            car.CalculateDepreciation(year, price);
            
        }
    }
}