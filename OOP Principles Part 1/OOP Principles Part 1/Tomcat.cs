using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part_1
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, GenderType.Male)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Miau, miau");
        } 
    }
}
