using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Staff
    {
        [Key]
        public Guid Id { get; set; }
        public string StaffTitle { get; set; }
        public string TotalStaff { get; set; }
        public string Permission { get; set; }


    }
}
