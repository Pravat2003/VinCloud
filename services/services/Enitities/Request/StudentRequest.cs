using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.Enitities.Request
{
    public class StudentRequest
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string StudyIn { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
