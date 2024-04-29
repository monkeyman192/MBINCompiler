using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4016642E854D9C2, NameHash = 0xF12C873B2656248)]
    public class GcFrigateTraitStrengthByType : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x0 */ public GcFrigateTraitStrengthValues[] FrigateStatType;
    }
}
