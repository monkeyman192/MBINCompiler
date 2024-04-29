using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x590CEF821149BD94, NameHash = 0xF8A296780D76172F)]
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int FreighterBattleDistance;
        // size: 0x4
        public enum FreighterBattleStatusEnum : uint {
            None,
            Active,
            Joined,
            Reward,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public FreighterBattleStatusEnum FreighterBattleStatus;
        [NMS(Index = 3)]
        /* 0x8 */ public TkEqualityEnum FreighterBattleTest;
        [NMS(Index = 2)]
        /* 0xC */ public bool HostileFreighter;
    }
}
