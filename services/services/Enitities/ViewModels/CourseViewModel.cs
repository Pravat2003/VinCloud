using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.Enitities
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
    }
}
