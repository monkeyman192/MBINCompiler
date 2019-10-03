using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0x461F8EEB2B217E67, NameHash = 0xF8A296780D76172F)]
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
		public enum FreighterBattleStatusEnum { None, Active, Joined, Reward }
		public FreighterBattleStatusEnum FreighterBattleStatus;
        public int FreighterBattleDistance;
        public TkEqualityEnum FreighterBattleTest;
    }
}
