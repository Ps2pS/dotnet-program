using System;

delegate int TrainingDelegate(string s);
public class pragya
{
    public int trainingSubject(string subj)
    {
        return 1;
    }
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
        TrainingDelegate trobj = new TrainingDelegate(obj.trainingSubject);
        int time= trobj("Full stack Training");
        Console.WriteLine(time);
    }
}


