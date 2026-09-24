using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Chamber
    {
        [Key]
        public int ChamberNumber { get; set; }
        public int Floor { get; set; }
        public int Capacity { get; set; }
    }
}
