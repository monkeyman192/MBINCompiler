using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1D1A58BCDD360C50, NameHash = 0x978040CE6A2C247B)]
    public class GcMissionConditionWaitForPirates : NMSTemplate
    {
        public int LivingPirates;
        public bool CompleteOnlyInSpace;
        public bool CareAboutAttackingPlayer;
        public TkEqualityEnum Test;
    }
}
