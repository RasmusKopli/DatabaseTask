using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Crime
    {
        [Key]
        public string CrimeName { get; set; }
        public string Description { get; set; }
        public string CrimeSeverity { get; set; }
    }
}
