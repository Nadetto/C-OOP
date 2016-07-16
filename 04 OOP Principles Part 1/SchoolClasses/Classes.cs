namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Classes : ICommentable
    {
        private string myComment;
        private string uniqueTextIdentifier;
        private List<Teacher> listOfTeacher;

        public Classes(string uniqueTextIdentifier, List<Teacher> listOfTeacher)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.ListOfTeacher = listOfTeacher;
        }

        public Classes(string uniqueTextIdentifier, List<Teacher> listOfTeacher, string comment)
            : this(uniqueTextIdentifier, listOfTeacher)
        {
            this.MyComment = comment;
        }


        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Unique Text Identifier cannot be null or empty");
                }

                this.uniqueTextIdentifier = value;
            }
        }

        public List<Teacher> ListOfTeacher
        {
            get { return this.listOfTeacher; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("List of teacher can not be null");
                }
                this.listOfTeacher = value;
            }
        }
        public string MyComment
        {
            get
            {
                return this.myComment;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Comment cannot be null or empty");
                }

                this.myComment = value;
            }
        }
    }
}
