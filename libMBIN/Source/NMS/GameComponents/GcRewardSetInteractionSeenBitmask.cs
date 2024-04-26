using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B865CF254C13DD0, NameHash = 0x719D093BDEC85E0D)]
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
