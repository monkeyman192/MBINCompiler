using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x902A6A65CDD3131E, NameHash = 0x55D62B6D)]
    public class GcBuildingSpawnData : NMSTemplate
    {
        [NMS(Index = 22)]
        /* 0x00 */ public Vector3f AABBMax;
        [NMS(Index = 21)]
        /* 0x10 */ public Vector3f AABBMin;
        [NMS(Index = 1)]
        /* 0x20 */ public GcResourceElement Resource;
        [NMS(Index = 6)]
        /* 0x68 */ public GcSeed Seed;
        [NMS(Index = 8, Size = 0x8)]
        /* 0x78 */ public int[] ClusterLayouts;
        [NMS(Index = 11)]
        /* 0x98 */ public TkNoiseFlattenOptions FlattenType;
        [NMS(Index = 7)]
        /* 0xA0 */ public GcBuildingClassification Classification;
        [NMS(Index = 9)]
        /* 0xA4 */ public int ClusterLayoutCount;
        [NMS(Index = 10)]
        /* 0xA8 */ public float ClusterSpacing;
        [NMS(Index = 0)]
        /* 0xAC */ public float Density;
        [NMS(Index = 20)]
        /* 0xB0 */ public int InstanceID;
        [NMS(Index = 2)]
        /* 0xB4 */ public int LSystemID;
        [NMS(Index = 19)]
        /* 0xB8 */ public float MaxHeight;
        [NMS(Index = 16)]
        /* 0xBC */ public float MaxXZRotation;
        [NMS(Index = 18)]
        /* 0xC0 */ public float MinHeight;
        [NMS(Index = 17)]
        /* 0xC4 */ public float Radius;
        [NMS(Index = 15)]
        /* 0xC8 */ public float Scale;
        [NMS(Index = 4)]
        /* 0xCC */ public int WFCBuildingPreset;
        [NMS(Index = 3)]
        /* 0xD0 */ public int WFCModuleSet;
        [NMS(Index = 13)]
        /* 0xD4 */ public bool AlignToNormal;
        [NMS(Index = 5)]
        /* 0xD5 */ public bool AutoCollision;
        [NMS(Index = 23)]
        /* 0xD6 */ public bool BuildingSizeCalculated;
        [NMS(Index = 12)]
        /* 0xD7 */ public bool GivesShelter;
        [NMS(Index = 24)]
        /* 0xD8 */ public bool IgnoreParticlesAABB;
        [NMS(Index = 14)]
        /* 0xD9 */ public bool LowerIntoGround;
    }
}
