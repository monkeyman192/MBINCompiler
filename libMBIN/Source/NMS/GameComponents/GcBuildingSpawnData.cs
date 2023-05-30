using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcBuildingSpawnData : NMSTemplate // 0x5D0 bytes
    {
        /* 0x000 */ public float Density;
        [NMS(Size = 4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;

        /* 0x008 */ public GcResourceElement Resource;
        /* 0x2B0 */ public GcResourceElement UnderwaterResource;
        /* 0x558 */ public int LSystemID;
        /* 0x55C */ public int UnderwaterLSystemID;
        /* 0x560 */ public bool AutoCollision;
        [NMS(Size = 7, Ignore = true)]
        /* 0x561 */ public byte[] Padding561;

        /* 0x568 */ public GcSeed Seed;
        /* 0x578 */ public GcBuildingClassification BuildingClass;
        /* 0x57C */ public GcBuildingClusterPlacement BuildingClusterPlacement;
        /* 0x580 */ public bool AddWaypoint;
        /* 0x581 */ public bool AddShelter;
        /* 0x582 */ public bool AddLandingPad;
        /* 0x583 */ public bool GivesShelter;

        /* 0x584 */ public bool PositioningAlignToNormal;
        /* 0x585 */ public bool PositioningLowerIntoGround;
        /* 0x588 */ public float PositioningScale;
        /* 0x58C */ public float PositioningMaxXZRotation;
        /* 0x590 */ public float PositioningRadius;

        /* 0x594 */ public int InstanceID;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x598 */ public byte[] Padding598;

        /* 0x5A0 */ public Vector4f AABBMin;
        /* 0x5B0 */ public Vector4f AABBMax;
        /* 0x5C0 */ public bool BuildingSizeCalculated;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x5C1 */ public byte[] Padding5C1;
    }
}
