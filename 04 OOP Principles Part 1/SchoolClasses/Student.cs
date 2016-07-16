namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student : People, ICommentable

    {
        private int unicClassNum;
        private List<int> allUnicNumbers = new List<int>();

        public Student(string name, int unicClassNum)
            :base(name)
        {
             this.UnicClassNum = unicClassNum;
             
        }

        public Student(string name, string myComment, int unicClassNum)
            : this(name, unicClassNum)
        {
            this.MyComment = myComment;
        }

        //check if number already exsists
        public int UnicClassNum
        {
            get { return this.unicClassNum; }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Number should be more than 0");
                }

                if(allUnicNumbers.Contains(value))
                {
                    throw new ArgumentException("Number already exsists");
                }

                this.unicClassNum = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Unique num: {0}", this.UnicClassNum);

            return sb.ToString();
        }
    }
}
