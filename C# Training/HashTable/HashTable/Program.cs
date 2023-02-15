using System;
using System.Collections;



namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            
            ht.Add("Id", 1123);
            ht.Add("Name", "Shivam");
            ht.Add("Salary", 80000.00);
            ht.Add("Designation", "Manager");
            ht.Add("IsMarried", false);


            Console.WriteLine(ht.Count);

            //Console.WriteLine("Shivam".GetHashCode());

            //Console.WriteLine(ht.Contains("Age"));
            //Console.WriteLine(ht.ContainsValue("Ali"));

            //Console.WriteLine(ht["Age"]);

            //foreach(object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " : " + ht[key]);
            //}
            //ht.Remove("Salary");
            //ht.Clear();
            //Console.WriteLine("----------------");
            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " : " + ht[key]);
            //}

            Console.ReadLine();
        }
    }
}

//{ "Id" ,1123 },
//                 { "Name" ,"Pragya" },
//                 { "Age" ,24 }