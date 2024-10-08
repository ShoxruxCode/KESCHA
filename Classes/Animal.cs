namespace   KESCHA.Classes
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        protected int Age { get; set; }
        internal int AgeDifference { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public Animal()
        {
            Name = "";
            Age = 0;
            AgeDifference = 0;
            CreatedDate = DateTimeOffset.UtcNow;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            CreatedDate = DateTimeOffset.UtcNow;
        }
        public Animal(string animalName, int userAge, int animalAge)
        {
            Name = animalName;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturns(userAge);
            CreatedDate = DateTimeOffset.UtcNow;
        }
        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference between your and {Name}'s age is {AgeDifference}");
        }
        public void CompareAges(int userAge)
        {
            if(userAge > Age)
            {
                Console.WriteLine("You are older");
            }
            else if(userAge == Age)
            {
                Console.WriteLine("You are equal");
            }
            else
            {
                Console.WriteLine("You are younger");
            }
        }
        public void TellAboutFriends(string userName, int userAge)
        {
            Console.WriteLine("Let me tell you about my friends");
            string[] friendsName = new string[3];
            friendsName[0] = "Vasya";
            friendsName[1] = "Kasee";
            friendsName[2] = userName;
            int[] friendsAge = { 1, 2, userAge};
            string[] friendsAddress = { "Russian", "French", "Uzbek",};
            foreach (string friendName in friendsName)
            {
                Console.WriteLine(friendName);
            }
            for(int iteration = 0; iteration < friendsName.Length; iteration++)
            {
                Console.WriteLine($"{friendsName[iteration]} is {friendsAddress[iteration]} and he is {friendsAge[iteration]} years old");
            }
        }
        public virtual void Greet(string userName)
        {
            if(userName == "")
            {
                userName = "Unknown Person";
            }
            string greeting = $"Hello, {userName}";
            Console.WriteLine(greeting);
        }
        public abstract void Greet2(string userName);
        public void CalculateAgeDifferenceWithNoReturns(int userAge)
        {
            AgeDifference = userAge - Age;
        }
    }
}