using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE7AB9E75AB5D4B8, NameHash = 0x6F44BB3A2BA686D8)]
    public class GcRewardOpenUnlockTree : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int PageIndexOverride;
        [NMS(Index = 0)]
        /* 0x4 */ public GcUnlockableItemTreeGroups TreeToOpen;
    }
}
