using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Block
    {
        [Key]
        public int BlockNumber { get; set; }
        public int Floor { get; set; }
        public int SecurityLevel { get; set; }
    }
}
