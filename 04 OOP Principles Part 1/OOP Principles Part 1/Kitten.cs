using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part_1
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, GenderType.Female)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Miau, miau");
        } 
    }
}
