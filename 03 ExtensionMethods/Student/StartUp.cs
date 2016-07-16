using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StartUp
    {
        static void Main()
        {
            var asiaMarks = new List<int>() { 2, 3, 4, 5, 6, 6, 6 };
            var peshoMarks = new List<int>() { 2, 3, 4, 5, 4, 3, 4 };
            var ivoMarks = new List<int>() {  4, 5 };
            

            var students = new List<Student>(){
                new Student("Asia", "Petrova", "000106", "123", "asia@gmail.com", 1, 18, asiaMarks),
                new Student("Pesho", "Petrov", "000206", "456", "pesho@gmail.com", 2, 30, peshoMarks),
                new Student("Ivo", "Stoianov", "000306", "789", "ivo@gmail.com", 2, 26, ivoMarks),
                new Student("Dimo", "Ivanov", "000402", "987", "dimo@gmail.com", 1, 19),
                new Student("Stoian", "Asenov", "000503", "963", "sto@abv.bg", 1, 17),
                new Student("Desi", "Borisova", "000607", "02852", "desi@gmail.com", 2, 24),
                new Student("Mila", "Nikolova", "000703", "147", "mila@abv.bg", 2, 21),
                new Student("Galia", "Tihova", "000803", "542", "gali@gmail.com", 1, 25),
                new Student("Dimo", "Protov", "000902", "546", "dimo2@gmail.com", 3, 19),
                new Student("Gego", "Asenov", "001002", "02753", "sto2@gmail.com", 3, 28)
            };


            var mathematicsGroup = new Group(1, "Mathematics");
            var historyGroup = new Group(2, "History");
            var ArtGroup = new Group(1, "Art");
            var SportGroup = new Group(2, "Sport");

            var listOfGroups = new List<Group>() {mathematicsGroup, historyGroup, ArtGroup,
            SportGroup};

            //task 3 first name is before its last name alphabetically.Use LINQ query operators.
            var firstNamebeforeLast =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            //PrintListOfStudents(firstNamebeforeLast);


            // task 4: LINQ that finds the first name and last name - age between 18 and 24.
            var studentsBetween18And24 =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in studentsBetween18And24)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            //task 5    OrderBy() and ThenBy() with lambda expressions sort the students by 
            //first name and last name in descending order. Rewrite the same with LINQ.

            var sortedStudents = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .ToList();

           // PrintListOfStudents(sortedStudents);

            var sortedStudentsLinQ =
                from student in students
                orderby student.FirstName descending,
                student.LastName descending
                select student;

           // PrintListOfStudents(sortedStudentsLinQ);

            
            
            //task 9, 10 - group number 2. Use LINQ and Extention. Order the students by FirstName.
            var studentGroup2 =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            //PrintListOfStudents(studentGroup2);

            var studentsInGroup2 = students
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToList();

            //PrintListOfStudents(studentsInGroup2);


            //task 11: students that have email in abv.bg. Use string methods and LINQ.
            string domain = "abv.bg";
            var studentsEmailInAbvBg =
                from student in students
                where student.Email.Contains(domain)
                select student;

            var emailInAbv = students
                .Where(x => x.Email.Contains(domain))
                .ToList();

            //PrintListOfStudents(studentsEmailInAbvBg);
            //PrintListOfStudents(emailInAbv);

            //Tast 12: All Students with phones in Sofia. Use LINQ
            var allWithPhonesInSofia =
                from student in students
                where student.Telephone.StartsWith("02")
                select student;

            //PrintListOfStudents(allWithPhonesInSofia);

            // Task 13: at least one mark Excellent (6) into a new anonymous class that has
            // properties – FullName and Marks. Use LINQ.

            var AtLeastOneExcellentMark =
                (from student in students
                where student.Marks.Contains(6)
                select student).Select(x => (new
                {
                    FullName = string.Format("{0} {1}", x.FirstName, x.LastName),
                    Marks = string.Join(" ", x.Marks)
                }))
                .ToList();

            //foreach (var anonimous in AtLeastOneExcellentMark)
            //{
            //    Console.WriteLine(anonimous);
            //}

            
            var excellentMark = students
                .Where(x => x.Marks.Contains(6))
                .Select(x => (new
                {
                    FullName = string.Format("{0} {1}", x.FirstName, x.LastName),
                    Marks = string.Join(" ", x.Marks)
                }))
                .ToList();

            //foreach (var student in excellentMark)
            //{
            //    Console.WriteLine(student);
            //}


            //task 14 students with exactly two marks "2". Use extension methods.
            var studentsWith2Marks = students.Where(x => x.Marks.Count == 2).ToList();
            //PrintListOfStudents(studentsWith2Marks);

            //task 15 all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var enrolled2006AllMarks = students
                .Where(x => x.FacultyNumber.Substring(4, 2) == "06")
                .Select(x => (new 
                {
                    FullName = string.Format("{0} {1}", x.FirstName, x.LastName),
                    Marks = string.Join(" ", x.Marks)
                 })).ToList();

            //foreach (var student in enrolled2006AllMarks)
            //{
            //    Console.WriteLine(student);   
            //}
           
            
            //16 Extract all students from "Mathematics" department.
            //use the Join operator
            
            var allFromMathematicsDep =
                (from g in listOfGroups
                join st in students on g.GroupNumber equals st.GroupNumber into mathGroup
                select new { GroupName = g.GroupNumber, Students = mathGroup })
                .Where(x => x.GroupName == 1);

            //foreach (var g in allFromMathematicsDep)
            //{
            //    Console.WriteLine(g.GroupName);
            //    foreach (var st in g.Students)
            //    {
            //        Console.WriteLine("{0}, {1}, {2}", st.FirstName, st.LastName, st.GroupNumber);
            //    }
            //}

            //18 Create a program that extracts all students grouped by GroupNumber 
            // and then prints them to the console. Use LINQ.

            var studentsByGroupNum =
                from st in students
                orderby st.GroupNumber
                select st;

           // PrintListOfStudents(studentsByGroupNum);

            //19. same with extention methods

            var studentsByGroupNum2 = students.OrderBy(x => x.GroupNumber).ToList();
           // PrintListOfStudents(studentsByGroupNum2);

        }

        private static void PrintListOfStudents(IEnumerable<Student> collection)
        {
            foreach (var student in collection)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
