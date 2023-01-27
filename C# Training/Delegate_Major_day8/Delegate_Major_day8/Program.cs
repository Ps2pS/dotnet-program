using System;

delegate void personal_delegate();

 public class personal
{
    public void trainingStatus()
    {
        Console.WriteLine("Adv. c# is going on");
    }

    public void trainingAddress()
    {
        Console.WriteLine("Noida Sector 63");
    }
   public double expenses()
    {
        return 12500.50;
    }
}
  public class usersumit:personal
  {
    public static void Main()
    {
        personal obj = new personal();
        personal_delegate objdelegate = new personal_delegate(obj.trainingStatus);
        objdelegate += obj.trainingAddress;
        objdelegate();
        
    }
  }

