using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step132
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Pony", "Ball", "Steak", "Torch", "Blue", "Irish", "Right", "House", "Boys", "Pokemon" };

            Console.WriteLine("Enter a number between 0 and 9:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (0 > number || number > 9)
            {
                Console.WriteLine("Try again. Please close the program and retry.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nYour word is " + stringArray[number]);                
            }


            int[] intArray = { 9001, 3, 420, 6969, 1337, 01134, 1985, 1992, 8675309, 1231233 };

            Console.WriteLine("\nEnter another number between 0 and 9:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (0 > number2 || number2 > 9)
            {
                Console.WriteLine("Try again. Please close the program and retry.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nYour number is " + intArray[number2]);


            }
            List<string> stringList = new List<string>();
            stringList.Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do");
            stringList.Add("eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut");
            stringList.Add("enim ad minim veniam, quis nostrud exercitation ullamco laboris");
            stringList.Add("nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in");
            stringList.Add("reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla");
            stringList.Add("pariatur. Excepteur sint occaecat cupidatat non proident, sunt in");
            stringList.Add("culpa qui officia deserunt mollit anim id est laborum.");

            Console.WriteLine("Enter a final = number between 0 and 6:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (0 > number || number > 6)
            {
                Console.WriteLine("Try again. Please close the program and retry.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nYour lorem ipsum string is " + stringList[number3]);
            }
            Console.ReadLine();
        }
    }
}
