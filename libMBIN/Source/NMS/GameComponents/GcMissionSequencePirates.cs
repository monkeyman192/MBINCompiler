namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96958F6D9642716D, NameHash = 0x9166CF1D0ED63522)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A RewardMessageOverride;
        /* 0x20 */ public NMSString0x10 AttackDefinition;
        /* 0x30 */ public float DistanceOverride;
        /* 0x34 */ public int NumSquads;
        // size: 0x3
        public enum PirateSpawnTypeEnum : uint {
            CargoAttackStart,
            ProbeSuccess,
            PlanetaryRaidStart,
        }
        /* 0x38 */ public PirateSpawnTypeEnum PirateSpawnType;
        /* 0x3C */ public NMSString0x80 DebugText;
        /* 0xBC */ public bool ForceSpawn;
        /* 0xBD */ public bool Silent;
    }
}
