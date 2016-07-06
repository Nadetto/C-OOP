namespace DefiningClassesOne
{
    using System;
    using System.Collections.Generic;

    public class Call
    {
        // contain date, time, dialled phone number and duration (in seconds).
        private DateTime dateTime;
        
        
       

        public Call()
        {
            this.dateTime = DateTime.Now;
        }

        public string DialledNumber{ get; set; }
        public long Duration{ get; set; }
        public string Time
        {
            get
            {
                return this.dateTime.ToString("HH:mm:ss");
            }
        }

        public string Date
        {
            get
            {
                return this.dateTime.ToString("dd/MM/yyyy");
            }
        }

        public override string ToString()
        {
            return string.Format("Dialled num: {0}, duration: {1}, time: {2}, date {3}", 
                this.DialledNumber, this.Duration, this.Time, this.Date);
        }

    }
}
