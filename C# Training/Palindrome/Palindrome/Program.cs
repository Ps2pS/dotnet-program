using System;
namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check Palindrome:");
            int number = int.Parse(Console.ReadLine());
            int rem, sum = 0;
            int temp = number;
            while(number > 0)
            {
                rem = number % 10;
                sum = (sum * 10) + rem;
                number = number / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine($"Number{temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number{temp} is not a Palindrome.");
            }
            Console.ReadKey();
          

        }
    }
}