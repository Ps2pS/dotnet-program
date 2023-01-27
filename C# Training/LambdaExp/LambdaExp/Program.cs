using System;



class Pragya
{
    public static void Main()
    {
        var square = (int num) => num * num;
        Console.WriteLine("Enter the number:");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Square of number:{0} ", square(i));
      


    }
}