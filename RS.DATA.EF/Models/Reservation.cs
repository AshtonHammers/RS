using System;
using System.Collections.Generic;

namespace RS.DATA.EF.Models
{
    public partial class Reservation
    {
        public int ReservationId { get; set; }
        public int ClientId { get; set; }
        public int LocationId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateReserved { get; set; }
        public string? Notes { get; set; }
        public int ReservationStatusId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual Location Location { get; set; } = null!;
        public virtual ReservationStatus ReservationStatus { get; set; } = null!;
    }
}
