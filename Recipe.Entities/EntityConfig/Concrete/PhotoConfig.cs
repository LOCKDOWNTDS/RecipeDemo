using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Entities.EntityConfig.Abstract;
using Recipe.Entities.Model.Concrete;

namespace Recipe.Entities.EntityConfig.Concrete
{
    public class PhotoConfig : BaseConfig<Photos, int>
    {
        public override void Configure(EntityTypeBuilder<Photos> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.Food).WithMany(p => p.OtherPictures).HasForeignKey(p => p.FoodId);
            builder.HasData(
                new Photos { ID = 1, FoodId = 1, PhotoPath = "~/img/1.1.jpg" },
                new Photos { ID = 2, FoodId = 1, PhotoPath = "~/img/1.2.jpg" },
                new Photos { ID = 3, FoodId = 2, PhotoPath = "~/img/2.1.jpg" },
                new Photos { ID = 4, FoodId = 2, PhotoPath = "~/img/2.2.jpg" },
                new Photos { ID = 5, FoodId = 3, PhotoPath = "~/img/3.1.jpg" },
                new Photos { ID = 6, FoodId = 3, PhotoPath = "~/img/3.2.jpg" },
                new Photos { ID = 7, FoodId = 4, PhotoPath = "~/img/4.1.jpg" },
                new Photos { ID = 8, FoodId = 4, PhotoPath = "~/img/4.2.jpg" },
                new Photos { ID = 9, FoodId = 5, PhotoPath = "~/img/5.1.jpg" },
                new Photos { ID = 10, FoodId = 5, PhotoPath = "~/img/5.2.jpg" },
                new Photos { ID = 11, FoodId = 6, PhotoPath = "~/img/6.1.jpg" },
                new Photos { ID = 12, FoodId = 6, PhotoPath = "~/img/6.2.jpg" },
                new Photos { ID = 13, FoodId = 7, PhotoPath = "~/img/7.1.jpg" },
                new Photos { ID = 14, FoodId = 7, PhotoPath = "~/img/7.2.jpg" },
                new Photos { ID = 15, FoodId = 8, PhotoPath = "~/img/8.1.jpg" },
                new Photos { ID = 16, FoodId = 8, PhotoPath = "~/img/8.2.jpg" },
                new Photos { ID = 17, FoodId = 9, PhotoPath = "~/img/9.1.jpg" },
                new Photos { ID = 18, FoodId = 9, PhotoPath = "~/img/9.2.jpg" },
                new Photos { ID = 19, FoodId = 10, PhotoPath = "~/img/10.1.jpg" },
                new Photos { ID = 20, FoodId = 10, PhotoPath = "~/img/10.2.jpg" },

                new Photos { ID = 21, FoodId = 11, PhotoPath = "~/img/11.1.jpg" },
                new Photos { ID = 22, FoodId = 13, PhotoPath = "~/img/13.1.jpg" },
                new Photos { ID = 23, FoodId = 14, PhotoPath = "~/img/14.1.jpg" }
                );
        }
    }
}
