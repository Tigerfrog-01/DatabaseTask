using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Menu
    {
        [Key]
        public Guid Id { get; set; }
        public string Morning { get; set; } = string.Empty;
        public string Lunch { get; set; } = string.Empty;
        public string Dinner { get; set; } = string.Empty;
        public string MainMeal { get; set; }
        public string SideSnack { get; set; } = string.Empty;
        public string Bevarage { get; set; }
        public string Dessert { get; set; } = string.Empty;
        public string Date { get; set; }




    }
}
