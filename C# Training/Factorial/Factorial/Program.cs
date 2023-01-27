//using System;

//namespace Factorial
//{
//    class Program
//    {     
//        //using for loop
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a Number: ");
//            int number = int.Parse(Console.ReadLine());

//            int factorial = 1;
//            for(int i=1; i<= number; i++)
//            {
//                factorial = factorial * i;
//            }
//            Console.WriteLine($"Factorial of {number} is: {factorial}");
//            Console.ReadLine();
//        }
//    }
//}

// using while loop

//using System;

//namespace Factorial
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number:");
//            int number = int.Parse(Console.ReadLine());
//            long factorial = 1;
//            while(number != 1)
//            {
//                factorial = factorial * number;
//                number = number - 1;
//            }
//            Console.WriteLine($"Factorial is: {factorial}");
//            Console.ReadLine();
//        }
//    }
//}

//using System;

//namespace FactRecursive
//{
//    class Program
//    {
//         public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number:");
//            int number = int.Parse(Console.ReadLine());

//            long factorial = RecursiveFactorial(number);
//            Console.WriteLine($"Factorial of {number} is: {factorial}");
//            Console.ReadLine();

//        }
//        static long RecursiveFactorial(int number)
//        {
//            if (number == 1)
//            {
//                return 1;
//            }
//            else
//            {
//                return number * RecursiveFactorial(number - 1);
//            }
//        }
//    }
//}

using System;

namespace Factorial
{
    class Program
    {
        public static void Main(string[] args)
        {
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
        }
    }
}