using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PrisonSentence
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TypeOfPunishment { get; set; }
    }
}
