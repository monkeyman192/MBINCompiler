using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x269FF1F30668EF15, NameHash = 0xA1B4C2EA26DFEA74)]
    public class GcCreatureRoleDescription : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public NMSString0x20A Filter;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 ForceID;
        [NMS(Index = 3)]
        /* 0x30 */ public NMSString0x10 RequireTag;
        [NMS(Index = 9)]
        /* 0x40 */ public GcCreatureActiveTime ActiveTime;
        [NMS(Index = 8)]
        /* 0x44 */ public GcCreatureGenerationDensity Density;
        [NMS(Index = 1)]
        /* 0x48 */ public GcCreatureTypes ForceType;
        [NMS(Index = 11)]
        /* 0x4C */ public float IncreasedSpawnDistance;
        [NMS(Index = 7)]
        /* 0x50 */ public int MaxGroupSize;
        [NMS(Index = 5)]
        /* 0x54 */ public GcCreatureSizeClasses MaxSize;
        [NMS(Index = 6)]
        /* 0x58 */ public int MinGroupSize;
        [NMS(Index = 4)]
        /* 0x5C */ public GcCreatureSizeClasses MinSize;
        [NMS(Index = 10)]
        /* 0x60 */ public float ProbabilityOfBeingEnabled;
        [NMS(Index = 0)]
        /* 0x64 */ public GcCreatureRoles Role;
    }
}
