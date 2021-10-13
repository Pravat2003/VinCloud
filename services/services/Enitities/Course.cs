using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace services.Enitities
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public bool IsActive { get; set; }
        public int? TeacherId { get; set; }

        //public DateTime CreatedDate { get; set; }
    }
}
