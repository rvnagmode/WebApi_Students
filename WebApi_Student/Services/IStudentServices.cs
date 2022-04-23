using WebApi_Student.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Student.Services
{
    public interface IStudentServices
    {
        IEnumerable<Student> GetAllStudent();
        int AddStudent(Student stud);
        int ModifyStudent(Student stud);
        int DeleteStudent(Student stud);
    }
}
