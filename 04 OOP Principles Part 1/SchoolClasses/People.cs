namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class People : ICommentable
    {
        private string name;
        private string myComment;

        public People(string name)
        {
            this.Name = name;
        }

        public People(string name, string myComment)
            :this(name)
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
            if (!string.IsNullOrEmpty(this.MyComment))
            {
                sb.AppendFormat("Comment: {0}", this.MyComment);
                sb.Append("\n");
            }
            
            return sb.ToString();
        }
    }
}
