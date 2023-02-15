using System;

class Program
{


    static bool IsUpperCase(string str)
    {
        return str.Equals(str.ToUpper());
    }

    public static void Main(string[] args)
    {
      Predicate <string > isUpper = IsUpperCase;

        bool result = isUpper("PRAGYA!!");

        Console.WriteLine(result);
    }


}
