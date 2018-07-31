///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>July 31st, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0002_AutoVsManual
{
    using System;
    using System.Threading;
    class Program
    {
        static AutoResetEvent autoEvent;
        static ManualResetEvent manualEvent;

        static void DoWorkAutoEvent(int i)
        {
            Console.WriteLine($"   AutoEvent-{i} worker thread started, now waiting on event...");
            autoEvent.WaitOne();
            Console.WriteLine($"   AutoEvent-{i} worker thread reactivated, now exiting... press enter");
        }

        static void DoWorkManualEvent(int i)
        {
            Console.WriteLine($"   ManualEvent-{i} worker thread started, now waiting on event...");
            manualEvent.WaitOne();
            Console.WriteLine($"   ManualEvent-{i} worker thread reactivated, now exiting... press enter");
        }

        static void Main()
        {
            autoEvent = new AutoResetEvent(false);
            manualEvent = new ManualResetEvent(false);

            Console.WriteLine(" AutoEvent-3 will never reactivate since each and every auto-event should have another set, ");
            Console.WriteLine(" unlike manual-event set will reactivate all manual-events.");
            Console.WriteLine();
            Console.WriteLine(" main thread starting worker thread...");

            Thread t1 = new Thread(() => DoWorkAutoEvent(1));
            t1.Start();

            Thread t2 = new Thread(() => DoWorkAutoEvent(2));
            t2.Start();

            Thread t3 = new Thread(() => DoWorkAutoEvent(3));
            t3.Start();

            Thread t4 = new Thread(() => DoWorkManualEvent(1));
            t4.Start();

            Thread t5 = new Thread(() => DoWorkManualEvent(2));
            t5.Start();

            Thread t6 = new Thread(() => DoWorkManualEvent(3));
            t6.Start();

            Console.WriteLine(" main thread sleeping for 5 second...");
            Thread.Sleep(5000);
            Console.WriteLine(" main thread signaling worker thread... press enter..");

            Console.ReadLine();

            autoEvent.Set();
            autoEvent.Set();
            //Above two autoEvent.Set() will reactivate AutoEvent-1 and AutoEvent-2, if want to reactivate AutoEvent-3 we should invoke one more autoEvent..
            manualEvent.Set();//This will reactivate all 2 manual events.

            Console.ReadLine();
        }
    }
}
