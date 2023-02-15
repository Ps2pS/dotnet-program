using System;

class Program
{


    public static string GetMessage(string name)
    {
        return "My name is " + name;
    }

    public static void Main(string[] args)
    {
        Func<string,string> temp = GetMessage;
        Console.WriteLine(temp("Pragya"));
    }

    
}
  