using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2990BF8415EA9388, NameHash = 0x36E137A2EA118340)]
    public class GcRegionHotspotData : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x00 */ public float[] ClassStrengths;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x10 */ public float[] ClassWeightings;
        /* 0x20 */ public float DiscoveryDistanceThreshold;
        /* 0x24 */ public float MaxRange;
        /* 0x28 */ public float MinRange;
        /* 0x2C */ public float ProbabilityWeighting;
    }
}
