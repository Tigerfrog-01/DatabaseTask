
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class ChildGroupHistory
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<Child> Childs { get; set; }
        = new List<Child>();

        public IEnumerable<Groups> Groups { get; set; }
        = new List<Groups>();
    }
}
