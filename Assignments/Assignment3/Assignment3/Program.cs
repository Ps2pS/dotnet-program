public enum specialityType

{ GeneralMedicine = 1, Orthopaedics = 2, Dental = 3, Paediatrics = 4, Dermatology = 5 }

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

    //method to set details

    public Job(int PatientId, string FirstName, string LastName, long PhoneNo, string Gender, int Age, string Address, long AadharNo, string Speciality)

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

    // Destructor called

    ~Job()
    {

        Console.WriteLine("Destructors was called");

    }

    //method to print  details

    public void printInfo()

    {

        Console.WriteLine("\nPatient Record:\n ");

        Console.Write(PatientId + "," + FirstName + ", " + LastName + ", " + PhoneNo + ", " + Gender + ", " + Age + ", " + AadharNo + ", ");

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

        int pos = 0;

        Console.Write("Enter position to delete item : ");

        char cont = 'y';

        while (Char.ToLower(cont) == 'y')

        {

            Console.WriteLine("\nChoose an options :\n1: Register \n2: View Details\n3: Delete");

            int cases = Convert.ToInt32(Console.ReadLine());

            switch (cases)

            {

                case 1:

                    for (int i = 0; i < jobArray.Length; i++)

                    {

                        long AadharNo = 0;

                        Console.WriteLine("\nPatient " + i + "\n");

                        int PatientId = i;

                        Console.Write("Enter First Name:");

                        string FirstName = Console.ReadLine();

                        Console.Write("Enter Last Name :");

                        string LastName = Console.ReadLine();

                        Console.Write("Enter Phone No :");

                        long PhoneNo = Convert.ToInt64(Console.ReadLine());

                        Console.Write("Enter Gender:");

                        string Gender = Console.ReadLine();

                        Console.Write("Enter Age :");

                        int Age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Address :");

                        string Address = Console.ReadLine();

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

                                    AadharNo = Convert.ToInt64(Aadhar);

                                    break;

                                }

                            }

                        }

                        Console.WriteLine("Select the Department: \n 1. General Medicine \n 2. Orthopaedics \n 3. Dental \n 4. Paediatrics \n 5. Dermatology");

                        int x = Convert.ToInt32(Console.ReadLine());

                        specialityType s = (specialityType)x;

                        string Speciality = Convert.ToString(s);

                        Job job = new Job(PatientId, FirstName, LastName, PhoneNo, Gender, Age, Address, AadharNo, Speciality);

                        jobArray[i] = job;

                    }

                    break;

                case 2:

                    for (int j = 0; j < jobArray.Length; j++)

                    {

                        jobArray[j].printInfo();

                    }

                    break;

                case 3:

                    Console.Write("Enter position to delete item : ");

                    pos = int.Parse(Console.ReadLine());

                    jobArray = jobArray.Where(e => e.PatientId != pos - 1).ToArray();

                    Console.WriteLine("Record deleted successfully");

                    break;

                default:

                    Console.WriteLine("Please Choose Valid");

                    break;

            }

            Console.WriteLine("\nPress y or Y to continue; press any other key to exit.");

            cont = Convert.ToChar(Console.ReadLine());

        }

    }

}