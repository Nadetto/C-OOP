namespace DefiningClassesOne
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {

            var instanceOfGSMTest = new GSMTest();
            instanceOfGSMTest.DysplayInformationAndTestGSM();


            var instanceOfGSMCallHistoryTest = new GSMCallHistoryTest();
            instanceOfGSMCallHistoryTest.TestFuncionalityOfGSM();

            
        }
    }
}
