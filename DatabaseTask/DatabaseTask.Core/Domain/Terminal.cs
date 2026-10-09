using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Terminal
    {
        [Key]
        public Guid TerminalID { get; set; }
        public int TerminalNumber { get; set; }
        public string TerminalName { get; set; }
        public string TerminalLocation { get; set; }
    }
}
