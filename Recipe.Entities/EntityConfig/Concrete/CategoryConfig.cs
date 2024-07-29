using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Entities.EntityConfig.Abstract;
using Recipe.Entities.Model.Concrete;

namespace Recipe.Entities.EntityConfig.Concrete
{
    public class CategoryConfig : BaseConfig<Category, int>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.CategoryName).HasMaxLength(50);
            builder.HasIndex(p => p.CategoryName).IsUnique();
            builder.HasData(
                new Category { ID = 1, CategoryName = "Bakliyat Yemekleri", CategoryPhotoPath = "~/img/cat1.jpg" },
                new Category { ID = 2, CategoryName = "Çorba Tarifleri", CategoryPhotoPath = "~/img/cat2.jpg" },
                new Category { ID = 3, CategoryName = "Dolma-Sarma Tarifleri", CategoryPhotoPath = "~/img/cat3.jpg" },
                new Category { ID = 4, CategoryName = "Et Yemekleri", CategoryPhotoPath = "~/img/cat4.jpg" },
                new Category { ID = 5, CategoryName = "Hamur İşi Tarifleri", CategoryPhotoPath = "~/img/cat5.jpg" },
                new Category { ID = 6, CategoryName = "Kahvaltılık Tarifleri", CategoryPhotoPath = "~/img/cat6.jpg" },
                new Category { ID = 7, CategoryName = "Makarna Tarifleri", CategoryPhotoPath = "~/img/cat7.jpg" },
                new Category { ID = 8, CategoryName = "Sebze Yemekleri", CategoryPhotoPath = "~/img/cat8.jpg" },
                new Category { ID = 9, CategoryName = "Tatlı Tarifleri", CategoryPhotoPath = "~/img/cat9.jpg" }
            );
        }
    }
}
