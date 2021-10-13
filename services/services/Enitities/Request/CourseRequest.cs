using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.Enitities.Request
{
    public class CourseRequest
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public bool IsActive { get; set; }
        public int TeacherId { get; set; }
    }
}
