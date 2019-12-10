using System.Runtime.Serialization;

namespace cedal_backend.Enums
{
    public enum LanguageType
    {
        [EnumMember(Value = "English")]
        English = 0,
        [EnumMember(Value = "Afrikaans")]
        Afrikaans = 1,
        [EnumMember(Value = "Zulu")]
        Zulu = 2,
        [EnumMember(Value = "Xhosa")]
        Xhosa = 3,
        [EnumMember(Value = "Sotho")]
        Sotho = 4,
        [EnumMember(Value = "Tswana")]
        Tswana = 5,
        [EnumMember(Value = "Venda")]
        Venda = 6,
        [EnumMember(Value = "Tsonga")]
        Tsonga = 7,
        [EnumMember(Value = "Swati")]
        Swati = 8,
        [EnumMember(Value = "Ndebele")]
        Ndebele = 9
    }
}
