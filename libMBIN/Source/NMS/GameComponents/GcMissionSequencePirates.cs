namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x963C57C932801C9, NameHash = 0x9166CF1D0ED63522)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A RewardMessageOverride;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 AttackDefinition;
        [NMS(Index = 5)]
        /* 0x30 */ public float DistanceOverride;
        [NMS(Index = 1)]
        /* 0x34 */ public int NumSquads;
        // size: 0x3
        public enum PirateSpawnTypeEnum : uint {
            CargoAttackStart,
            ProbeSuccess,
            PlanetaryRaidStart,
        }
        [NMS(Index = 0)]
        /* 0x38 */ public PirateSpawnTypeEnum PirateSpawnType;
        [NMS(Index = 7)]
        /* 0x3C */ public NMSString0x80 DebugText;
        [NMS(Index = 6)]
        /* 0xBC */ public bool ForceSpawn;
        [NMS(Index = 4)]
        /* 0xBD */ public bool Silent;
    }
}
