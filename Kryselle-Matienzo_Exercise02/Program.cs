using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryselle_Matienzo_Exercise02
{
    // defining a delegate that takes an input of type double and returns a bool
    delegate bool GradesPredicate(double value);
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring array of grades.
            // I have 9 items which has value of 50 and up
            double[] gradesArray = { 99.2, 36.7, 88.6, 67.9, 86.5, 17.6, 98.3, 46.34, 67.45, 26.53, 75.57, 89.56, 50.50 };

            // Lambda expression that filters values which are greater or equal to 50.
            GradesFilter(gradesArray, num => (num >= 50));
        }

        // Method that only displays those grades values which are greater than or equal to 50.
        private static void GradesFilter(double[] gradesArray, GradesPredicate predicate)
        {
            foreach (var item in gradesArray)
            {
                // if the element satisfies the predicate
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
