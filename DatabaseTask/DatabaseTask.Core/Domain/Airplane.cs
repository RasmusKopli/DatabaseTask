using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Airplane
    {
        [Key]
        public Guid AirplaneID { get; set; }
        public string Model { get; set; }

        public int NumberOfSeats { get; set; }
        public DateOnly ManufacturingDate { get; set; }
        public string SpecificFlight { get; set; }


        public Guid AirlineID { get; set; }

        [ForeignKey(nameof(AirlineID))]
        public AirlineCompany? AirlineCompany { get; set; }
    }
}
