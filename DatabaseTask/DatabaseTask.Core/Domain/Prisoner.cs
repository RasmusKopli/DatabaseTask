using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prisoner
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public int PersonalId { get; set; }
        public string Crime { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime StartofSentence { get; set; }
        public DateTime EndofSentence { get; set; }
    }
}
