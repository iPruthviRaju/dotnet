///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>July 26th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
using System;
using System.Text;
using System.Threading.Tasks;

namespace _0001_With_And_Without_Lock
{
    class Program
    {
        private static readonly object obj = new object();
        static void Main(string[] args)
        {
            int counter_with_lock = 0;

            int counter_without_lock = 0;

            Task t1 = new Task(() =>
                {
                    for (int i = 0; i < 10000000; i++)
                    {
                        counter_without_lock++;
                        lock (obj)
                        {
                            counter_with_lock++;
                        }
                    }
                }
            );

            Task t2 = new Task(() =>
                {
                    for (int i = 0; i < 10000000; i++)
                    {
                        counter_without_lock++;
                        lock (obj)
                        {
                            counter_with_lock++;
                        }
                    }
                }
            );

            t1.Start();
            t2.Start();

            t1.Wait();
            t2.Wait();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"We expects result as 20000000 for value types.");
            builder.AppendLine($"Actual : ");
            builder.AppendLine($"counter_without_lock - {counter_without_lock} (this may vary on every run, but still inconsistent)");
            builder.AppendLine($"counter_with_lock - {counter_with_lock}");
            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }
    }
}
