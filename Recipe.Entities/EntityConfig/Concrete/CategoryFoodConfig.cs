using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Entities.Model.Concrete;

namespace Recipe.Entities.EntityConfig.Concrete
{
    public class CategoryFoodConfig : IEntityTypeConfiguration<CategoryFood>
    {
        public void Configure(EntityTypeBuilder<CategoryFood> builder)
        {

            builder.HasKey(p => new { p.CategoryId, p.FoodId });
            builder.HasOne(p => p.Category).WithMany(p => p.Foods).HasForeignKey(p => p.CategoryId);
            builder.HasOne(p => p.Food).WithMany(p => p.Categorys).HasForeignKey(p => p.FoodId);

            builder.HasData(


                new CategoryFood { FoodId = 11, CategoryId = 1 },
                new CategoryFood { FoodId = 13, CategoryId = 1 },
                new CategoryFood { FoodId = 14, CategoryId = 1 },
                new CategoryFood { FoodId = 15, CategoryId = 1 },
                new CategoryFood { FoodId = 16, CategoryId = 1 },
                new CategoryFood { FoodId = 17, CategoryId = 1 },
                new CategoryFood { FoodId = 18, CategoryId = 1 },
                new CategoryFood { FoodId = 19, CategoryId = 1 },
                new CategoryFood { FoodId = 19, CategoryId = 6 },
                new CategoryFood { FoodId = 19, CategoryId = 8 },
                new CategoryFood { FoodId = 20, CategoryId = 1 },
                new CategoryFood { FoodId = 12, CategoryId = 9 },
                new CategoryFood { FoodId = 44, CategoryId = 9 },
                new CategoryFood { FoodId = 52, CategoryId = 9 },



                new CategoryFood { FoodId = 1, CategoryId = 2 },
                new CategoryFood { FoodId = 2, CategoryId = 2 },
                new CategoryFood { FoodId = 3, CategoryId = 2 },
                new CategoryFood { FoodId = 4, CategoryId = 2 },
                new CategoryFood { FoodId = 5, CategoryId = 2 },
                new CategoryFood { FoodId = 6, CategoryId = 2 },
                new CategoryFood { FoodId = 7, CategoryId = 2 },
                new CategoryFood { FoodId = 8, CategoryId = 2 },
                new CategoryFood { FoodId = 9, CategoryId = 2 },
                new CategoryFood { FoodId = 10, CategoryId = 2 },

                new CategoryFood { FoodId = 21, CategoryId = 3 },
                new CategoryFood { FoodId = 22, CategoryId = 3 },
                new CategoryFood { FoodId = 23, CategoryId = 3 },
                new CategoryFood { FoodId = 24, CategoryId = 3 },
                new CategoryFood { FoodId = 25, CategoryId = 3 },
                new CategoryFood { FoodId = 26, CategoryId = 3 },
                new CategoryFood { FoodId = 27, CategoryId = 3 },
                new CategoryFood { FoodId = 28, CategoryId = 3 },
                new CategoryFood { FoodId = 29, CategoryId = 3 },
                new CategoryFood { FoodId = 30, CategoryId = 3 },

                new CategoryFood { FoodId = 31, CategoryId = 4 },
                new CategoryFood { FoodId = 32, CategoryId = 4 },
                new CategoryFood { FoodId = 33, CategoryId = 4 },
                new CategoryFood { FoodId = 34, CategoryId = 4 },
                new CategoryFood { FoodId = 35, CategoryId = 4 },

                new CategoryFood { FoodId = 36, CategoryId = 5 },
                new CategoryFood { FoodId = 37, CategoryId = 5 },
                new CategoryFood { FoodId = 38, CategoryId = 5 },
                new CategoryFood { FoodId = 39, CategoryId = 5 },
                new CategoryFood { FoodId = 40, CategoryId = 5 },


                new CategoryFood { FoodId = 41, CategoryId = 6 },
                new CategoryFood { FoodId = 42, CategoryId = 6 },
                new CategoryFood { FoodId = 43, CategoryId = 6 },
                new CategoryFood { FoodId = 45, CategoryId = 6 },


                new CategoryFood { FoodId = 46, CategoryId = 7 },
                new CategoryFood { FoodId = 47, CategoryId = 7 },
                new CategoryFood { FoodId = 48, CategoryId = 7 },
                new CategoryFood { FoodId = 49, CategoryId = 7 },
                new CategoryFood { FoodId = 50, CategoryId = 7 },

                new CategoryFood { FoodId = 51, CategoryId = 8 },
                new CategoryFood { FoodId = 53, CategoryId = 8 },
                new CategoryFood { FoodId = 54, CategoryId = 8 },
                new CategoryFood { FoodId = 55, CategoryId = 8 },

                new CategoryFood { FoodId = 56, CategoryId = 9 },
                new CategoryFood { FoodId = 57, CategoryId = 9 },
                new CategoryFood { FoodId = 58, CategoryId = 9 },
                new CategoryFood { FoodId = 59, CategoryId = 9 },
                new CategoryFood { FoodId = 60, CategoryId = 9 }


            );




        }
    }
}
