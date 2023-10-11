using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an number ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (Exception e){ //can also have one generic error message, or catch the exact error.
                Console.WriteLine(e.Message);
            }

            //freeze
            Console.WriteLine();
        }
    }
}
