using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Absense
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; } = string.Empty;

        public IEnumerable<Groups> Groups { get; set; }
            = new List<Groups>();

        public IEnumerable<Child> Childs { get; set; }
           = new List<Child>();

    }
}
