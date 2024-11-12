using System;
using System.Collections.Generic;

namespace RS.DATA.EF.Models
{
    public partial class Client
    {
        public Client()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; } = null!;
        public string? ClientPhone { get; set; }
        public string ClientEmail { get; set; } = null!;
        public string? IdentityId { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
