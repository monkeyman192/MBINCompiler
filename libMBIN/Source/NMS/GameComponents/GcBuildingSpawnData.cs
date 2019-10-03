using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5D0, GUID = 0xA735660F276BFF60, NameHash = 0x2FE28DE7841506AF)]
    public class GcBuildingSpawnData : NMSTemplate
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
        /* 0x578 */ public GcBuildingClassification Classification;
        /* 0x57C */ public GcBuildingClusterPlacement Placement;
        /* 0x580 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x588 */ public bool AddWaypoint;
        /* 0x589 */ public bool AddShelter;
        /* 0x58A */ public bool AddLandingPad;
        /* 0x58B */ public bool GivesShelter;
        /* 0x58C */ public bool AlignToNormal;
        /* 0x58D */ public bool LowerIntoGround;
        /* 0x590 */ public float Scale;
        /* 0x594 */ public float MaxXZRotation;
        /* 0x598 */ public float Radius;
        /* 0x59C */ public int InstanceID;
        /* 0x5A0 */ public Vector3f AABBMin;
        /* 0x5B0 */ public Vector3f AABBMax;
        /* 0x5C0 */ public bool BuildingSizeCalculated;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x5C1 */ public byte[] Padding5C1;
    }
}
