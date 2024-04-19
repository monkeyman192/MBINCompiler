using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10B77F9EF998131A, NameHash = 0xF8A296780D76172F)]
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
        /* 0x0 */ public int FreighterBattleDistance;
        // size: 0x4
        public enum FreighterBattleStatusEnum : uint {
            None,
            Active,
            Joined,
            Reward,
        }
        /* 0x4 */ public FreighterBattleStatusEnum FreighterBattleStatus;
        /* 0x8 */ public TkEqualityEnum FreighterBattleTest;
        /* 0xC */ public bool HostileFreighter;
    }
}
