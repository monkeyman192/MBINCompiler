using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x818DB4A533D98EA4, NameHash = 0x978040CE6A2C247B)]
    public class GcMissionConditionWaitForPirates : NMSTemplate
    {
        public int LivingPirates;
        public bool CompleteOnlyInSpace;
        public bool CareAboutAttackingPlayer;
        public bool CheckAllFireteamMembers;
        public TkEqualityEnum Test;
    }
}