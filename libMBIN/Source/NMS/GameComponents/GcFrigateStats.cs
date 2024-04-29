using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D744519B8A2024C, NameHash = 0x38BD9FF11F2B46AB)]
    public class GcFrigateStats : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 InitialTrait;
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x10 */ public GcFrigateStatRange[] Stats;
    }
}
