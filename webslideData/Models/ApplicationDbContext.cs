using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace webslideData.Models
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Tutorial> Tutorials { get; set; }
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Tutorial>().ToTable("Tutorials");
            
        }
    }
}
