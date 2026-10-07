using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Bookable
    {
        [Key]
        public Guid Id { get; set; }
        public string ExtraInfo { get; set; }
        public string Status { get; set; }

    }
}
