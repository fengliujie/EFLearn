using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLibrary.Entity;
namespace EFLibrary.Map  

{
    public class PostMap:EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            ToTable("Posts");
            HasKey(k => k.Id);
            Property(p => p.Title).IsRequired().HasColumnType("VARCHAR").HasMaxLength(50);
            Property(p => p.Content);
                }
    }
}
