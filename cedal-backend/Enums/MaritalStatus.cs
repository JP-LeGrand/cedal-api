using System.Runtime.Serialization;

namespace cedal_backend.Enums
{
    public enum MaritalStatus
    {
        [EnumMember(Value = "Single")]
        Single = 0,
        [EnumMember(Value = "Married")]
        Married = 1,
        [EnumMember(Value = "Divorced")]
        Divorced = 2,
        [EnumMember(Value = "Other")]
        Other = 3
    }
}
