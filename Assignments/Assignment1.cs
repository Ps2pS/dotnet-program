using System;
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

    //method to set student details
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

    //method to print student details
    public void printInfo()
    {
        Console.WriteLine("\nPatient Details\n");
        Console.WriteLine("\tPatientId  : " + PatientId);
        Console.WriteLine("\tFirst Name : " + FirstName);
        Console.WriteLine("\tLast Name  : " + LastName);
        Console.WriteLine("\tPhone no   : " + PhoneNo);
        Console.WriteLine("\tGender     : " + Gender);
        Console.WriteLine("\tAge        : " + Age);
        Console.WriteLine("\tAadhar no  : " + AadharNo);
        switch (Speciality)
        {
            case 1: Console.WriteLine("\tPatient Department : General Medicine");
                break;
            case 2: Console.WriteLine("\tPatient Department : Orthopaedics");
                break;
            case 3: Console.WriteLine("\tPatient Department : Dental");
                break;


        }
    }
   
}

class Program
{
    public static void Main()

    {
        Job[] jobArray = new Job[2];
        Job job=new Job();
        for(int i=0; i<jobArray.Length; i++)
        {
            jobArray[i]= new Job();
            Console.WriteLine("Please enter patient id");
            job.PatientId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter First Name");
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
            job.AadharNo = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Select the Department: \n 1. General Medicine \n 2. Orthopaedics \n 3. Dental");
            job.Speciality = Convert.ToInt32(Console.ReadLine());

            jobArray[i] = job;
        }
        for(int i=0; i < jobArray.Length; i++)
        {
            jobArray[i].printInfo();
        }

    }
}