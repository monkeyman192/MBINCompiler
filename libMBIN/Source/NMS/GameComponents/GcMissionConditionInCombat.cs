using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xFFCDB89406ED07BD, NameHash = 0x326A8803E3B79519)]
    public class GcMissionConditionInCombat : NMSTemplate
    {
		public enum CombatTypeEnum { GroundCombat, SpaceCombat }
		public CombatTypeEnum CombatType;
    }
}
