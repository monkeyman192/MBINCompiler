using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32E0C11444F49A6D, NameHash = 0xF12C873B2656248)]
    public class GcFrigateTraitStrengthByType : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x0 */ public GcFrigateTraitStrengthValues[] FrigateStatType;
    }
}
