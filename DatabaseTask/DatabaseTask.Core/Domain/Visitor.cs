using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Visitor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int VisitorID { get; set; }
        public int PhoneNumber { get; set; }
        public string Relationship { get; set; }
    }
}
