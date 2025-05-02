using System;
namespace Kescha.Classes
{
    public interface IAnimal
    {
        void Greeting();
        void Compare();
        int AgeDifference(int userAge);
    }
}