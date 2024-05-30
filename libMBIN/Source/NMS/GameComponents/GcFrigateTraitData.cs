using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9420B7E8DDECFC19, NameHash = 0x3A526CC4024569BA)]
    public class GcFrigateTraitData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A DisplayName;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ID;
        [NMS(Index = 4, Size = 0xA, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x30 */ public int[] ChanceOfBeingOffered;
        [NMS(Index = 2)]
        /* 0x58 */ public GcFrigateStatType FrigateStatType;
        [NMS(Index = 3)]
        /* 0x5C */ public GcFrigateTraitStrength Strength;
    }
}
