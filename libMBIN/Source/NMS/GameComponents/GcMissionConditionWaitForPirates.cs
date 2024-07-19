using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE66D12F5AC20608, NameHash = 0xA85B7E2)]
    public class GcMissionConditionWaitForPirates : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int LivingPirates;
        [NMS(Index = 5)]
        /* 0x4 */ public TkEqualityEnum Test;
        [NMS(Index = 3)]
        /* 0x8 */ public bool CareAboutAttackingPlayer;
        [NMS(Index = 4)]
        /* 0x9 */ public bool CheckAllFireteamMembers;
        [NMS(Index = 2)]
        /* 0xA */ public bool CompleteOnlyInSpace;
        [NMS(Index = 1)]
        /* 0xB */ public bool CountHostileTraders;
    }
}
