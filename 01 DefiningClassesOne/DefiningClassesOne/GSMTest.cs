namespace DefiningClassesOne
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public void DysplayInformationAndTestGSM()
        {
            var display = new Display(5.9, 252);
            var battery = new Battery(BatteryType.LiIon, 500, 60);
            var gsm = new GSM("Lg350", "LG", 205, "Pesho", battery, display);

            var displaySamsung = new Display(7, 16000);
            var batterySamsung = new Battery(BatteryType.LiIon, 1000, 999);
            var gsmSamsung = new GSM("Model", "Samsung", 500, "Ida", batterySamsung, displaySamsung);

            var listGsm = new List<GSM>() { gsm, gsmSamsung };

            foreach (var gsmInList in listGsm)
            {
                Console.WriteLine(gsmInList.ToString());
            }

            Console.WriteLine(GSM.IPhone4gs.ToString());
            
        }

    }
}
