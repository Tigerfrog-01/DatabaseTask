using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Menu
    {
        [Key]
        public Guid Id { get; set; }
        public string Morning { get; set; } = string.Empty;
        public string MorningSnack { get; set; } = string.Empty;
        public string Lunch { get; set; } = string.Empty;
        public string DinnerSnack { get; set; } = string.Empty;
        public string Dinner { get; set; } = string.Empty;
        public DateTime DateFood { get; set; }
        public int Portions { get; set; }

        public IEnumerable<Groups> Groups { get; set; }
            = new List<Groups>();




    }
}
