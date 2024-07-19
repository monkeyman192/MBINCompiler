using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BA96FBCE77A37E0, NameHash = 0x2333DE53)]
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
