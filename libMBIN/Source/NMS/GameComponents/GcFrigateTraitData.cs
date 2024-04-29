using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B3BB40B64940C88, NameHash = 0x3A526CC4024569BA)]
    public class GcFrigateTraitData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A DisplayName;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ID;
        [NMS(Index = 4, Size = 0x9, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x30 */ public int[] ChanceOfBeingOffered;
        [NMS(Index = 2)]
        /* 0x54 */ public GcFrigateStatType FrigateStatType;
        [NMS(Index = 3)]
        /* 0x58 */ public GcFrigateTraitStrength Strength;
    }
}
