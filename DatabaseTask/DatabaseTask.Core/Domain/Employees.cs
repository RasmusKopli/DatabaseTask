using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Employees
    {
        [Key]
        public Guid EmployeeID { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string JobPosition { get; set; }

        public Guid? TerminalID { get; set; }

        [ForeignKey(nameof(TerminalID))]
        public Terminal? Terminal { get; set; }

        public Guid AirportID { get; set; }

        [ForeignKey(nameof(AirportID))]
        public Airport? Airport { get; set; }
    }
}
