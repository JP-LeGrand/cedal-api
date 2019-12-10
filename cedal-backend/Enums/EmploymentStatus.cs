using System.Runtime.Serialization;

namespace cedal_backend.Enums
{
    public enum EmploymentStatus
    {
        [EnumMember(Value = "Employed")]
        Employed = 0,
        [EnumMember(Value = "Retired")]
        Retired = 1,
        [EnumMember(Value = "Unemployed")]
        Unemployed = 2,
        [EnumMember(Value = "Student")]
        Student = 3,
        [EnumMember(Value = "Other")]
        Other = 4,
    }
}
