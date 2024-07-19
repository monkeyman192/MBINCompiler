using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6424F11D0F96DF84, NameHash = 0x1F900465)]
    public class GcRewardOpenUnlockTree : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int PageIndexOverride;
        [NMS(Index = 0)]
        /* 0x4 */ public GcUnlockableItemTreeGroups TreeToOpen;
    }
}
