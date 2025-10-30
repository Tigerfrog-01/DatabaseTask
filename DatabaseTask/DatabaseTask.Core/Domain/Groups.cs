using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Groups
    {
        [Key]
        public Guid Id { get; set; }
        public int ChildCount { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string RoomNr { get; set; } = string.Empty;

 





    }
}
