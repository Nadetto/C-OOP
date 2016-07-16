using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part_1
{
    public class Dog : Animal
    {
        public Dog(string name, int age, GenderType gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau, bau");
        } 
    }
}
