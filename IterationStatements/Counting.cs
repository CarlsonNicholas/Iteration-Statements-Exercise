
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Counting
    {
        //Method that will List all numbers from negative one thousand to positive one thousand
        public static void CountingNumbers()
        {
            int activeNumber = -1000;
            do
            {
                Console.WriteLine(activeNumber);
                activeNumber++;

            } while (activeNumber < 1001);

        }

        // Method that will count up by 3's from 3 to 999
        public static void CountingThrees()
        {
            int threes = 3;
            do
            {
                Console.WriteLine(threes);
                threes += 3;

            } while (threes != 1002);

        }
        // Method to check if two numbers are the same
        public static void SameNumber()
        {
            Console.WriteLine("Please Provide your first number");
            var numOne = Console.ReadLine();

            Console.WriteLine("Please provide your second number");
            var numTwo = Console.ReadLine();

            if (numOne == numTwo)
            {
                Console.WriteLine($"{numOne} and {numTwo} are the same!");
            }

            else
            {
                Console.WriteLine($"Sorry, {numOne} and {numTwo} are not the same :(");
            }
        }
        // Method to check if a number is even or odd
        public static void EvenOrOdd()
        {
            Console.WriteLine("Write a number! ");
            int inputEvenOdd = Convert.ToInt32(Console.ReadLine());

            if (inputEvenOdd % 2 == 0)
            {
                Console.WriteLine($"{inputEvenOdd} is even!");
            }

            else
            {
                Console.WriteLine($"{inputEvenOdd} is odd!");
            }

        }
        // Method that checks if a number is postive or negative
        public static void PosOrNeg()
        {
            Console.WriteLine("Write a number! ");
            int intPosNeg = Convert.ToInt32(Console.ReadLine());

            if (intPosNeg >= 0)
            {
                Console.WriteLine($"{intPosNeg} is positive");
            }
            
            else
            {
                Console.WriteLine($"{intPosNeg} is negative");
            }

        }

        // Method that checks if you can vote in the U S A!
        public static void VotingAge()
        {

            Console.WriteLine("What is your age? ");
            int legalAge = Convert.ToInt32(Console.ReadLine());

            if (legalAge >= 18)
            {
                Console.WriteLine($"{legalAge} is old enough to vote!");
            }

            else
            {
                Console.WriteLine($"{legalAge} is too young to vote.");
            }

        }
        // Method that checks if the user inserted a number from -10 to positive 10!
        public static void UserRange()
        {
            Console.WriteLine("Enter a number! ");

            int range = Convert.ToInt32(Console.ReadLine());

            if (range >= -10 && range < 11)
            {
                Console.WriteLine($"{range} is in the range of 10 to negative 10!");
            }

            else
            {
                Console.WriteLine($"{range} is not in the range of 10 to negative 10!");
            }


        }


    }
}
