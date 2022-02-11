using System;
namespace SelectionStatements
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Guess My Favourite Number!!!!");
            var userInput = int.Parse(Console.ReadLine());

            var favNumber = 200;
            if (userInput == favNumber)
            {
                Console.WriteLine("You have guessed right");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Number is too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Number is too high");

            }
            else
            {
                Console.WriteLine("NeverMind");
            }    
        }
    }
}
