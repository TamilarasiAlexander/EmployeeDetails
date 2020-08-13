using Microsoft.EntityFrameworkCore;
using System;

namespace Employee_Details.Models
{

    public class EmployeeDbContext : DbContext
    {

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
        }
        public DbSet<mst_EmpDetails> mst_EmpDetails {get;set;}  
    }
}
