using Recipe.Entities.Model.Abstract;

namespace Recipe.Entities.Model.Concrete
{
	public class Role : BaseEntity<int>
	{
		public string RoleName { get; set; }
		public MyUser? User { get; set; }
		public int? UserID { get; set; }
	}
}
