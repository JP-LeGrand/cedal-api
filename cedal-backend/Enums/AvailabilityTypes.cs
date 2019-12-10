using System.Runtime.Serialization;

namespace cedal_backend.Enums
{
    public enum AvailabilityTypes
    {
        [EnumMember(Value = "OnetoThreeHoursPerWeek")]
        OnetoThreeHoursPerWeek = 0,
        [EnumMember(Value = "FourtoSixHoursPerWeek")]
        FourtoSixHoursPerWeek = 1,
        [EnumMember(Value = "Sevento10HoursPerWeek")]
        Sevento10HoursPerWeek = 2,
        [EnumMember(Value = "OneToThreeMonths")]
        OneToThreeMonths = 3,
        [EnumMember(Value = "FourToSixMonths")]
        FourToSixMonths = 4,
        [EnumMember(Value = "SixToTwelveMonths")]
        SixToTwelveMonths = 5,
        [EnumMember(Value = "More")]
        More = 6
    }
}
