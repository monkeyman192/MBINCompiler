using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x155BB986196A3F36, NameHash = 0xC0171D3B)]
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
