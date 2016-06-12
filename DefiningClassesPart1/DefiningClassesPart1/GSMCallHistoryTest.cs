namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;

    class GSMCallHistoryTest
    {
        public static GSM testCalls;

        public GSMCallHistoryTest(string model, string manyfacturer)
        {
            testCalls = new GSM(model, manyfacturer);
        }

        public void TestFunctionality ()
        {
            //  This is the default calls.
            //  Just for the test.

            Call firstCall = new Call("05/03/2014", "12:23", "0884321", 20);
            Call secondCall = new Call("02/08/2015", "13:35", "07757454", 10);
            Call thirdCall = new Call("04/04/2014", "23:34", "06908472", 12);

            testCalls.AddCall(firstCall);
            testCalls.AddCall(secondCall);
            testCalls.AddCall(thirdCall);

            Console.WriteLine(testCalls.TotalPriceOfTheCalls(0.37, testCalls.CallHistory.Count));

            testCalls.DeleteCall(firstCall);

            Console.WriteLine(testCalls.TotalPriceOfTheCalls(0.37, testCalls.CallHistory.Count));

            testCalls.ViewAllCallInformation(testCalls.CallHistory[0]);
            testCalls.ViewAllCallInformation(testCalls.CallHistory[1]);
        }
    }
}
