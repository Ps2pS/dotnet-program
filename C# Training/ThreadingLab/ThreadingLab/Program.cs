using System;
using System.Threading;
 class MyApp
{
    public void MyWork()  //long running
    {
        Console.WriteLine("going to Karolbagh......Time consuming");
        Thread.Sleep(1000);
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
        obj.MyWork();
        obj.mywork1();  //why i suffer ?
    }
}