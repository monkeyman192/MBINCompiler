namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0F219BEB67110DE, NameHash = 0xF2F929BD28DDCD6B)]
    public class GcMissionSequenceKill : NMSTemplate
    {
        /* 0x000 */ public int AmountMax;
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
        /* 0x008 */ public KillTargetEnum KillTarget;
        /* 0x00C */ public NMSString0x80 DebugText;
        /* 0x08C */ public NMSString0x80 Message;
        /* 0x10C */ public bool AddToMissionBoardObjective;
        /* 0x10D */ public bool UseDefaultAmount;
    }
}
