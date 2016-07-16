namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Student : IHasGroupNumber
    {
        //FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.

        public Student(string firstName, string lastName, string facultyNumber,
            string telephone, string email, int groupNumber, int Age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.Telephone = telephone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Age = Age;
            this.Marks = new List<int>();
        }

        public Student(string firstName, string lastName, string facultyNumber,
            string telephone, string email, int groupNumber, int Age, List<int> marks)
            :this(firstName, lastName, facultyNumber, telephone, email, groupNumber, Age)
        {
            this.Marks = marks;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Student: {0} {1}, FN: {2}, Tel: {3}, Email: {4}, Group: {5}", this.FirstName,
                this.LastName, this.FacultyNumber, this.Telephone, this.Email, this.GroupNumber);
            sb.AppendFormat(" Marks :");
            

            foreach (var mark in this.Marks)
            {
                sb.AppendFormat("{0}  ", mark);
            }
            
            return sb.ToString();
        }
    }
}
