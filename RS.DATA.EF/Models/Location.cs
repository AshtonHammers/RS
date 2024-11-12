using System;
using System.Collections.Generic;

namespace RS.DATA.EF.Models
{
    public partial class Location
    {
        public Location()
        {
            Employees = new HashSet<Employee>();
            Reservations = new HashSet<Reservation>();
        }

        public int LocationId { get; set; }
        public string LocationAddress { get; set; } = null!;
        public string LocationCity { get; set; } = null!;
        public string? LocationState { get; set; }
        public string? LocationPostalCode { get; set; }
        public string LocationName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
