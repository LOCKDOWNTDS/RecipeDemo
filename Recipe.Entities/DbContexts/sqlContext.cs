using Microsoft.EntityFrameworkCore;
using Recipe.Entities.Model.Concrete;
using System.Reflection;

namespace Recipe.Entities.DbContexts
{
	public class sqlContext : DbContext
	{

		public DbSet<Food> Foods { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comments> Comments { get; set; }
		public DbSet<CategoryFood> CategoryFoods { get; set; }
		public DbSet<Photos> Photos { get; set; }
		public DbSet<MyUser> Myusers { get; set; }
		public DbSet<Info> Infos { get; set; }
		public DbSet<Role> Roles { get; set; }
		public sqlContext()
		{

		}
		public sqlContext(DbContextOptions<sqlContext> options) : base(options)
		{

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Recipe;Trusted_Connection=True;TrustServerCertificate=True").EnableSensitiveDataLogging();
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
