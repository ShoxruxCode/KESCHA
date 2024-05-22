namespace KESCHA.Classes
{
    class Car
    {
        private string brand;
        private string model;
        private int year;
        private decimal price;
        private decimal speed;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public decimal Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public Car(string brand)
        {
            Brand = brand;
        }
        public Car(string brand, string model, int year, decimal price, decimal speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Speed = speed;
            GetCarInfo(brand, model, year, price, speed);
        }
        public string GetCarInfo(string brand, string model, int year, decimal price, decimal speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Speed = speed;
            return $"{brand} mashinasi {model} modeli {year}-yilda ishlab chiqarilgan, narxi {price} so'm, uning maksimal tezligi {speed} km/soat";
        }
        public void CalculateDepreciation(int year, decimal price)
        {
            Year = year;
            year = 2024 - year;
            Price = price;
            decimal depreciationRate = 0.1m;
            for(int i = 0; i < year; i++)
            {
                price -= price * depreciationRate;
            }
            Console.WriteLine($"Mashina narxi 2024-yilga kelib ketma-ket {year} marta 10% dan tushdi va uning hozirgi narxi {price} so'm");
        }
    }
}