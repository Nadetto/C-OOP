namespace GenericClassT
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        public static void Main()
        {
            var list = new GenericList<int>(5);
            list.AddElement(5);
            list.AddElement(10);
            list.AddElement(20);
            list.AddElement(10);
            list.AddElement(100);
            list.AddElement(20);
            list.AddElement(-50);

            list.AddElement(0);
            Console.WriteLine(list);

            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            
        }
    }
}
