using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5EC7D9B0C68B75FD, NameHash = 0x2FE28DE7841506AF)]
    public class GcBuildingSpawnData : NMSTemplate
    {
        /* 0x000 */ public Vector3f AABBMax;
        /* 0x010 */ public Vector3f AABBMin;
        /* 0x020 */ public GcResourceElement Resource;
        /* 0x2C8 */ public GcSeed Seed;
        [NMS(Size = 0x8)]
        /* 0x2D8 */ public int[] ClusterLayouts;
        /* 0x2F8 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x300 */ public GcBuildingClassification Classification;
        /* 0x304 */ public int ClusterLayoutCount;
        /* 0x308 */ public float ClusterSpacing;
        /* 0x30C */ public float Density;
        /* 0x310 */ public int InstanceID;
        /* 0x314 */ public int LSystemID;
        /* 0x318 */ public float MaxHeight;
        /* 0x31C */ public float MaxXZRotation;
        /* 0x320 */ public float MinHeight;
        /* 0x324 */ public float Radius;
        /* 0x328 */ public float Scale;
        /* 0x32C */ public int WFCBuildingPreset;
        /* 0x330 */ public int WFCModuleSet;
        /* 0x334 */ public bool AlignToNormal;
        /* 0x335 */ public bool AutoCollision;
        /* 0x336 */ public bool BuildingSizeCalculated;
        /* 0x337 */ public bool GivesShelter;
        /* 0x338 */ public bool IgnoreParticlesAABB;
        /* 0x339 */ public bool LowerIntoGround;
    }
}
