using System;

namespace CSharp_Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = GetInputAnswer("What is your name?");

            string favoriteColor = GetInputAnswer("What is your favorite color?");

            string favoriteAnimal = GetInputAnswer("What is your favorite animal?");

            string favoriteBand = GetInputAnswer("What is your favorite band?");

            Console.WriteLine($"This is a little info about {name}.  {name}'s favorite color is {favoriteColor}.  The {favoriteAnimal} is {name} favorite animal.  For music, {name}'s favorite band is {favoriteBand}. ");
        }

        static string GetInputAnswer(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();

        }
    }
}
