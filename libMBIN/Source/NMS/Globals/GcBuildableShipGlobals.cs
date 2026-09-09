using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x78CA0524AF31AD2E, NameHash = 0xCA24B3F1)]
    public class GcBuildableShipGlobals : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcRewardSpecificShip DefaultCorvette;
        [NMS(Index = 0, Size = 0xE, EnumType = typeof(GcCorvettePartCategory.CorvettePartCategoryEnum))]
        /* 0x250 */ public NMSString0x20A[] PartTagLocIDs;
        [NMS(Index = 3)]
        /* 0x410 */ public List<GcFilename> InitialLayouts;
        [NMS(Index = 1, Size = 0xE, EnumType = typeof(GcCorvettePartCategory.CorvettePartCategoryEnum))]
        /* 0x420 */ public int[] PartFXLimits;
        // size: 0x4
        public enum InteriorVisibilityDistanceEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 6, Size = 0x4, EnumType = typeof(InteriorVisibilityDistanceEnum))]
        /* 0x458 */ public float[] InteriorVisibilityDistance;
        [NMS(Index = 5)]
        /* 0x468 */ public int ComplexityLimitWarning;
        [NMS(Index = 4)]
        /* 0x46C */ public int ComplexityLimitWarningNX;
        [NMS(Index = 7)]
        /* 0x470 */ public float SpawnOnRemoteCorvetteRequiredPartsRenderingDistance;
    }
}
