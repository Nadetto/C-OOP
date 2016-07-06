namespace DefiningClassesOne
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private static GSM iPhone4gs = new GSM("iPhone4gs", "Apple", 500, "Gosho");
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;         

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
            this.CallHistory = new List<Call>(); //initializing, otherwise it will be Null and throw some exception
        }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer)
        {
            this.Price = price;            
        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner,
            Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
            set
            {
                if(this.callHistory == null)
                {
                    this.callHistory = new List<Call>();
                }
                this.callHistory.Clear();
                this.callHistory = value;
            } 
        }

        public static GSM IPhone4gs 
        {
            get
            {
                return iPhone4gs;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != String.Empty && value != null)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Value of model is empty or null");
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != String.Empty && value != null)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("Value of manufacturer is empty or null");
                }
            }
        }
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price can not be less than 0");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value != string.Empty)//&& value != null)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("Value of owner is empty or null");
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public void AddCall(Call call)
        {           
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateCallPrice(decimal pricePerMinute)
        {
            decimal result = 0;
            foreach (var call in this.CallHistory)
            {
                result += pricePerMinute * call.Duration / 60;
            }

            return result;
        }

        public string CallHistoryInfo()
        {
            var sb = new StringBuilder();

            if (this.CallHistory.Count == 0)
            {
                sb.Append("There are no calls in the Call History");
            }
            else
            {
                for (int i = 0; i < this.CallHistory.Count; i++)
                {
                    sb.Append(this.CallHistory[i].ToString());
                    sb.Append("\n");
                }
            }

            return sb.ToString();
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            //StringBuilder sb = new StringBuilder();
           // sb.AppendFormat("")
            return String.Format("The model is: {0}, manufacturer: {1}, price: {2}, Owner {3}, Battery: {4}, Display {5}", this.Model, this.Manufacturer, this.Price, this.Owner, this.Battery, this.Display);
        }
    }
}
