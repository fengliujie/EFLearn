using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLibrary.Entity;
namespace EFLibrary.Map
{
   public class BlogMap:EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            ToTable("Blogs");
            HasKey(k => k.Id);
            Property(p => p.Url).IsRequired().HasColumnType("VARCHAR").HasMaxLength(100);
            Property(p => p._Tags).HasColumnName("Tags");
            Property(p => p._Owner).HasColumnName("Owner");

            Ignore(p => p.Owner);
            Ignore(p => p.Tags);

            HasMany(m => m.Posts).WithRequired(r => r.Blog).HasForeignKey(k => k.BlogId).WillCascadeOnDelete(true);
        }
    }
}
