using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Gate
    {
        [Key]
        public Guid GateID { get; set; }
        public int GateNumber { get; set; }
        public string GateLocation { get; set; }

        public Guid TerminalID { get; set; }

        [ForeignKey(nameof(TerminalID))]
        public Terminal? Terminal { get; set; }
    }
}
