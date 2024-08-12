using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Entities.EntityConfig.Abstract;
using Recipe.Entities.Model.Concrete;

namespace Recipe.Entities.EntityConfig.Concrete
{
	public class MyUserConfig : BaseConfig<MyUser, int>
	{
		public override void Configure(EntityTypeBuilder<MyUser> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
			builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
			builder.Property(x => x.NickName).HasMaxLength(50).IsRequired();
			builder.Property(x => x.Password).HasMaxLength(50).IsRequired();
			builder.Property(x => x.Mail).HasMaxLength(100);
			builder.Property(x => x.PasswordConfirm).HasMaxLength(50).IsRequired();
			builder.HasData(
				new MyUser
				{
					ID = 1,
					Name = "Serdar",
					LastName = "Akdemir",
					NickName = "LOCKDOWN",
					Password = "Serdar123456",
					PasswordConfirm = "Serdar123456",
					Mail = "SerdarAkdemir@gmail.com"

				}


				);
		}
	}
}
