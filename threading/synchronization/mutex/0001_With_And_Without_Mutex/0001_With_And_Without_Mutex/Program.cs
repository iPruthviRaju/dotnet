///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>July 25th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
namespace _0001_With_And_Without_Mutex
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            int counter_using_mutex = 0;
            int normal_counter = 0;

            Mutex mutex = new Mutex();

            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i < 10000000; i++)
                {
                    normal_counter++;
                    mutex.WaitOne();
                    counter_using_mutex++;
                    mutex.ReleaseMutex();
                }
            }
            );

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 10000000; i++)
                {
                    normal_counter++;
                    mutex.WaitOne();
                    counter_using_mutex++;
                    mutex.ReleaseMutex();
                }
            }
            );

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine($"We expects result as 20000000 for premitive types.");
            Console.WriteLine($"Actual  : Normal counter - {normal_counter}, Counter using mutex - {counter_using_mutex}");
            Console.ReadLine();
        }
    }
}
