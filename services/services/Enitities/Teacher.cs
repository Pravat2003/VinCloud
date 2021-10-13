using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace services.Enitities
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Expreance { get; set; }
        //public Course course { get; set; }
        //public DateTime CreatedDate { get; set; }
    }
}
