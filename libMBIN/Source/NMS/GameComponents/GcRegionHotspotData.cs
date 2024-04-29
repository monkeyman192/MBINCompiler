using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C4D33DC13A41124, NameHash = 0x36E137A2EA118340)]
    public class GcRegionHotspotData : NMSTemplate
    {
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x00 */ public float[] ClassStrengths;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x10 */ public float[] ClassWeightings;
        [NMS(Index = 5)]
        /* 0x20 */ public float DiscoveryDistanceThreshold;
        [NMS(Index = 2)]
        /* 0x24 */ public float MaxRange;
        [NMS(Index = 1)]
        /* 0x28 */ public float MinRange;
        [NMS(Index = 0)]
        /* 0x2C */ public float ProbabilityWeighting;
    }
}
