using System;
using System.Threading;
public class Office
{
    public void print()
    {

        Monitor.Enter(this);
        try
        {

            for (int i = 1; i < 5; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
        }
        finally
        {
            Monitor.Exit(this);
        }
        

    }
}

public class Developer
{
    public static void Main()
    {
        Office obj1 = new Office();
        Thread[] th = new Thread[3]; //assuming that every developer is having separate thread
        for (int i = 0; i <= 2; i++)
        {
            th[i] = new Thread(new ThreadStart(obj1.print));
            th[i].Start();
        }
    }
}