using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Guard
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeNumber { get; set; }
        public string JobPosition { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

