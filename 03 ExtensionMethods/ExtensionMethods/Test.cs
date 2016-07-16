namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    class Test
    {
        
        static void Main()
        {
            //Extention methods

            //Task 1: Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String
            var builder = new StringBuilder();

            builder.Append("This is a new String");
            var result2 = builder.Substring(8, 5);
            var result = builder.Substring2(8, 5);
            var resultOnlyWithIndex = builder.Substring(8);

            Console.WriteLine(result.ToString());
            Console.WriteLine(result2.ToString());
            Console.WriteLine(resultOnlyWithIndex.ToString());

            //task 2

            var grades = new List<int>() { 2, 5, 8, 3, 7 };
            
            Console.WriteLine(grades.MySum());
            Console.WriteLine(grades.Product());
            Console.WriteLine(grades.MyMin());
            Console.WriteLine(grades.MyMax());
            Console.WriteLine(grades.MyAvarage());
        }
    }
}
