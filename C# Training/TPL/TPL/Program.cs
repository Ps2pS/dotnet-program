using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Job
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 100, x => RunMillionIterations());
            Console.Read();
        }

        private static void RunMillionIterations()
        {
            string x = " ";
            for(int iIndex = 0; iIndex < 100; iIndex++)
            {
                x = x + "s";
            }
        }
    }
}