using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int attemptNumber = 0;
            int randomNumber = GenerateNumber(10);

            StartGame(ref attemptNumber,ref randomNumber);

            Console.ReadKey();
        }

        private static void StartGame(ref int attemptNumber, ref int randomNumber)
        {
            int myNumber = 0;
            while (true)
            {

                attemptNumber++;

                myNumber = GetUserNumber(ref attemptNumber);


                if (myNumber == randomNumber)
                {
                    Console.WriteLine("Good answer ! For the " + attemptNumber + " time");
                    break;
                }
                else if (myNumber < randomNumber)
                {
                    Console.WriteLine("This is too little. Please try again : ");


                }
                else if (myNumber > randomNumber)
                {

                    Console.WriteLine("This is too much. Please try again : ");
                }
            }

        }

        private static int GenerateNumber(int rangeMaximum)
        {
            int number = 0;
            Random random = new Random();
            number = random.Next(rangeMaximum);

            return number;
        }

        private static int GetUserNumber(ref int attemptNumber)
        {
            int number = 0;
            Console.WriteLine("Put the number from 0 to 10 : " + " Attempt number: " + attemptNumber);
            number = Convert.ToInt32(Console.ReadLine());
            return number;

        }
    }
}
