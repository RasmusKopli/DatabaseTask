using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Airport
    {
        [Key]
        public Guid AirportID { get; set; }

        public int FlightNumber { get; set; }

        public ICollection<Airplane> Airplanes { get; set; }
            = new List<Airplane>();

        public DateOnly DepartureDate { get; set; }
        public TimeOnly DepartureTime { get; set; }
        public DateOnly ArrivalDate { get; set; }
        public TimeOnly ArrivalTime { get; set; }
        public string DepartureAirport { get; set; }
        public string DestinationAirport { get; set; }
        public string Location { get; set; }

        public Guid TerminalID { get; set; }

        [ForeignKey(nameof(TerminalID))]
        public Terminal? Terminal { get; set; }
    }
}
