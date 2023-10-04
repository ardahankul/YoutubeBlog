using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    //IEntityTypeConfiguration'dan inherit aldığında AppDbContext içinde ApplyConfigurationsFromAssembly
    //bu class'daki configure methodunu çağırır. Bu işlem migration yapıldığında gerçekleşir... 
    public class ArticleMap : IEntityTypeConfiguration<Article>     
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            //builder.Property(x => x.Title).HasMaxLength(150);    
            builder.HasData(new Article
            {
                Id =  Guid.NewGuid(),
                Title = "Test Title",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\n",
                ViewCount = 15,
                CategoryId = Guid.Parse("F83E1176-E3E9-4F1F-93D9-12F1FA75C057"),
                ImageId = Guid.Parse("CB4C6577-3589-47DF-AA66-FFD913FE1CDF"),
                CreatedBy = "Arda",
                CreatedDate = DateTime.Now,
                IsActive= true,

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Test Title 2",
                Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n",
                ViewCount = 0,
                CategoryId = Guid.Parse("12E20C2D-8D09-4501-AFFD-AEFC104FB44C"),
                ImageId = Guid.Parse("CD73B844-7E50-45E9-A264-CCAA84E52722"),
                CreatedBy = "Arda",
                CreatedDate = DateTime.Now,
                IsActive = true,

            }

            );
        }
    }
}
