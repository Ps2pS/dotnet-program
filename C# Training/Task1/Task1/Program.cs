class Student
{
    public int StudentId;
    public string StudentName;
    public string StudentEmail;
    public string StudentPhone;
    public Student(int studentId, string studentName, string studentEmail, string studentPhone)
    {
        StudentId = studentId;
        StudentName = studentName;
        StudentEmail = studentEmail;
        StudentPhone = studentPhone;
    }
    public void printInfo()
    {
        Console.WriteLine("Student Id    : {0}", StudentId);
        Console.WriteLine("Student Name  : {0}", StudentName);
        Console.WriteLine("Student Email : {0}", StudentEmail);
        Console.WriteLine("Student Phone : {0}", StudentPhone);
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nPlease enter the number of records you want enter : ");
        int record = Convert.ToInt32(Console.ReadLine());
        Student[] students = new Student[record];
        char resume = 'y';
        while (Char.ToLower(resume) == 'y' || resume == 'Y')
        {
            Console.WriteLine("\nChoose an options :\n1: Register for new student                                                                                                                                                                                                                    \n2: View Details of students \n3: Delete student record \n4: Update student record");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    for (int i = 0; i < students.Length; i++)
                    {
                        Console.WriteLine("\nEnter the details of student with id {0}", i);
                        Console.Write("Student Name :");
                        string name = Console.ReadLine();
                        Console.Write("Student email :");
                        string email = Console.ReadLine();
                        Console.Write("Student phone :");
                        string phone = Console.ReadLine();
                        Student student = new Student(i, name, email, phone);
                        students[i] = student;
                    }
                    break;
                case 2:
                    for (int j = 0; j < students.Length; j++)
                    {
                        Console.WriteLine("\nStudent Record:\n ");
                        students[j].printInfo();
                    }
                    break;
                case 3:
                    Console.Write("\nPlease enter student id to delete his data :");
                    int delId = Convert.ToInt32(Console.ReadLine());
                    bool studentExist = students.Any(student => student.StudentId == delId);
                    if (studentExist)
                    {
                        students = students.Where(e => e.StudentId != delId).ToArray();
                        Console.WriteLine("Record deleted successfully \n");
                    }
                    else
                    {
                        Console.WriteLine("No student with id {0} exist", delId);
                    }
                    break;
                case 4:
                    Console.Write("\nEnter id of student :");
                    int inputId = Convert.ToInt32(Console.ReadLine());
                    bool exist = students.Any(student => student.StudentId == inputId);
                    if (exist)
                    {
                        Console.WriteLine("\nChoose an options :\n1: Update name of the student s\n2: Update email of student \n3: Update phone number of student");
                        int optionSelected = Convert.ToInt32(Console.ReadLine());
                        switch (optionSelected)
                        {
                            case 1:
                                Console.Write("Enter new name :");
                                string updateName = Console.ReadLine();
                                students[inputId].StudentName = updateName;
                                Console.WriteLine("Name updated successfully");
                                break;
                            case 2:
                                Console.Write("Enter new email :");
                                string updateEmail = Console.ReadLine();
                                students[inputId].StudentEmail = updateEmail;
                                Console.WriteLine("Email updated successfully");
                                break;
                            case 3:
                                Console.Write("Enter new phone :");
                                string updatePhone = Console.ReadLine();
                                students[inputId].StudentPhone = updatePhone;
                                Console.WriteLine("Phone updated successfully");
                                break;
                            default:
                                Console.WriteLine("Invalid Selection");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No student with id {0} exist", inputId);
                    }
                    break;
                default:
                    Console.WriteLine("Wrong selection !!!!");
                    break;
            }
            Console.WriteLine("\nPress y or Y to continue; press any other key to exit.");
            resume = Convert.ToChar(Console.ReadLine());
        }
    }
}