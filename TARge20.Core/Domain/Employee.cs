using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalCode { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<AccessPermit> AccessPermits { get; set; }
        public ICollection<Child> Children { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
        public ICollection<HealthCheck> Healthchecks { get; set; }
        public ICollection<Working> Workings { get; set; }
        public ICollection<Lending> Lendings { get; set; }
        public ICollection<Position> Positions { get; set; }
        public ICollection<Sickleave> Sickleaves { get; set; }
    }


    //public enum Gender
    //{
    //    Female, 
    //    Male,
    //    Unknown
    //}

    //public class Children
    //{
    //    [Key]
    //    public Guid Id { get; set; }

    //    public string FirstName { get; set; }
    //}
}
