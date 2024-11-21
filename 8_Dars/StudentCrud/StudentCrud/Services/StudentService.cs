using StudentCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrud.Services;

public class StudentService
{
    private List<Student> Students;
    public StudentService()
    {
        Students = new List<Student>();
        DataSeed();
    }

    public Student AddStudent(Student student)
    {
        student.Id = Guid.NewGuid();
        Students.Add(student);
        return student;
    }
    
    public bool DeleteStudent(Guid studentId)
    {
        var result = false;
        foreach(var student in Students)
        {
            if (student.Id == studentId)
            {
                Students.Remove(student);
                result = true;
                break;
            }
        }
        return result;
    }

    public bool UpdateStudent(Student student)
    {
        var result = false;
        for(var i = 0; i < Students.Count; i++)
        {
            if(Students[i].Id == student.Id)
            {
                Students[i] = student;
                result = true;
            }
        }
        return result;
    }

    public Student GetById(Guid studentid)
    {
        foreach(var student in Students)
        {
            if (student.Id == studentid)
            {
                return student;
            }
        }
        return null;
    }

    public List<Student> GetAllStudents()
    {
        return Students;
    }

    public void DataSeed()
    {
        Student defStudentOne = new Student()
        {
            Id = Guid.NewGuid(),
            FirstName = "Azizov",
            LastName = "Maqsud",
            BirthDate =DateOnly.Parse( "11 / 24 / 2006"),
            University="TATU",
            PhoneNumber="994442112"
        };
        Students.Add(defStudentOne);
        
        Student defStudentTwo = new Student()
        {
            Id = Guid.NewGuid(),
            FirstName = "Murod",
            LastName = "Maqsudov",
            BirthDate =DateOnly.Parse( "11 / 24 / 2004"),
            University="TATU",
            PhoneNumber="954472212"
        };
        Students.Add(defStudentTwo);
        
        Student defStudentThree = new Student()
        {
            Id = Guid.NewGuid(),
            FirstName = "Asadov",
            LastName = "Malik",
            BirthDate =DateOnly.Parse( "09 / 21 / 2005"),
            University="TATU",
            PhoneNumber="914592612"
        };
        Students.Add(defStudentThree);
    }

}
