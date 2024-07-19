using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34EA8B3DFA0F877B, NameHash = 0x539BD611)]
    public class GcMissionConditionCommunityResearchTier : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int CompletedTiers;
        [NMS(Index = 1)]
        /* 0x4 */ public int MissionIndex;
        [NMS(Index = 2)]
        /* 0x8 */ public TkEqualityEnum Test;
        [NMS(Index = 3)]
        /* 0xC */ public bool TakeTierFromSeasonData;
    }
}
