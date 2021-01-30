using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x68, GUID = 0xF718F16BC0855BC8, NameHash = 0xA1B4C2EA26DFEA74)]
    public class GcCreatureRoleDescription : NMSTemplate
    {
        /* 0x00 */ public GcCreatureRoles Role;
        /* 0x04 */ public GcCreatureTypes ForceType;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string ForceID;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string RequireTag;
        /* 0x28 */ public GcCreatureSizeClasses MinSize;
        /* 0x2C */ public GcCreatureSizeClasses MaxSize;
        /* 0x30 */ public int MinGroupSize;
        /* 0x34 */ public int MaxGroupSize;
        /* 0x38 */ public GcCreatureGenerationDensity Density;
        /* 0x3C */ public GcCreatureActiveTime ActiveTime;
        /* 0x40 */ public float ProbabilityOfBeingEnabled;
        /* 0x44 */ public float IncreasedSpawnDistance;
        [NMS(Size = 0x20)]
        /* 0x48 */ public string Filter;
    }
}
