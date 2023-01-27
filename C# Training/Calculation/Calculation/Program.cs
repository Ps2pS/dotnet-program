using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string value;
            //do
            //{
            //int res;
            Console.Write("Enter first name:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second name:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Symbol(/,+,-,*):");
            string symbol = Console.ReadLine();

            if (symbol == "+")
                {
                    Console.WriteLine("Sum of the two numbers is:  {0} ", num1 + num2);
                }
                else if (symbol == "*")
                {
                    Console.WriteLine(" Multiplication of the two numbers is :  {0} ", num1 * num2);
                }
                else if (symbol == "-")
                {
                    Console.WriteLine(" Subtraction of the two numbers is :  {0} ", num1 - num2);
                }
                else if (symbol == "/")
                {
                    Console.WriteLine(" Division of the two numbers is :  {0}", num1 / num2);
                }
                else {
                    Console.WriteLine("Please enter valid operation");
                        }
                //switch (symbol)
                //{
                //    case "+":
                //        res = num1 + num2;
                //        Console.WriteLine("Addition:" + res);
                //        break;
                //    case "-":
                //        res = num1 - num2;
                //        Console.WriteLine("Subtraction:" + res);
                //        break;
                //    case "*":
                //        res = num1 * num2;
                //        Console.WriteLine("Multiplication:" + res);
                //        break;
                //    case "/":
                //        res = num1 / num2;
                //        Console.WriteLine("Division:" + res);
                //        break;
                //    default:
                //        Console.WriteLine("Wrong Input");
                //        break;
                //}
            //    Console.ReadLine();
            //    Console.Write("Do you want to continue y/n:");
            //    value = Console.ReadLine();
            //}
            //while (value == "y" || value == "Y");
        }
    }
}