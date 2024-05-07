using System.Collections.Generic;

namespace ContestProject.Model.EF.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string FullName { get; set; }
        public string Phome { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<Result> Results { get; set; }
    }

}
