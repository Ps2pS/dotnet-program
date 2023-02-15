using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BasicDemo
{
    class ThreadExample
    {
        static void Display()
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Process is {0}" , i);
                Thread.Sleep(2000);
            }
        }
        static void Main()
        {
            ThreadStart th = new ThreadStart(ThreadExample.Display);
            Thread t = new Thread(th);   //ready state
            t.Start();  // running state

            Console.ReadKey();
        }   
                                                                                                                                                                                                                                                                                                                                    
    }
}