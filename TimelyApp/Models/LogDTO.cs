using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimelyApp.Models
{
    public class LogDTO
    {
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string EndTime { get; set; }

        
        public string Duration { get; set; }
    }
}
