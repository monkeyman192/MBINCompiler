using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34090D00DBE99FD3, NameHash = 0xF04051C4)]
    public class GcRewardFishRelease : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcItemQuality Rarity;
    }
}
