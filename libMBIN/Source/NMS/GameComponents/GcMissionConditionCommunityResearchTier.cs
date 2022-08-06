using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A12FEDC69FBE966, NameHash = 0x2CFD4438CD6B0BDC)]
    public class GcMissionConditionCommunityResearchTier : NMSTemplate
    {
        /* 0x0 */ public float CompletedTiers;
        /* 0x4 */ public float MissionIndex;
        /* 0x8 */ public TkEqualityEnum Test;
        /* 0xC */ public bool TakeTierFromSeasonData;
    }
}
