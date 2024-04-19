using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x358310F2D3B8F7E8, NameHash = 0x978040CE6A2C247B)]
    public class GcMissionConditionWaitForPirates : NMSTemplate
    {
        /* 0x0 */ public int LivingPirates;
        /* 0x4 */ public TkEqualityEnum Test;
        /* 0x8 */ public bool CareAboutAttackingPlayer;
        /* 0x9 */ public bool CheckAllFireteamMembers;
        /* 0xA */ public bool CompleteOnlyInSpace;
        /* 0xB */ public bool CountHostileTraders;
    }
}
