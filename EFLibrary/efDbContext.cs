using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.Reflection;
using EFLibrary.Entity;

namespace EFLibrary
{
   public class EfDbContext : DbContext
    {
        public EfDbContext() : base("name=ConnectionString")
        { 
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                  .Where(type => !string.IsNullOrEmpty(type.Namespace))
                  .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach(var type in typesToRegister)
            {
                dynamic configyrationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configyrationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
