using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22837E0EE2B85563, NameHash = 0x59A43238181BB69F)]
    public class GcBuildingDefinitionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A TextureNameHint;
        /* 0x20 */ public NMSString0x10 ClusterLayout;
        [NMS(Size = 0x6, EnumType = typeof(GcBuildingDensityLevels.BuildingDensityEnum))]
        /* 0x30 */ public float[] Density;
        /* 0x48 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x50 */ public float ClusterSpacing;
        /* 0x54 */ public float MaxHeight;
        /* 0x58 */ public float MinHeight;
        /* 0x5C */ public int NumModelsToGenerate;
        /* 0x60 */ public int NumOverridesToGenerate;
        /* 0x64 */ public float OverrideRadius;
        /* 0x68 */ public GcPlanetaryBuildingRestrictions PlanetRestrictions;
        /* 0x6A */ public bool EnabledWhenPlanetHasNoNPCs;
        /* 0x6B */ public bool GivesShelter;
        /* 0x6C */ public bool IgnoreParticlesInAABB;
    }
}
