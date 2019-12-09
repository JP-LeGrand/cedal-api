using System.Runtime.Serialization;

namespace cedal_backend.Enums
{
    public enum UserTypes
    {
        [EnumMember(Value = "UNKNOWN")]
        Unknown = 0,
        [EnumMember(Value = "ADMIN")]
        Administrator = 1,
        [EnumMember(Value = "APPLICANT")]
        Applicant = 2

    }
}
