using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF84F9A89A3E60988, NameHash = 0x8603D7E)]
    public class GcPassiveFrigateIncomeArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public GcPassiveFrigateIncome[] Array;
    }
}
