using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2AC8CB2672B3B171, NameHash = 0x45DFFC6E8B36F6B7)]
    public class GcPassiveFrigateIncomeArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public GcPassiveFrigateIncome[] Array;
    }
}
