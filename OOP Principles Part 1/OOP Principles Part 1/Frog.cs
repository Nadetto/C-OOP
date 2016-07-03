using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part_1
{
    class Frog : Animal
    {
        public Frog(string name, int age, GenderType gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Qua, qua");
        } 
    }
}
