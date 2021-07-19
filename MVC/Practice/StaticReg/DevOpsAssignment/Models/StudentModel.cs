using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsAssignment.Models
{
    public class StudentModel
    {
        
        public int StudnetId { get; set; }
        [Required]
        public String StudentRoll { get; set; }
        [Required]
        public String StudentName { get; set; }
        [Required]
        public String StudentEmail { get; set; }
        [Required]
        public String StudentCourse { get; set; }
        [Required]
        public String StudentBatch { get; set; }



    }
}
