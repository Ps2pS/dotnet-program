using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatecallback
{
    class Program 
    {
        static void myCallBackCatcher(int i)
        {
            Console.WriteLine("Here",+i);
        }
        static void Main(string[] args)
        {

            myWorkClass myObj = new myWorkClass();
            myObj.myDoandDelay(myCallBackCatcher);
            Console.WriteLine("---ok");
            Console.ReadKey();
        }
    }

    class myWorkClass
    {
        public delegate void myCallBackPointer(int i );
        public void myDoandDelay(myCallBackPointer NewObj)
        {
            for(int i = 0; i < 100; i++)
            {
                //do stuff here
                Console.WriteLine(i);
                NewObj(i);
            }
        }
    }
   
}