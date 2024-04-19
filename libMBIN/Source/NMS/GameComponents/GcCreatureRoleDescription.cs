using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x269FF1F30668EF15, NameHash = 0xA1B4C2EA26DFEA74)]
    public class GcCreatureRoleDescription : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Filter;
        /* 0x20 */ public NMSString0x10 ForceID;
        /* 0x30 */ public NMSString0x10 RequireTag;
        /* 0x40 */ public GcCreatureActiveTime ActiveTime;
        /* 0x44 */ public GcCreatureGenerationDensity Density;
        /* 0x48 */ public GcCreatureTypes ForceType;
        /* 0x4C */ public float IncreasedSpawnDistance;
        /* 0x50 */ public int MaxGroupSize;
        /* 0x54 */ public GcCreatureSizeClasses MaxSize;
        /* 0x58 */ public int MinGroupSize;
        /* 0x5C */ public GcCreatureSizeClasses MinSize;
        /* 0x60 */ public float ProbabilityOfBeingEnabled;
        /* 0x64 */ public GcCreatureRoles Role;
    }
}
