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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("CB4C6577-3589-47DF-AA66-FFD913FE1CDF"),
                FileName = "Test Image",
                FileType = "jpg",
                CreatedDate = DateTime.Now,
                CreatedBy = "Arda",
                IsActive = true,
            },
            new Image
            {
                Id = Guid.Parse("CD73B844-7E50-45E9-A264-CCAA84E52722"),
                FileName = "Test Image 2",
                FileType = "jpg",
                CreatedDate = DateTime.Now,
                CreatedBy = "Arda",
                IsActive = true,
            });
        }
    }
}
