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
        public string Name { get; set; }
        public string TotalChildren { get; set; }
        public string GroupType { get; set; }
        public string RoomNr { get; set; }





    }
}
