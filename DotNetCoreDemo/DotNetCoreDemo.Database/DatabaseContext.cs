using DotNetCoreDemo.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Reflection.Metadata;

namespace DotNetCoreDemo.Database
{
	public class DatabaseContext : DbContext
	{
		public DbSet<UserModel> User { get; set; }

		public DatabaseContext(DbContextOptions<DatabaseContext> options)
		{

		}

		public DatabaseContext()
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
				//=> optionsBuilder.UseSqlite("Data Source = Test.db");
		         => optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserModel>().HasData(
				new UserModel
				{
					Id = 1,
					Username = "Admin",
					Password = "Admin"
				}
				);
		}

	}
}
