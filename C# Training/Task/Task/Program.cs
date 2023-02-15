using System;
  

class Operations
{
    public int Operation;

    public void SetInfo(int Operation)
    {
        this.Operation = Operation;
    }

    public void printInfo()
    {
        Console.WriteLine("\n Select the OPeration \n");
        switch (Operation)
        {
            case 1:
                Console.WriteLine("\t Operation: Factorial");
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                long factorial = 1;
                do
                {
                    factorial = factorial * number;
                    number--;
                }
                while (number > 0);
                Console.WriteLine($"The factorial number is: {factorial}");
                Console.ReadLine();
                break;
                case 2:
                Console.WriteLine("\t Operation: Fibonacci");
                break;
                case 3:
                Console.WriteLine("\t Operation: Palindrome");
                break;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select the Operation: \n 1. Factorial \n 2. Fibonacci \n 3. Palindrome");
       
    }
}