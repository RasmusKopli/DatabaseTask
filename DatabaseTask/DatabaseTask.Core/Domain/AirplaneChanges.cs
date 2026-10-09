using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class AirplaneChanges
    {
        [Key]
        public Guid ChangeID { get; set; }

        public Guid AirportID { get; set; }

        [ForeignKey(nameof(AirportID))]
        public Airport? AirlineCompany { get; set; }

        public string FlightStatus { get; set; }
        public DateTime ChangeTime { get; set; }
        public string Reason { get; set; }

    }
}
