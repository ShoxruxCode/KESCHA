namespace   KESCHA.Classes
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Animal(string animalName, int userAge, int animalAge)
        {
            Name = animalName;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturns(userAge, animalAge);
        }
        public void Print()
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
        public void Greet(string userName)
        {
            if(userName == "")
            {
                userName = "Unknown Person";
            }
            string greeting = $"Hello, {userName}";
            Console.WriteLine(greeting);
        }
        private void CalculateAgeDifferenceWithNoReturns(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }
}