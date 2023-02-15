using System;

namespace Me
{
    //Delegate declaration
    public delegate int MathDelegate(int value1, int value2);
    public delegate void MessageDelegate(int value);
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating delegate
            MathDelegate mathDelegate = new MathDelegate(AddCallback);
             int total = mathDelegate(30, 20);

            MessageDelegate messageDelegate = MessageCallback;
            messageDelegate.Invoke(total);
            Console.ReadKey();
        }

        static int AddCallback(int value1, int value2)
        {
            return value1 + value2;
        }

        static void MessageCallback(int value)
        {
            Console.WriteLine("Total is :", + value);
        }
    }
}