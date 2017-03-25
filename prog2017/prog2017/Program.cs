using System;
using System.Reflection;
using System.Windows.Forms;

namespace prog2017
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Game: guess a number*/
            /* Manual managment */
            // NumberGuess.ConsoleUserOpportunities();

            /* One automaticaly test with auto-answering */
            // AutoTest();

            /* All tests in range [1..MAX_VALUE];
               Create an array with numbers witch weren't guessed */
            // TestForTesting();

            /* WinForms interface testing */
            // Application.Run(new DialogWindow());

            /* Binary search in array. Tests: */
            
            BinarySearch.SimpleTest();
            BinarySearch.TestNegativeNumbers();
            BinarySearch.TestNonExistentElement();
            BinarySearch.TestRepeatingNumbers();
            BinarySearch.TestEmptyArray();
            BinarySearch.StressTest();
            

            /* Provide pause for checking results of programms' work */
            Console.ReadKey();

        }

        static void AutoTest()
        {
            Console.WriteLine("Perform a number: ");
            String s = Console.ReadLine();
            int userNumber = int.Parse(s);
            Console.Clear();
            Console.WriteLine("Your number is {0}!", NumberGuess.StartGuess(userNumber));
            Console.ReadKey();
        }

        static bool AutoTest(int userNumber)
        {
            return NumberGuess.StartGuess(userNumber) == userNumber;
        }

        static void TestForTesting()
        {
            int length = 0;
            int[] wrongAnswers = new int[length];
            for (int i = 1; i < MAX_VALUE; i++) 
            {
                if (!AutoTest(i))
                {
                    length++;
                    Array.Resize<int>(ref wrongAnswers, length);
                    wrongAnswers[length - 1] = i;
                }
            }
            Console.WriteLine("wrong tests: ");
            for (int i = 0; i < length; i++)
                Console.WriteLine(wrongAnswers[i]);
        }

        public static int MAX_VALUE = 10000;
    }
}
