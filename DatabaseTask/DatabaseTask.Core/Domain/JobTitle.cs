using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class JobTitle
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

     
    }

}

