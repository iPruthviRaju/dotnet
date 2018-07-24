///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>July 24th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0001_Simple_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Without threading or sequential.");
            Func1();
            Func2();

            Console.WriteLine("With threading or parallel.");
            Thread t1 = new Thread(Func1);
            Thread t2 = new Thread(Func2);
            t1.Start();
            t2.Start();

            Console.ReadLine();
        }

        static void Func1()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func1 - {i}");
                Thread.Sleep(2000);
            }
        }

        static void Func2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func2 - {i}");
                Thread.Sleep(2000);
            }
        }
    }
}
