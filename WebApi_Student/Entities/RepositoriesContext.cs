using Microsoft.EntityFrameworkCore;
using WebApi_Student.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Student.Entities
{
    public class RepositoriesContext : DbContext

    {
        public RepositoriesContext(DbContextOptions options): base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
