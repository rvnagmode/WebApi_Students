using WebApi_Student.Model;
using WebApi_Student.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Student.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _iStudentRepo;
        public StudentServices(IStudentRepository iStudentRepo)
        {
            _iStudentRepo = iStudentRepo;
        }

        public int AddStudent(Student stud)
        {
            throw new NotImplementedException();
        }

        public int DeleteStudent(Student stud)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public int ModifyStudent(Student stud)
        {
            throw new NotImplementedException();
        }
    }
}
