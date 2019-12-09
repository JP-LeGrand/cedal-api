using System.Collections.Generic;
using cedal_backend.Enums;

namespace cedal_backend.Models
{
    public class Education
    {
        public int ID { get; set; }
        public EducationType EducationType { get; set; }
        public string Name { get; set; }
        private IEnumerable<Module> Modules { get; set; }
    }
}
