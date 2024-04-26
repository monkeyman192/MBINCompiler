namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0F219BEB67110DE, NameHash = 0xF2F929BD28DDCD6B)]
    public class GcMissionSequenceKill : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public int AmountMax;
        [NMS(Index = 2)]
        /* 0x004 */ public int AmountMin;
        // size: 0xE
        public enum KillTargetEnum : uint {
            Robots,
            Drones,
            Quads,
            Walkers,
            Predators,
            Creatures,
            Pirates,
            Traders,
            Fiends,
            HazardousFlora,
            Worms,
            CorruptSentinels,
            CorruptPillars,
            Mechs,
        }
        [NMS(Index = 1)]
        /* 0x008 */ public KillTargetEnum KillTarget;
        [NMS(Index = 6)]
        /* 0x00C */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x08C */ public NMSString0x80 Message;
        [NMS(Index = 5)]
        /* 0x10C */ public bool AddToMissionBoardObjective;
        [NMS(Index = 4)]
        /* 0x10D */ public bool UseDefaultAmount;
    }
}
