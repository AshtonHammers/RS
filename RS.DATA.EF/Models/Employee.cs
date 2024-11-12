using System;
using System.Collections.Generic;

namespace RS.DATA.EF.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Position { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int LocationId { get; set; }

        public virtual Location Location { get; set; } = null!;
    }
}
