using cedal_backend.Enums;
using System.Collections.Generic;

namespace cedal_backend.Models
{
    public class Applicant : User
    {
        public IEnumerable<Education> Education { get; set; }

        public Applicant()
        {
            UserType = UserTypes.Applicant;
        }
    }
}
