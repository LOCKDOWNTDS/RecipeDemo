﻿using Recipe.Entities.Model.Abstract;

namespace Recipe.Entities.Model.Concrete
{
    public class MyUser : BaseEntity<int>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Mail { get; set; }
        public int? PhotoId { get; set; }
        public Photos? UserPhoto { get; set; }
        public List<Role>? Roles { get; set; }
        public bool Active { get; set; } = true;

    }

}
