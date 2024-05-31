using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x347F554C2047D2F4, NameHash = 0x710A6CDD7B84F22B)]
    public class GcRewardUpgradeShipClass : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcInventoryClass ForceToSpecificClass;
        [NMS(Index = 2)]
        /* 0x4 */ public bool MatchClassToCommunityTier;
        [NMS(Index = 0)]
        /* 0x5 */ public bool Silent;
        [NMS(Index = 3)]
        /* 0x6 */ public bool SilentlyMoveOnAtMaxClass;
    }
}
