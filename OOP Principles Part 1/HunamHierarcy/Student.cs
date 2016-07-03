using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunamHierarcy
{
    public class Student : Human
    {
        private decimal grade;

        public Student(string firstName, string lastName, decimal grade) 
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public decimal Grade { get; set; }
    }
}
