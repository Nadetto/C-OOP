namespace DefiningClassesOne
{
    using System;
    using System.Collections.Generic;

    public class GSMCallHistoryTest
    {
        public void TestFuncionalityOfGSM()
        {
            var call = new Call() { Duration = 180, DialledNumber = "3456" };
            Console.WriteLine(call.Date);
            Console.WriteLine(call.Time);
            Console.WriteLine(call.ToString());

            var call2 = new Call() { Duration = 600, DialledNumber = "5258" };
            var call3 = new Call() { Duration = 60, DialledNumber = "1111" };

            var display = new Display(5.9, 252);
            var battery = new Battery(BatteryType.LiIon, 500, 60);
            var gsm = new GSM("Lg350", "LG", 205, "Pesho", battery, display);

            Console.WriteLine(gsm.ToString());

            gsm.AddCall(call);
            gsm.AddCall(call2);
            gsm.AddCall(call3);

            foreach (var item in gsm.CallHistory)
            {
                Console.WriteLine(item);
            }

            decimal pricePerMinute = 0.37m;

            decimal totalPrice = gsm.CalculateCallPrice(pricePerMinute);
            Console.WriteLine(totalPrice);

            var longestCall = new Call();
            foreach (var itemCall in gsm.CallHistory)
            {
                if (longestCall.Duration < itemCall.Duration)
                {
                    longestCall = itemCall;
                }
            }

            gsm.DeleteCall(longestCall);


            totalPrice = gsm.CalculateCallPrice(pricePerMinute);
            Console.WriteLine(totalPrice);

            Console.WriteLine(gsm.CallHistoryInfo());

            gsm.ClearHistory();
            Console.WriteLine(gsm.CallHistoryInfo());

        }
    }
}
