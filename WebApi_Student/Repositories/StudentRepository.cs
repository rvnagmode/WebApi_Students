using WebApi_Student.Entities;
using WebApi_Student.Model;
using WebApi_Student.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Student.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        RepositoriesContext context;
        public StudentRepository(RepositoriesContext context)
        {
            this.context = context;
        }
        public int ModifyStudent(Student stud)
        {
            var student = context.Students.Where(s => s.Id == stud.Id).SingleOrDefault();
            if (student != null)
            {
                student.Name = stud.Name;
                student.Percentage = stud.Percentage;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public int AddStudent(Student stud)
        {
            context.Students.Add(stud);
            context.SaveChanges();
            return 1;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }

        public int DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
