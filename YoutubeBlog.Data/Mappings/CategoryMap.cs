using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("F83E1176-E3E9-4F1F-93D9-12F1FA75C057"),
                Name = "Test Category",
                CreatedDate = DateTime.Now,
                CreatedBy = "Arda",
                IsActive = true,   
            },
            new Category
            {
                Id = Guid.Parse("12E20C2D-8D09-4501-AFFD-AEFC104FB44C"),
                Name = "Test Category 2",
                CreatedDate = DateTime.Now,
                CreatedBy = "Arda",
                IsActive = true,
            }
            );
        }
    }
}
