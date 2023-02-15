using System;

delegate int TrainingDelegate(string s);
public class pragya
{
    
    
    public void expenses()
    {
        Console.WriteLine("Daily expenses 200 Rs.");
    }
}

class sumit
{
    public static void Main()
    {
        pragya obj = new pragya();
        TrainingDelegate trobj = delegate (string s) //delegate block
        {
            return 5;
        };

       int t = trobj("dotnet");
        Console.WriteLine(t);
       
    }
}


