using System;
enum specialityType
{
    GeneralMedicine = 1,
    Orthopaedics = 2,
    Dental = 3
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
    public string Speciality;
    public string Depart;
    //method to set details
    public void setInfo(int PatientId, string FirstName, string LastName, long PhoneNo, string Gender, int Age, string Address, long AadharNo, string Speciality, string Depart)
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
        this.Depart = Depart;
    }
    public string Departments(string dep1)
    {
        return dep1;
    }
    public string Departments(string dep1, string dep2)
    {
        return dep1 + dep2;
    }
    //method to print  details
    public void printInfo()
    {
        Console.WriteLine("\nPatient Record:\n ");
        Console.Write(PatientId + "," + FirstName + ", " + LastName + ", " + PhoneNo + ", " + Gender + ", " + Age + ", " + AadharNo + ", " + Depart + ", ");
        Console.Write(Speciality);
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please Enter the length of records");
        int recordLength = Convert.ToInt32(Console.ReadLine());
        Job[] jobArray = new Job[recordLength];
        Job job = new Job();
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
                        jobArray[i] = new Job();
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
                        string Aadhar = Console.ReadLine();
                        while (Aadhar != null)
                        {
                            if (Aadhar.Length != 12 && !Aadhar.Any(c => c < '0' || c > '9'))
                            {
                                Console.WriteLine("\n\tEnter a valid aadhar number");
                                goto checkAadhar;
                            }
                            else
                            {
                                if (Aadhar.Contains("12"))
                                {
                                    Console.WriteLine("valid aadhar number");
                                    job.AadharNo = Convert.ToInt64(Aadhar);
                                    break;
                                }
                            }
                        }
                        Console.WriteLine("Select the Department: \n 1. General Medicine \n 2. Orthopaedics \n 3. Dental \n 4. Paediatrics \n 5. Dermatology");
                        int x = Convert.ToInt32(Console.ReadLine());
                        specialityType s = (specialityType)x;
                        job.Speciality = Convert.ToString(s);
                        Console.WriteLine("which department u need :1 for pediatrics  else  pediatrics,ENT");
                        int depa = Convert.ToInt32(Console.ReadLine());
                        if (depa == 1)
                        {
                            job.Depart = job.Departments("pediatrics");
                        }
                        else
                        {
                            job.Depart = job.Departments("pediatrics", "ENT");
                        }
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