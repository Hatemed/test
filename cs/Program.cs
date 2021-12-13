using System;
using System.Runtime.InteropServices;

namespace cs
{
    class Program
    {
        [DllImport(@"C:\Users\User\source\repos\test\x64\Debug\cpp.dll")]
        static extern int summ( int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine(summ(5, 2));
        }
    }
}
