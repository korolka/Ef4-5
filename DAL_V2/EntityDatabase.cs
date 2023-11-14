using DAL_V2.Entity;
using DAL_V2.Entity.Configuration;
using DAL_V2.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2
{
    internal class EntityDatabase : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<KeyParams> KeyLink { get; set; }

        public EntityDatabase()
        {
            Database.EnsureCreated();   
        }

        public DbSet<TEntity> GetDbSet<TEntity>() where TEntity : BaseEntity
        {
            return Set<TEntity>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestDb2023;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new KeyParamsConfgiuration());

            modelBuilder.SeedDatabase();
        }
    }
}