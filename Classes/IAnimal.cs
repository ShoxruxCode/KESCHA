using System;

namespace KESCHA.Classes
{
    public interface IAnimal
    {
        void Greet2(string userName);
        void Print();
        void CompareAges(int userAge);
        void TellAboutFriends(string userName, int userAge);
        void Greet(string userName);
        void CalculateAgeDifferenceWithNoReturns(int userAge);
    }
}