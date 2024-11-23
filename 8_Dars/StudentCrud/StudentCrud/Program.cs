using StudentCrud.Models;
using StudentCrud.Services;

namespace StudentCrud;

internal class Program
{
    static void Main(string[] args)
    {
        var student1 = new Student();
        FrontEnd();
    }
    public static void FrontEnd()
    {
        var studentService = new StudentService();

        while (true)
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Delete Student");
            Console.WriteLine("3.Update Student");
            Console.WriteLine("4.Get Student By Id");
            Console.WriteLine("5.Get All Students");
            Console.Write("Choose : ");
            var choosed = Console.ReadLine();


            if (choosed == "1")
            {
                var student = new Student();
                Console.Write("Enter Student FirstName : ");
                student.FirstName = Console.ReadLine();
                Console.Write("Enter Student LastName : ");
                student.LastName = Console.ReadLine();
                Console.Write("Enter Student BirthDate : ");
                student.BirthDate = DateOnly.Parse(Console.ReadLine());
                Console.Write("Enter Student University : ");
                student.University = Console.ReadLine();
                Console.Write("Enter Student PhoneNumber : ");
                student.PhoneNumber = Console.ReadLine();

                studentService.AddStudent(student);
            }

            else if (choosed == "2")
            {
                Console.Write("Enter Deleted Student Id : ");
                var id = Guid.Parse(Console.ReadLine());
                var res = studentService.DeleteStudent(id);
                if(res is true)
                {
                    Console.WriteLine("Succesfuly Deleted!");
                }
                else
                {
                    Console.WriteLine("Eror");
                }
            }

            else if (choosed == "3")
            {
                var student = new Student();

                Console.Write("Enter Id To Update:");
                student.Id = Guid.Parse(Console.ReadLine());
                Console.Write("Enter Student FirstName : ");
                student.FirstName = Console.ReadLine();
                Console.Write("Enter Student LastName : ");
                student.LastName = Console.ReadLine();
                Console.Write("Enter Student BirthDate : ");
                student.BirthDate = DateOnly.Parse(Console.ReadLine());
                Console.Write("Enter Student University : ");
                student.University = Console.ReadLine();
                Console.Write("Enter Student PhoneNumber : ");
                student.PhoneNumber = Console.ReadLine();

                studentService.UpdateStudent(student);
            }
            else if (choosed == "4")
            {
                Console.Write("Enter Id : ");
                var id = Guid.Parse(Console.ReadLine());
                var student = studentService.GetById(id);
                if(student is not null)
                {
                    var studentInfo = $"FirstName : {student.FirstName}\nLastName : {student.LastName}\nBirthDate : {student.BirthDate}\n" +
                    $"Univerity : {student.University}\nPhoneNumber : {student.PhoneNumber}\n";
                    Console.WriteLine(studentInfo);
                }
                else
                {
                    Console.WriteLine("Wrong Id");
                }
                
            }
            else if (choosed == "5")
            {
                var students = studentService.GetAllStudents();
                foreach (var student in students)
                {
                    var info=$"StudentId : {student.Id}\nFirstName : {student.FirstName}\nLastName : {student.LastName}\nBirthDate : {student.BirthDate}\n" +
                    $"Univerity : {student.University}\nPhoneNumber : {student.PhoneNumber}\n";
                    Console.WriteLine(info);
                }

            }

            Console.ReadKey();
            Console.Clear();

        }
    }
}
