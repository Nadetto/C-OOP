namespace OOP_Principles_Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var animals = new List<Animal>()
            {
                new Cat("Bo", 5, GenderType.Female),
                new Dog("Jim", 4, GenderType.Male),
                new Frog("Henry", 2, GenderType.Male),
                new Kitten("Sara", 1),
                new Tomcat("Gosho", 9)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);   
            }

            Console.WriteLine("Avarage age of all is {0}", Animal.CalculateAverageAge(animals));
        }
    }
}
