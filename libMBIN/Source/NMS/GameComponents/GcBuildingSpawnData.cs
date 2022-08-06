using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BCB17635C12646D, NameHash = 0x2FE28DE7841506AF)]
    public class GcBuildingSpawnData : NMSTemplate
    {
        /* 0x000 */ public float Density;
        /* 0x008 */ public GcResourceElement Resource;
        /* 0x2B0 */ public int LSystemID;
        /* 0x2B4 */ public int WFCModuleSet;
        /* 0x2B8 */ public int WFCBuildingPreset;
        /* 0x2BC */ public bool AutoCollision;
        /* 0x2C0 */ public GcSeed Seed;
        /* 0x2D0 */ public GcBuildingClassification Classification;
        [NMS(Size = 0x8)]
        /* 0x2D4 */ public int[] ClusterLayouts;
        /* 0x2F4 */ public int ClusterLayoutCount;
        /* 0x2F8 */ public float ClusterSpacing;
        /* 0x2FC */ public TkNoiseFlattenOptions FlattenType;
        /* 0x304 */ public bool GivesShelter;
        /* 0x305 */ public bool AlignToNormal;
        /* 0x306 */ public bool LowerIntoGround;
        /* 0x308 */ public float Scale;
        /* 0x30C */ public float MaxXZRotation;
        /* 0x310 */ public float Radius;
        /* 0x314 */ public float MinHeight;
        /* 0x318 */ public float MaxHeight;
        /* 0x31C */ public int InstanceID;
        /* 0x320 */ public Vector3f AABBMin;
        /* 0x330 */ public Vector3f AABBMax;
        /* 0x340 */ public bool BuildingSizeCalculated;
    }
}
