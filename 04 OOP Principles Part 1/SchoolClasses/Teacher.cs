namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Teacher : People, ICommentable
    {
        private List<Discipline> listOfDiscipline;

        public Teacher(string name)
            :base(name)
        {
            this.ListOfDiscipline = new List<Discipline>();
        }

        public Teacher(string name, List<Discipline> listOfDiscipline)
            :this(name)
        {
            this.ListOfDiscipline = listOfDiscipline;
        }

        public List<Discipline> ListOfDiscipline
        {
            get { return this.listOfDiscipline; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("List can not be null");
                }
                this.listOfDiscipline = value;
            } 
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());

            if(this.ListOfDiscipline.Any())
            {
                sb.Append("Disciplines:");
                sb.Append("\n");
                foreach (var item in ListOfDiscipline)
                {
                    sb.Append(item.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
