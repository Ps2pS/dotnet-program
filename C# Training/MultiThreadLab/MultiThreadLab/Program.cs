using System;
using System.Threading;
class MyApp
{
    public void MyWork(object pr)  //long running
    {
        Thread.Sleep(1000);
        Console.WriteLine("going to Karolbagh to purchase crackers...."+" " +pr);
        
    }

    public void mywork1()
    {
        Console.WriteLine("local task");
    }
}

class client
{
    public static void Main()
    {
        MyApp obj = new MyApp();
        Thread th = new Thread(new ParameterizedThreadStart(obj.MyWork)); //separate thread
        th.Start("100"); // execute
        obj.mywork1();  //main thread
    }
}