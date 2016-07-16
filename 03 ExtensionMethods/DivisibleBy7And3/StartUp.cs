using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7And3
{
    class StartUp
    {
        static void Main()
        {
            //6 prints from given array of integers all numbers that are divisible by 7 and 3.
            //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

            var list = new List<int>() { 8, 9, 2, 58, 74, 63, 58, 45, 68, 95, 3, 7, 21, 28, 12, 14 };

            var disibleBy7And3 = list.Where(x => (x % 3 == 0) && (x % 7 == 0));

            foreach (var num in disibleBy7And3)
            {
                Console.WriteLine(num);
            }

            var divisible7and3 =
                from num in list
                where (num % 3 == 0 && num % 7 == 0)
                select num;

            foreach (var num in divisible7and3)
            {
                Console.WriteLine(num);
            }
        }
    }
}
