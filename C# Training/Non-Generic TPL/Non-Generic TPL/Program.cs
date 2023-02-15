using System;
using System.Security.Cryptography.X509Certificates;
//Why Task Parallel Library?
using System.Threading;
using System.Threading.Tasks;
public class Internet
{

    public static void Download()
    {
        Thread.Sleep(10000);
        Console.WriteLine("Downloaded");
    }
}

public class businesslogiclayer
{
    public static void Meeting_Point()
    {
        Task.Run(new Action(Internet.Download)); //at this point new thread will be generated over separate processor
        Console.WriteLine("After downloading I will give this software to Pragya");                                        
    }
}
public class customer
{
    public static void Main()
    {
        businesslogiclayer.Meeting_Point();
        Console.WriteLine("Why i wait for 10 seconds...");
        Console.ReadLine();
    }
}//Parallel Execution 