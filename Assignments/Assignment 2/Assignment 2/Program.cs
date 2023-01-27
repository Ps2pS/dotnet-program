using System;
using System.Net;
using System.Reflection;

public enum specialityType
{
    GeneralMedicine, Orthopaedics, Dental
}
class Job
{
    //data members
    public int PatientId;
    public string FirstName;
    public string LastName;
    public long PhoneNo;
    public string Gender;
    public int Age;
    public string Address;
    public long AadharNo;
    public int Speciality;


    //method to set details
    public void SetInfo(int PatientId, string FirstName, string LastName, long PhoneNo, string Gender, int Age, string Address, long AadharNo, int Speciality)
    {
        this.PatientId = PatientId;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.PhoneNo = PhoneNo;
        this.Gender = Gender;
        this.Age = Age;
        this.AadharNo = AadharNo;
        this.Address = Address;
        this.Speciality = Speciality;

    }


    //method to print details
    public void printInfo()
    {
        Console.WriteLine("\nPatient Record:\n ");
        Console.Write(PatientId + "," + FirstName + ", " + LastName + ", " + PhoneNo + ", " + Gender + ", " + Age + ", " + AadharNo + ", ");
        Console.Write((specialityType)Speciality - 1 + "\n");
    }

}


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please Enter the length of records");
        int recordLength = Convert.ToInt32(Console.ReadLine());
        Job[] jobArray = new Job[recordLength];

        Console.Write("Enter position to delete item : ");
        char cont = 'y';
        while (Char.ToLower(cont) == 'y')
        {
            Console.WriteLine("\nChoose an options :\n1: Register \n2: View Details");
            int cases = Convert.ToInt32(Console.ReadLine());
            switch (cases)
            {
                case 1:
                    for (int i = 0; i < jobArray.Length; i++)
                    {
                        Job job = new Job();

                        Console.WriteLine("\nPatient " + i + "\n");
                        job.PatientId = i;

                        Console.Write("Enter First Name:");
                        job.FirstName = Console.ReadLine();

                        Console.Write("Enter Last Name :");
                        job.LastName = Console.ReadLine();

                        Console.Write("Enter Phone No :");
                        job.PhoneNo = Convert.ToInt64(Console.ReadLine());

                        Console.Write("Enter Gender:");
                        job.Gender = Console.ReadLine();

                        Console.Write("Enter Age :");
                        job.Age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Address :");
                        job.Address = Console.ReadLine();

                        Console.Write("Enter Aadhar No :");
                    checkAadhar:

                        string AadharNo = Console.ReadLine();
                        while (job.AadharNo != null)
                        {
                            if (AadharNo.Length != 12 && !AadharNo.Any(c => c < '0' || c > '9'))
                            {
                                Console.WriteLine("\n\tEnter a valid aadhar number");
                                goto checkAadhar;
                            }

                            else
                            {
                                if (AadharNo.Contains("12"))
                                {
                                    Console.WriteLine("valid aadhar number");
                                    job.AadharNo = Convert.ToInt64(AadharNo);
                                    break;
                                }
                            }
                        }


                        Console.WriteLine("Select the Department: \n 1. General Medicine \n 2. Orthopaedics \n 3. Dental");

                        int x = (int)specialityType.GeneralMedicine;

                        int y = (int)specialityType.Orthopaedics;

                        int z = (int)specialityType.Dental;
                        job.Speciality = int.Parse(Console.ReadLine());

                        jobArray[i] = job;


                    }
                    break;
                case 2:
                    for (int j = 0; j < jobArray.Length; j++)
                    {
                        jobArray[j].printInfo();

                    }
                    break;
                default:
                    Console.WriteLine("Please Choose Valid");
                    break;
            }
            Console.WriteLine("Press y or Y to continue; press any other key to exit.");
            cont = Convert.ToChar(Console.ReadLine());

        }



    }
}