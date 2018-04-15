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
              // create object of Random class and assign random number from 0 to 10 to chosen variable
            Random random = new Random();
            int chosen = random.Next(10);

            // declaring user number and attemptNumber variable
            int myNumber = 0;
            int attemptNumber = 0;

            while (true)
            {

                attemptNumber++;

                Console.WriteLine("Put the number from 0 to 10 : "+" Attempt number: " + attemptNumber);
                myNumber = Convert.ToInt32(Console.ReadLine());              

                if(myNumber==chosen)
                {
                    Console.WriteLine("Good answer ! For the " + attemptNumber + " time");
                    break;
                }
                else if(myNumber<chosen)
                {
                    Console.WriteLine("This is too little. Please try again : ");         
                }
                else if(myNumber>chosen)
                {

                    Console.WriteLine("THis is too much. Please try again : ");
                }
            }

            Console.ReadKey();
        }
    }
}
