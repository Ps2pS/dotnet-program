using System;
using System.Security.Cryptography.X509Certificates;
//Why Task Parallel Library?
using System.Threading;
using System.Threading.Tasks;
public class database
{

    public static void fetchdata()
    {
        Thread.Sleep(10000);
        Console.WriteLine("Yes Prepared");
    }
}

public class businesslogiclayer
{
    public  static void caller()
    {
        Task.Run(new Action(database.fetchdata)); //at this point new thread will be generated over separate processor
      //database.fetchdata();
      
    }
}
public class customer
{
    public static void Main()
    {
        businesslogiclayer.caller();
        Console.WriteLine("when i will execute...");
        Console.ReadLine();
    }
}//Parallel Execution 