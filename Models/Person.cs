using System;
using System.Collections.Generic;

namespace PeoplePro.Models
{
    public class Person
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }

        public List<RolePerson> RolePeople { get; set; }
    }
}
