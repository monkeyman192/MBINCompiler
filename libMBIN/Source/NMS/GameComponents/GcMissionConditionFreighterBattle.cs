using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x461F8EEB2B217E67, NameHash = 0xF8A296780D76172F)]
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
		public enum FreighterBattleStatusEnum { None, Active, Joined, Reward }
		/* 0x0 */ public FreighterBattleStatusEnum FreighterBattleStatus;
        /* 0x4 */ public int FreighterBattleDistance;
        /* 0x8 */ public TkEqualityEnum FreighterBattleTest;
    }
}
