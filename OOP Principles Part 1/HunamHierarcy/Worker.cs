using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunamHierarcy
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHourPerDay) 
            : base(firstName, lastName)
        {

        }

        public decimal WeekSalary { get; set; }

        public decimal WorkHourPerDay { get; set; }

        public void MoneyPerHour();
    }
}
