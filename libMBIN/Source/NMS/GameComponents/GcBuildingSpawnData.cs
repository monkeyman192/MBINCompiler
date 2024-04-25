using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5EC7D9B0C68B75FD, NameHash = 0x2FE28DE7841506AF)]
    public class GcBuildingSpawnData : NMSTemplate
    {
        [NMS(Index = 22)]
        /* 0x000 */ public Vector3f AABBMax;
        [NMS(Index = 21)]
        /* 0x010 */ public Vector3f AABBMin;
        [NMS(Index = 1)]
        /* 0x020 */ public GcResourceElement Resource;
        [NMS(Index = 6)]
        /* 0x2C8 */ public GcSeed Seed;
        [NMS(Index = 8, Size = 0x8)]
        /* 0x2D8 */ public int[] ClusterLayouts;
        [NMS(Index = 11)]
        /* 0x2F8 */ public TkNoiseFlattenOptions FlattenType;
        [NMS(Index = 7)]
        /* 0x300 */ public GcBuildingClassification Classification;
        [NMS(Index = 9)]
        /* 0x304 */ public int ClusterLayoutCount;
        [NMS(Index = 10)]
        /* 0x308 */ public float ClusterSpacing;
        [NMS(Index = 0)]
        /* 0x30C */ public float Density;
        [NMS(Index = 20)]
        /* 0x310 */ public int InstanceID;
        [NMS(Index = 2)]
        /* 0x314 */ public int LSystemID;
        [NMS(Index = 19)]
        /* 0x318 */ public float MaxHeight;
        [NMS(Index = 16)]
        /* 0x31C */ public float MaxXZRotation;
        [NMS(Index = 18)]
        /* 0x320 */ public float MinHeight;
        [NMS(Index = 17)]
        /* 0x324 */ public float Radius;
        [NMS(Index = 15)]
        /* 0x328 */ public float Scale;
        [NMS(Index = 4)]
        /* 0x32C */ public int WFCBuildingPreset;
        [NMS(Index = 3)]
        /* 0x330 */ public int WFCModuleSet;
        [NMS(Index = 13)]
        /* 0x334 */ public bool AlignToNormal;
        [NMS(Index = 5)]
        /* 0x335 */ public bool AutoCollision;
        [NMS(Index = 23)]
        /* 0x336 */ public bool BuildingSizeCalculated;
        [NMS(Index = 12)]
        /* 0x337 */ public bool GivesShelter;
        [NMS(Index = 24)]
        /* 0x338 */ public bool IgnoreParticlesAABB;
        [NMS(Index = 14)]
        /* 0x339 */ public bool LowerIntoGround;
    }
}
