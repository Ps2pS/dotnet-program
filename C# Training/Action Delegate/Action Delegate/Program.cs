using System;

class Program
{


    public static void GetMessage(int name)
    {
        Console.WriteLine( " pragya"  + name);
    }

    public static void Main(string[] args)
    {
        Action<int> temp = GetMessage;
        temp(5);
    }


}
