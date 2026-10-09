using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ticket
    {
        [Key]
        public Guid TicketID { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public string TicketType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int SeatNumber { get; set; }

        public Guid GateID { get; set; }

        [ForeignKey(nameof(GateID))]
        public Gate? Gate { get; set; }

        public Guid? TerminalID { get; set; }

        [ForeignKey(nameof(TerminalID))]
        public Terminal? Terminal { get; set; }
    }
}
