using System.Runtime.Serialization;

namespace cedal_backend.Enums
{
    public enum TimePreferences
    {
        [EnumMember(Value = "Morning")]
        Morning = 0,
        [EnumMember(Value = "Afternoon")]
        Afternoon = 1,
        [EnumMember(Value = "Evening")]
        Evening = 2,
        [EnumMember(Value = "Other")]
        Other = 3

    }
}
