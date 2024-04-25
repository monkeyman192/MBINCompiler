using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x358310F2D3B8F7E8, NameHash = 0x978040CE6A2C247B)]
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
