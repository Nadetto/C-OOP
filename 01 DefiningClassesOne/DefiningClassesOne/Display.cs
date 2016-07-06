namespace DefiningClassesOne
{
    using System;
    using System.Collections.Generic;
 
    public class Display
    {
        private double? size;
        private double? numberOfColours;

        public Display()
        {
            this.Size = null;
            this.NumberOfColours = null;
        }

        public Display(double? size, double? numberOfColours)
        {
            this.Size = size;
            this.NumberOfColours = numberOfColours;
        }

        public double? Size 
        {
            get
            {
                return this.size;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Size can not be less than 0");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public double? NumberOfColours
        {
            get
            {
                return this.numberOfColours;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("The number of the colours can not be less than 0");
                }
                else
                {
                    this.numberOfColours = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("Display size: {0}, Display number of colours: {1}", this.Size, this.NumberOfColours);
        }
    }
}
