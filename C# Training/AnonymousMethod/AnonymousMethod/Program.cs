//using System;

//namespace AnonymousMethod
//{

//    public class pragya
//    {
//        public delegate void MyDelegate(int number); //delegate

//        static void Main(string[] args)
//        {   

//            MyDelegate myDelegate = delegate (int number)
//            {
//                Console.WriteLine("The number is " + number);
//            };

//            myDelegate(100);
//        }

//        public static void printnumber(int number)
//        {
//            console.writeline("the number is " + number);
//        }
//    }
//}
using System;

delegate int TrainingDelegate(string s);

class Sumit
{
    public static void Main()
    {
        TrainingDelegate obj = delegate (string obj)
        {
            return 1;
        };
        int name = obj("Pragya");
        Console.WriteLine(name);
    }
}