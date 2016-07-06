namespace DefiningClassesOne
{
    using System;
    using System.Collections.Generic;

    public class Battery
    {
        private BatteryType model;
        private double? hoursIdle;
        private double? hourstalk;

        public Battery(BatteryType model)
        {
            this.Model = model;
            this.HoursIdle = null;
            this.Hourstalk = null;
        }

        public Battery(BatteryType model, double? hoursIdle, double? hourstalk)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.hourstalk = hourstalk;
        }

        public BatteryType Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle can not be less than 0");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double? Hourstalk
        {
            get
            {
                return this.hourstalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The talk hours can not be less than 0");
                }
                else
                {
                    this.hourstalk = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("Battery model {0}, Hours Idle: {1}, Hours talk: {2} ", this.Model, this.HoursIdle, this.Hourstalk);
        }
    }
}
