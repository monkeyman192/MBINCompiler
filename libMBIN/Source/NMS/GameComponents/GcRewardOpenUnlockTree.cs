using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D69CE9F54FAB4EC, NameHash = 0x6F44BB3A2BA686D8)]
    public class GcRewardOpenUnlockTree : NMSTemplate
    {
        /* 0x0 */ public int PageIndexOverride;
        /* 0x4 */ public GcUnlockableItemTreeGroups TreeToOpen;
    }
}
