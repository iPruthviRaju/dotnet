///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>July 29th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0001_Task_Program
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Start] - Main without Task.WaitAll for Task1 and Task2");

            Task task1 = new Task(() => Perform("Task1 without wait", 2000));
            task1.Start();

            Task.Run(() => Perform("Run command in task", 2000));

            Task.Factory.StartNew(() => Perform("Task2 without wait", 2000));

            Console.WriteLine("[End] - Main end without Task.WaitAll for Task1 and Task2");

            Console.WriteLine("[Start] - Main with Task.WaitAll for Task3 and Task4");

            var t3 = Task.Factory.StartNew(() => Perform("Task3 with wait", 2000));
            var t4 = Task.Factory.StartNew(() => Perform("Task4 with wait", 2000));


            Task.WaitAll(new Task[] { t3, t4 });

            Console.WriteLine("[End] - Main with Task.WaitAll for Task3 and Task4");

            Console.ReadLine();
        }

        static void Perform(string task, int sleepTime)
        {
            Console.WriteLine($"Entering Perform - {task}");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"Leaving Perform - {task}");
        }
    }
}
