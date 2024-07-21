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

                new Photos { ID = 21, FoodId = 11, PhotoPath = "~/img/11.1.jpg" },
                new Photos { ID = 88, FoodId = 12, PhotoPath = "~/img/12.1.jpg" },
                new Photos { ID = 22, FoodId = 13, PhotoPath = "~/img/13.1.jpg" },
                new Photos { ID = 23, FoodId = 14, PhotoPath = "~/img/14.1.jpg" },

                new Photos { ID = 24, FoodId = 15, PhotoPath = "~/img/15.1.jpg" },
                new Photos { ID = 25, FoodId = 15, PhotoPath = "~/img/15.2.jpg" },

                new Photos { ID = 26, FoodId = 16, PhotoPath = "~/img/16.1.jpg" },
                new Photos { ID = 27, FoodId = 16, PhotoPath = "~/img/16.2.jpg" },

                new Photos { ID = 28, FoodId = 17, PhotoPath = "~/img/17.1.jpg" },

                new Photos { ID = 29, FoodId = 18, PhotoPath = "~/img/18.1.jpg" },

                new Photos { ID = 30, FoodId = 19, PhotoPath = "~/img/19.1.jpg" },

                new Photos { ID = 31, FoodId = 20, PhotoPath = "~/img/20.1.jpg" },
                new Photos { ID = 32, FoodId = 21, PhotoPath = "~/img/21.1.jpg" },
                new Photos { ID = 33, FoodId = 22, PhotoPath = "~/img/22.1.jpg" },
                new Photos { ID = 34, FoodId = 23, PhotoPath = "~/img/23.1.jpg" },
                new Photos { ID = 35, FoodId = 23, PhotoPath = "~/img/23.2.jpg" },
                new Photos { ID = 36, FoodId = 24, PhotoPath = "~/img/24.1.jpg" },
                new Photos { ID = 37, FoodId = 24, PhotoPath = "~/img/24.2.jpg" },
                new Photos { ID = 38, FoodId = 25, PhotoPath = "~/img/25.1.jpg" },
                new Photos { ID = 39, FoodId = 25, PhotoPath = "~/img/25.2.jpg" },
                new Photos { ID = 40, FoodId = 26, PhotoPath = "~/img/26.1.jpg" },
                new Photos { ID = 41, FoodId = 27, PhotoPath = "~/img/27.1.jpg" },
                new Photos { ID = 42, FoodId = 28, PhotoPath = "~/img/28.1.jpg" },
                new Photos { ID = 43, FoodId = 29, PhotoPath = "~/img/29.1.jpg" },
                new Photos { ID = 44, FoodId = 30, PhotoPath = "~/img/30.1.jpg" },
                new Photos { ID = 45, FoodId = 31, PhotoPath = "~/img/31.1.jpg" },
                new Photos { ID = 46, FoodId = 31, PhotoPath = "~/img/31.2.jpg" },
                new Photos { ID = 47, FoodId = 32, PhotoPath = "~/img/32.1.jpg" },
                new Photos { ID = 48, FoodId = 33, PhotoPath = "~/img/33.1.jpg" },
                new Photos { ID = 49, FoodId = 33, PhotoPath = "~/img/33.2.jpg" },
                new Photos { ID = 50, FoodId = 34, PhotoPath = "~/img/34.1.jpg" },
                new Photos { ID = 51, FoodId = 34, PhotoPath = "~/img/34.2.jpg" },
                new Photos { ID = 52, FoodId = 35, PhotoPath = "~/img/35.1.jpg" },
                new Photos { ID = 53, FoodId = 36, PhotoPath = "~/img/36.1.jpg" },
                new Photos { ID = 54, FoodId = 36, PhotoPath = "~/img/36.2.jpg" },
                new Photos { ID = 55, FoodId = 37, PhotoPath = "~/img/37.1.jpg" },
                new Photos { ID = 56, FoodId = 37, PhotoPath = "~/img/37.2.jpg" },
                new Photos { ID = 57, FoodId = 38, PhotoPath = "~/img/38.1.jpg" },
                new Photos { ID = 58, FoodId = 39, PhotoPath = "~/img/39.1.jpg" },
                new Photos { ID = 59, FoodId = 40, PhotoPath = "~/img/40.1.jpg" },
                new Photos { ID = 60, FoodId = 41, PhotoPath = "~/img/41.1.jpg" },
                new Photos { ID = 61, FoodId = 42, PhotoPath = "~/img/42.1.jpg" },
                new Photos { ID = 62, FoodId = 42, PhotoPath = "~/img/42.2.jpg" },
                new Photos { ID = 63, FoodId = 43, PhotoPath = "~/img/43.1.jpg" },
                new Photos { ID = 64, FoodId = 44, PhotoPath = "~/img/44.1.jpg" },

                new Photos { ID = 65, FoodId = 45, PhotoPath = "~/img/45.1.jpg" },
                new Photos { ID = 66, FoodId = 46, PhotoPath = "~/img/46.1.jpg" },
                new Photos { ID = 67, FoodId = 47, PhotoPath = "~/img/47.1.jpg" },
                new Photos { ID = 68, FoodId = 47, PhotoPath = "~/img/47.2.jpg" },
                new Photos { ID = 69, FoodId = 48, PhotoPath = "~/img/48.1.jpg" },
                new Photos { ID = 70, FoodId = 48, PhotoPath = "~/img/48.2.jpg" },
                new Photos { ID = 71, FoodId = 49, PhotoPath = "~/img/49.1.jpg" },
                new Photos { ID = 72, FoodId = 49, PhotoPath = "~/img/49.2.jpg" },
                new Photos { ID = 73, FoodId = 50, PhotoPath = "~/img/50.1.jpg" },
                new Photos { ID = 74, FoodId = 50, PhotoPath = "~/img/50.2.jpg" },
                new Photos { ID = 75, FoodId = 51, PhotoPath = "~/img/51.1.jpg" },
                new Photos { ID = 76, FoodId = 52, PhotoPath = "~/img/52.1.jpg" },
                new Photos { ID = 77, FoodId = 53, PhotoPath = "~/img/53.1.jpg" },
                new Photos { ID = 78, FoodId = 54, PhotoPath = "~/img/54.1.jpg" },
                new Photos { ID = 79, FoodId = 55, PhotoPath = "~/img/55.1.jpg" },
                new Photos { ID = 80, FoodId = 56, PhotoPath = "~/img/56.1.jpg" },
                new Photos { ID = 81, FoodId = 56, PhotoPath = "~/img/56.2.jpg" },
                new Photos { ID = 82, FoodId = 57, PhotoPath = "~/img/57.1.jpg" },
                new Photos { ID = 83, FoodId = 57, PhotoPath = "~/img/57.2.jpg" },
                new Photos { ID = 84, FoodId = 58, PhotoPath = "~/img/58.1.jpg" },
                new Photos { ID = 86, FoodId = 59, PhotoPath = "~/img/58.1.jpg" },
                new Photos { ID = 87, FoodId = 60, PhotoPath = "~/img/60.1.jpg" }





                );
        }
    }
}
