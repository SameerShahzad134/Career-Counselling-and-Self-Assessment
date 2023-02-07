using Microsoft.EntityFrameworkCore;
using System;

namespace CCASA.Models
{
    public class Class : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Counsellor> Counsellors { get; set; }
		public DbSet<Quiz> Quizzes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add auditing properties to all entities
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entityType.Name).Property<DateTime>("CreatedAt").HasDefaultValueSql("getdate()");
                modelBuilder.Entity(entityType.Name).Property<DateTime>("ModifiedAt").HasDefaultValueSql("getdate()");
            }
        } 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EADdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
	}
}
