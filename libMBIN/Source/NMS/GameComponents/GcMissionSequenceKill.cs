namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1793881ADDB2142B, NameHash = 0x933013B5)]
    public class GcMissionSequenceKill : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 5)]
        /* 0x24 */ public int AmountMaxNoMP;
        [NMS(Index = 2)]
        /* 0x28 */ public int AmountMin;
        [NMS(Index = 4)]
        /* 0x2C */ public int AmountMinNoMP;
        // size: 0x13
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
            Queens,
            HazardousFlora,
            Worms,
            CorruptSentinels,
            SpiderSentinels,
            SmallSpiderSentinels,
            HostilesWhileInMech,
            CorruptPillars,
            Mechs,
            SpookSquids,
        }
        [NMS(Index = 1)]
        /* 0x30 */ public KillTargetEnum KillTarget;
        [NMS(Index = 7)]
        /* 0x34 */ public int OverrideMissionStageIDForMPProgress;
        [NMS(Index = 9)]
        /* 0x38 */ public bool AddToMissionBoardObjective;
        [NMS(Index = 8)]
        /* 0x39 */ public bool UseDefaultAmount;
        [NMS(Index = 6)]
        /* 0x3A */ public bool WriteProgressToMissionStat;
    }
}
