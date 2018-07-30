///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>July 30th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0001_AutoResetEvent
{
    using System;
    using System.Threading;
    class Program
    {
        static AutoResetEvent autoEvent;

        static void DoWork()
        {
            Console.WriteLine("   worker thread started, now waiting on event...");
            autoEvent.WaitOne();
            Console.WriteLine("   worker thread reactivated, now exiting... press enter");
        }

        static void Main()
        {
            autoEvent = new AutoResetEvent(false);

            Console.WriteLine(" main thread starting worker thread...");
            Thread t = new Thread(DoWork);
            t.Start();

            Console.WriteLine(" main thread sleeping for 5 second...");
            Thread.Sleep(5000);
            Console.WriteLine(" main thread signaling worker thread... press enter..");

            Console.ReadLine();

            autoEvent.Set();

            Console.ReadLine();
        }
    }
}