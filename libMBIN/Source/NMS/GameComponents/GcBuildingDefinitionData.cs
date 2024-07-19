using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB3F6E2E9F3DE03D, NameHash = 0x15C14AC1)]
    public class GcBuildingDefinitionData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public NMSString0x20A TextureNameHint;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 ClusterLayout;
        [NMS(Index = 3, Size = 0x6, EnumType = typeof(GcBuildingDensityLevels.BuildingDensityEnum))]
        /* 0x30 */ public float[] Density;
        [NMS(Index = 0)]
        /* 0x48 */ public TkNoiseFlattenOptions FlattenType;
        [NMS(Index = 2)]
        /* 0x50 */ public float ClusterSpacing;
        [NMS(Index = 11)]
        /* 0x54 */ public float MaxHeight;
        [NMS(Index = 10)]
        /* 0x58 */ public float MinHeight;
        [NMS(Index = 6)]
        /* 0x5C */ public int NumModelsToGenerate;
        [NMS(Index = 5)]
        /* 0x60 */ public int NumOverridesToGenerate;
        [NMS(Index = 8)]
        /* 0x64 */ public float OverrideRadius;
        [NMS(Index = 12)]
        /* 0x68 */ public GcPlanetaryBuildingRestrictions PlanetRestrictions;
        [NMS(Index = 4)]
        /* 0x6A */ public bool EnabledWhenPlanetHasNoNPCs;
        [NMS(Index = 9)]
        /* 0x6B */ public bool GivesShelter;
        [NMS(Index = 13)]
        /* 0x6C */ public bool IgnoreParticlesInAABB;
    }
}
