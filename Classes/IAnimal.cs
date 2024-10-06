namespace KESCHA.Classes
{
    public interface IAnimal
    {
        void CalculateAgeDifferenceWithNoReturns(int userAge);
        void PrintAgeDifference();
        void CompareAges(int userAge);
        void TellAboutFriends(string userName, int userAge);
        void Greet(string userName);
        void Greet2(string userName);
    }
}