using System;
using System.Collections.Generic;

namespace PeoplePro.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<RolePerson> RolePeople { get; set; }
    }
}
