using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace services.Enitities
{
    [Table("Student")]
    public class Student
    {    
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string StudyIn { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        //public DateTime CreatedDate { get; set; }
    }
}
