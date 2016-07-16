namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var stu1 = new Student("Ivan", "Ivan e v parvi klas", 5);
            var stud2 = new Student("Dora", 6);

            var math = new Discipline("Math", 2, 2);
            var sport = new Discipline("Sport", 3, 3, "Sport is importaint");
            var listOfDisiplines = new List<Discipline>(){ math, sport };

            var mathTeacher = new Teacher("Ginka Nikolova", listOfDisiplines);
            Console.WriteLine(mathTeacher);
        }
    }
}
