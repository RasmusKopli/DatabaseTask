using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Luggage
    {
        [Key]
        public Guid LuggageID { get; set; }
        public int LuggageNumber { get; set; }

        public int Weight { get; set; }
        public string LuggageType { get; set; }
    }
}
