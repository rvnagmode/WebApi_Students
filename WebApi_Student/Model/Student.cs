using System;
using WebApi_Student.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Student.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Percentage { get; set; }
    }
}
