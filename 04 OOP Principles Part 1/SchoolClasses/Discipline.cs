namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Discipline : ICommentable
    {
        private string name;
        private string myComment;
        private int numberOfLectures;
        private int numberOfExercises;
        
        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string myComment)
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.MyComment = myComment;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null");
                }

                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number should be more than 0");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number should be more than 0");
                }

                this.numberOfExercises = value;
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


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Name: {0}", this.Name);
            sb.Append("\n");
            sb.AppendFormat("Number of Lectures: {0}", this.NumberOfLectures);
            sb.Append("\n");
            sb.AppendFormat("Number of Exercises: {0}", this.NumberOfExercises);
            sb.Append("\n");
            if (!string.IsNullOrEmpty(this.MyComment))
            {
                sb.AppendFormat("Comment: {0}", this.MyComment);
                sb.Append("\n");
            }


            return sb.ToString();
        }
    }
}
