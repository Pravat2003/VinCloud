using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.Enitities.Request
{
    public class TeacherRequest
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Expreance { get; set; }
    }
}
