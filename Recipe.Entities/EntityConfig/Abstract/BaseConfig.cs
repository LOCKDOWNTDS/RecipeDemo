using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Entities.Model.Abstract;

namespace Recipe.Entities.EntityConfig.Abstract
{
    public class BaseConfig<T, Tid> : IEntityTypeConfiguration<T> where T : BaseEntity<Tid>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasIndex(p => p.ID);
            builder.Property(p => p.CreateTime).HasDefaultValue(DateTime.UtcNow);
        }
    }
}
