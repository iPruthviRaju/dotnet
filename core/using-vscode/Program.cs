using System;

namespace using_vscode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Reverse of string Pruthvi is {ReverseString("Pruthvi")}");
        }

        static string ReverseString(string input)
        {
            int length = input.Length;

            char[] reverseChar = new char[length];

            for(int incrementer = 0, decrementer = length - 1; incrementer < length; incrementer++, decrementer--)
            {
                reverseChar[incrementer] = input[decrementer];
            }

            return new string(reverseChar);
        }
    }
}
