namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1362D99691CD6846, NameHash = 0x1C9C75E3)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A RewardMessageOverride;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 AttackDefinition;
        [NMS(Index = 7)]
        /* 0x30 */ public VariableSizeString DebugText;
        [NMS(Index = 5)]
        /* 0x40 */ public float DistanceOverride;
        [NMS(Index = 1)]
        /* 0x44 */ public int NumSquads;
        // size: 0x3
        public enum PirateSpawnTypeEnum : uint {
            CargoAttackStart,
            ProbeSuccess,
            PlanetaryRaidStart,
        }
        [NMS(Index = 0)]
        /* 0x48 */ public PirateSpawnTypeEnum PirateSpawnType;
        [NMS(Index = 6)]
        /* 0x4C */ public bool ForceSpawn;
        [NMS(Index = 4)]
        /* 0x4D */ public bool Silent;
    }
}
