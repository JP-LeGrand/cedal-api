using System.Runtime.Serialization;

namespace cedal_backend.Enums
{
    public enum EducationType
    {
        [EnumMember(Value = "PrimarySchool")]
        PrimarySchool = 0,
        [EnumMember(Value = "HighSchool")]
        HighSchool = 1
    }
}
