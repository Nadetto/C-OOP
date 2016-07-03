namespace OOP_Principles_Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private GenderType gender;

        public Animal(string name, int age, GenderType gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrEmpty(value) && value.Length < 1)
                {
                    throw new ArgumentException("Name cannot be less than 1 symbol");
                }

                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Age cannot be less than null");
                }

                this.age = value;
            }
        }
        public GenderType Gender { get; set; }

        public static double CalculateAverageAge(IEnumerable<Animal> animal)
        {
            double avarageAge = animal.Average(x => x.Age);
            return avarageAge;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return string.Format("{0} is {1} and is {2} years old.", this.Name, this.Gender, this.Age);
        }
        
    }
}
