namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DefClasses
    {
        static void Main()
        {
            GSM firstTest = new GSM("Desire 500", "HTC", 500, "Stamat Peshov");
            GSM secondTest = new GSM("A3", "Samsmung", 350, "Dimitar Stoyanov");
            GSM thirdTest = new GSM("One Mini", "HTC", 800, "Strinka Krustanova");

            // Test Battery
            firstTest.BatteryCharacteristics = new Battery("Li-lon");
            //Console.WriteLine(firstTest.BatteryCharacteristics.Model);

            // Test Display
            firstTest.DisplayCharacteristics = new Display("500 X 500", 3);
            //Console.WriteLine(firstTest.DisplayCharacteristics.Size);
            
            // Test GSM 
            GSMTest tst = new GSMTest();

            tst.gsmTest.Add(firstTest);
            tst.gsmTest.Add(secondTest);
            tst.gsmTest.Add(thirdTest);

            tst.gsmTest[0].SeeAllGSMInformation(); // work
            tst.gsmTest[1].SeeAllGSMInformation(); // work
            tst.gsmTest[2].SeeAllGSMInformation(); // work
                                                // Console.WriteLine(tst.gsmTest[0].IPhone4S = "Apple");

            // Test call history 

            GSMCallHistoryTest testCalls = new GSMCallHistoryTest("One", "HTC");

            testCalls.TestFunctionality();

        }
    }
}
