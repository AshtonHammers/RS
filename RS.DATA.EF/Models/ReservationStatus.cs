using System;
using System.Collections.Generic;

namespace RS.DATA.EF.Models
{
    public partial class ReservationStatus
    {
        public ReservationStatus()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int ReservationStatusId { get; set; }
        public string? ReservationStatusName { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
