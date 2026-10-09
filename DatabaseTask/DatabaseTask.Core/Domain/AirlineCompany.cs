using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class AirlineCompany
    {
        [Key]
        public Guid AirlineID { get; set; }
        public string Name { get; set; }

        public string Country { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
