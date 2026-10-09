using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Passenger
    {
        [Key]
        public Guid PassengerID { get; set; }

        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int DocumentNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public Guid? TicketID { get; set; }

        [ForeignKey(nameof(TicketID))]
        public Ticket? Ticket { get; set; }

        public int LuggageAmount { get; set; }

        public Guid? LuggageID { get; set; }

        [ForeignKey(nameof(LuggageID))]
        public Luggage? Luggage { get; set; }

        public Guid? AirportID { get; set; }

        [ForeignKey(nameof(AirportID))]
        public Airport? Airport { get; set; }

    }
}
