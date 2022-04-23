using WebApi_Student.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Student.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        int AddStudent(Student stud);
        int ModifyStudent(Student stud);
        int DeleteStudent(int id);
    }
}
