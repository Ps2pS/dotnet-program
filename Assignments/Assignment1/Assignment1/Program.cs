using System;
 class Job
{
    public int PatientId;
    public string FirstName;
    public string LastName;
    public long PhoneNo;
    public string Gender;
    public int Age;
    public string Address;
    public long AdharNo;
    public int Speciality;

    public void SetInfo(int PatientId, string FirstName, string LastName, long PhoneNo, string Gender, int Age, string Address, long AdharNo, int Speciality)
    {
        this.PatientId = PatientId;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.PhoneNo = PhoneNo;
        this.Gender = Gender;
        this.Address = Address;
        this.AdharNo = AdharNo;
        this.Speciality = Speciality;
    }

    public void printInfo()
    {
        Console.WriteLine("\n Patient Details\n");
        Console.WriteLine("\n PatientId: " + PatientId);
        Console.WriteLine("\n FirstName: " + FirstName);
        Console.WriteLine("\n LastName: " + LastName);
        Console.WriteLine("\n PhoneNo: " + PhoneNo);
        Console.WriteLine("\n Gender: " + Gender);
        Console.WriteLine("\n Address: " + Address);
        Console.WriteLine("\n AdharNo: " + AdharNo);
        switch (Speciality)
        {
            case 1:
                Console.WriteLine("\t Patient Department: General Medicine");
                break;
            case 2:
                Console.WriteLine("\t Patient Department: Orthopaedics");
                break;
            case 3:
                Console.WriteLine("\t Patient Department: Dental");
                break;
        }

    }
}
 class Program
{
    public static void Main(string[] args)
    {
        Job[] jobArray = new Job[2];
        Job job = new Job();
        for (int i = 0; i < jobArray.Length; i++)
        {
            jobArray[i] = new Job();
            Console.WriteLine(" Please enter PatientId");
            job.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter FirstName");
            job.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter LastName");
            job.LastName = Console.ReadLine();
            Console.WriteLine("Please enter PhoneNo");
            job.PhoneNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter Gender");
            job.Gender = Console.ReadLine();
            Console.WriteLine("Please enter Address");
            job.Address = Console.ReadLine();
            Console.WriteLine("Please enter AdharNo");
            job.AdharNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Select the Department: \n 1. General Medicine \n 2. Orthopaedics \n 3. Dental");
            job.Speciality = Convert.ToInt32(Console.ReadLine());

            jobArray[i] = job;


        }
        for (int i = 0; i < jobArray.Length; i++)
        {
            jobArray[i].printInfo();
        }
    }
}