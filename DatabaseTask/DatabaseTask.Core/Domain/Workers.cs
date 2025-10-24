﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Workers
    {
        [Key]
        public Guid Id { get; set; }
        public string TotalWorkers { get; set; }
        public string Permission { get; set; }


    }
}
