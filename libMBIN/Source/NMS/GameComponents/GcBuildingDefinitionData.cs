using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x5A5DC054BAA9EE34, NameHash = 0x59A43238181BB69F)]
    public class GcBuildingDefinitionData : NMSTemplate
    {
        /* 0x00 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x08 */ public GcBuildingClusterPlacement BuildingClusterPlacement;
        /* 0x0C */ public bool AddWaypoint;
        /* 0x0D */ public bool AddShelter;
        /* 0x0E */ public bool AddLandingPad;
        [NMS(Size = 6, EnumType = typeof(GcBuildingDensityLevels.BuildingDensityEnum))]
        /* 0x10 */ public float[] Density;
        /* 0x28 */ public int NumOverridesToGenerate;
        /* 0x2C */ public int NumModelsToGenerate;
        /* 0x30 */ public NMSString0x20 TextureNameHint;
        /* 0x50 */ public float OverrideRadius;
        /* 0x54 */ public bool GivesShelter;
        /* 0x58 */ public float MinHeight;
        /* 0x5C */ public float MaxHeight;
    }
}
