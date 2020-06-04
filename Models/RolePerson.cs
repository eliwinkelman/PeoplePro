using System;
namespace PeoplePro.Models
{
    public class RolePerson
    {

        public Role Role { get; set; }
        public int RoleId { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }

    }
}
