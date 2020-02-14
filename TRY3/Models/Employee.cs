using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TRY3.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class EmpDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}