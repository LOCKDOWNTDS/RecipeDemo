using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Entities.EntityConfig.Abstract;
using Recipe.Entities.Model.Concrete;

namespace Recipe.Entities.EntityConfig.Concrete
{
	public class RoleConfig : BaseConfig<Role, int>
	{
		public override void Configure(EntityTypeBuilder<Role> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.RoleName).HasMaxLength(50);
			builder.HasOne(p => p.User).WithMany(p => p.Roles).HasForeignKey(x => x.UserID);

			builder.HasData(
			new Role
			{
				ID = 1,
				RoleName = "Admin",
				UserID = 1
			},
			new Role
			{
				ID = 2,
				RoleName = "User",

			}
			);

		}
	}
}
