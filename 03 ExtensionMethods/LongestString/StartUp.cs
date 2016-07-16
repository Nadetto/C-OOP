namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            //17 return the string with maximum length from an array of strings.Use LINQ.

            var listOfString = new List<string>{ "dbrbtr", "va", "artbtabb", "afvbrgb"};

            var longestString =
                (from str in listOfString
                orderby str.Length descending
                select str).FirstOrDefault();

            Console.WriteLine(longestString);

            var longestSt = listOfString.OrderByDescending(x => x.Length).FirstOrDefault();

            Console.WriteLine(longestSt);
        }
    }
}
