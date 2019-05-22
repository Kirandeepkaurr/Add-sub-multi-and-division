using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_sub__multi_and_division
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter a number: ");
                int num25 = Convert.ToInt32(Console.ReadLine());
                // For First number

                Console.Write("Enter another number: ");
                int num4 = Convert.ToInt32(Console.ReadLine());
                //For Second number

                Console.WriteLine("{0} + {1} = {2}", num25, num4, num25 + num4); //for addition
                Console.WriteLine("{0} - {1} = {2}", num25, num4, num25 - num4); //for subtractions
                Console.WriteLine("{0} x {1} = {2}", num25, num4, num25 * num4); //for multiplication
                Console.WriteLine("{0} / {1} = {2}", num25, num4, num25 / num4); //for division
                Console.WriteLine("{0} mod {1} = {2}", num25, num4, num25 % num4);
            }
        }
    }
}
