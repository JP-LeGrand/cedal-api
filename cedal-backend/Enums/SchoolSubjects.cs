using System.Runtime.Serialization;

namespace cedal_backend.Enums
{
    public enum SchoolSubjects
    {
        [EnumMember(Value = "Administrative / Office Work")]
        AdministrativeOfficeWork = 0,
        [EnumMember(Value = "Answering and making phone calls")]
        AnsweringMakingPhoneCalls = 1,
        [EnumMember(Value = "Physical Science")]
        PhysicalScience = 2,
        [EnumMember(Value = "Pure Mathematics")]
        PureMathematics = 3,
        [EnumMember(Value = "Geography")]
        Geography = 4,
        [EnumMember(Value = "Accounting")]
        Accounting = 5,
        [EnumMember(Value = "Business Studies")]
        BusinessStudies = 6,
        [EnumMember(Value = "Economics")]
        Economics = 7,
        [EnumMember(Value = "History")]
        History = 8,
        [EnumMember(Value = "Life Sciences")]
        LifeSciences = 8,
        [EnumMember(Value = "Information Technology")]
        InformationTechnology = 9,
        [EnumMember(Value = "English")]
        English = 10,
        [EnumMember(Value = "Afrikaans")]
        Afrikaans = 11,
        [EnumMember(Value = "Zulu")]
        Zulu = 12,
        [EnumMember(Value = "Xhosa")]
        Xhosa = 13,
        [EnumMember(Value = "Sotho")]
        Sotho = 14,
        [EnumMember(Value = "Tswana")]
        Tswana = 15,
        [EnumMember(Value = "Venda")]
        Venda = 16,
        [EnumMember(Value = "Tsonga")]
        Tsonga = 17,
        [EnumMember(Value = "Swati")]
        Swati = 18,
        [EnumMember(Value = "Ndebele")]
        Ndebele = 19,
        [EnumMember(Value = "Other")]
        Other = 19
    }
}
