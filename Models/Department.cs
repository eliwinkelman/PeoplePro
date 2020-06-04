using System;
using System.Collections.Generic;

namespace PeoplePro.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Room Room { get; set; }
        public int RoomId { get; set; }

        public List<Person> People { get; set; }
    }
}
