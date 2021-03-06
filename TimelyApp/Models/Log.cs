using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimelyApp.Models
{
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogID { get; set; }
        
        [Required]
        public string ProjectName { get; set; }
        [Required]
        
        public DateTime StartTime { get; set; }
        [Required]
      
        public DateTime EndTime{ get; set; }
        
        [Required]
        public int Duration { get; set; }
    }
}
