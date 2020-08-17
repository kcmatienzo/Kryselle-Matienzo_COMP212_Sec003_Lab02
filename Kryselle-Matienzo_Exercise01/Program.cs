using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryselle_Matienzo_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            // using built-in delegate template
            //Func<string, string, string, string> minString = Minimum;
            //Console.WriteLine(minString("apple", "ant", "banana"));
            //Console.WriteLine(minString("Twitter", "facebook", "Instagram"));

            // CODE FROM NINA
            Func<string, string, string, string> minimum = (str1, str2, str3) => 
            {
                string minStr = str1; // Asusme str1 is the smallest

                // compare str2 with minStr
                if (str2.CompareTo(minStr) < 0)
                {
                    minStr = str2; // str is the smallest for now
                }

                // compare to str3 with minStr
                if (str3.CompareTo(minStr) < 0)
                {
                    minStr = str3;
                }

                return minStr;
            };


            // Built-in delegate Action. average will be used to hold the ref of a method which takes 3 inputs and no return value
            Action<double, double, double> average = AvgGrade;

            // test using average reference
            average(3, 4, 5);
            average(95, 90, 100);


            // TEST nina's code
            Console.WriteLine($"The smallest string is: {minimum("ant", "plant", "dog")}");
        }

        //// Method that returns the smallest value of string
        //public static string Minimum(string strOne, string strTwo, string strThree)
        //{
        //    string[] words = { strOne, strTwo, strThree };
        //    Array.Sort(words, StringComparer.Ordinal);
        //    return words[0];
        //}

        // Method to display the average
        private static void AvgGrade(double value1, double value2, double value3) => Console.WriteLine($"Average Grade is: " + (value1 + value2 + value3) / 3);
    }
}
