using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE854B3C05EE566D5, NameHash = 0xA5870231)]
    public class GcRewardSetInteractionSeenBitmask : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 Stat;
        [NMS(Index = 0)]
        /* 0x10 */ public GcInteractionType InteractionType;
        [NMS(Index = 1)]
        /* 0x14 */ public int OverrideIndex;
    }
}
