using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeoplePro.Models;

namespace PeoplePro.Data
{
    public class PeopleProContext : DbContext
    {
        public PeopleProContext (DbContextOptions<PeopleProContext> options)
            : base(options)
        {
        }

        //TODO: Add Models here
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: Add Tables here
            modelBuilder.Entity<Room>().ToTable("Rooms");
            
            modelBuilder.Entity<Department>().ToTable("Departments");

            modelBuilder.Entity<Role>().ToTable("Roles");

            modelBuilder.Entity<Person>().ToTable("People");

            //TODO: Add relationships here
            //TODO: see https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many

            // Add many to one relationship between Roles and Persons
            modelBuilder.Entity<RolePerson>().HasKey(RolePerson => new { RolePerson.RoleId, RolePerson.PersonId });

            modelBuilder.Entity<RolePerson>()
                .HasOne(RolePerson => RolePerson.Person)
                .WithMany(Person => Person.RolePeople)
                .HasForeignKey(RolePerson => RolePerson.PersonId);

            modelBuilder.Entity<RolePerson>()
                .HasOne(RolePerson => RolePerson.Role)
                .WithMany(Role => Role.RolePeople)
                .HasForeignKey(RolePerson => RolePerson.RoleId);
        }
    }
}
