using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B2DB3B7FBBD9982, NameHash = 0x59A43238181BB69F)]
    public class GcBuildingDefinitionData : NMSTemplate
    {
        /* 0x00 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x08 */ public NMSString0x10 ClusterLayout;
        /* 0x18 */ public float ClusterSpacing;
        [NMS(Size = 0x6, EnumType = typeof(GcBuildingDensityLevels.BuildingDensityEnum))]
        /* 0x1C */ public float[] Density;
        /* 0x34 */ public bool EnabledWhenPlanetHasNoNPCs;
        /* 0x38 */ public int NumOverridesToGenerate;
        /* 0x3C */ public int NumModelsToGenerate;
        /* 0x40 */ public NMSString0x20A TextureNameHint;
        /* 0x60 */ public float OverrideRadius;
        /* 0x64 */ public bool GivesShelter;
        /* 0x68 */ public float MinHeight;
        /* 0x6C */ public float MaxHeight;
    }
}
