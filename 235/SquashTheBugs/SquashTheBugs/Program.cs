using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquashTheBugs
{
    class Program
    {
        /*Here are all the error in the system
         * At int i, a ";" is missing at the end
         * Console.WriteLine("These numbers have been processed: " allNumbers); is out of the function, meaning it does not exist
         * Since it was in the function, that means that allNumbers would get reset since it was in the for loop.
         * There was a comma in the function, so I replaced it with a plus sign.
         * There is no "," between the int and the string in the output explanation
         * There is no "," between the string and variable in the output line;
         * i = i + 1 doesn't need to be in there.
         */
        static void Main(string[] args)
        {
            // declare int counter
            int i = 0;
            //int a = 2;
            string allNumbers = null;

            string userInput = Console.ReadLine();

            int userNumber = int.Parse(userInput);

            // loop through the numbers 1 through 10
            for (i = 2; i < 11; ++i)
            {
                // declare string to hold all numbers

                // output explanation of calculation
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                Console.WriteLine((double)i / (i - 1));

                //a = a + 1;

                // concatenate each number to allNumbers
                allNumbers += i + " ";
                //Console.WriteLine(allNumbers);

                // increment the counter
                //i = i + 1;

            }
            // output all numbers which have been processed
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }

}
