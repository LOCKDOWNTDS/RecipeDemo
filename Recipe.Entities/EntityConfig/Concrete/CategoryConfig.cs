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
                new Category { ID = 1, CategoryName = "Bakliyat Yemekleri" },
                new Category { ID = 2, CategoryName = "Çorba Tarifleri" },
                new Category { ID = 3, CategoryName = "Dolma-Sarma Tarifleri" },
                new Category { ID = 4, CategoryName = "Et Yemekleri" },
                new Category { ID = 5, CategoryName = "Hamur İşi Tarifleri" },
                new Category { ID = 6, CategoryName = "Kahvaltılık Tarifleri" },
                new Category { ID = 7, CategoryName = "Makarna Tarifleri" },
                new Category { ID = 8, CategoryName = "Sebze Yemekleri" },
                new Category { ID = 9, CategoryName = "Tatlı Tarifleri" }
            );
        }
    }
}
