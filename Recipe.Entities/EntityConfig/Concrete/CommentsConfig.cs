using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Entities.EntityConfig.Abstract;
using Recipe.Entities.Model.Concrete;

namespace Recipe.Entities.EntityConfig.Concrete
{
    public class CommentsConfig : BaseConfig<Comments, int>
    {
        public override void Configure(EntityTypeBuilder<Comments> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.CommentText).HasMaxLength(500);
            builder.Property(p => p.CommentTitle).HasMaxLength(100);
            builder.HasOne(p => p.Food).WithMany(p => p.Comments).HasForeignKey(p => p.FoodId);
            builder.Property(p => p.Stars).HasDefaultValue(0);
            builder.HasCheckConstraint("Stars", "[Stars]>=0 AND [Stars]<=5");
        }
    }
}
