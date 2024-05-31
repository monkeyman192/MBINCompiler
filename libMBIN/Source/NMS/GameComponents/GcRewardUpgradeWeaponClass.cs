namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA00103A8E94C9556, NameHash = 0x8EE3EC0791BD99B7)]
    public class GcRewardUpgradeWeaponClass : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public bool MatchClassToCommunityTier;
        [NMS(Index = 0)]
        /* 0x1 */ public bool Silent;
        [NMS(Index = 2)]
        /* 0x2 */ public bool SilentlyMoveOnAtMaxClass;
    }
}
