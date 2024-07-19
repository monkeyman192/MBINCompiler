using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC9D095DC3122CBD, NameHash = 0x1890966F)]
    public class GcWeightedResource : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource Geometry;
        [NMS(Index = 0)]
        /* 0x18 */ public float RelativeProbability;
    }
}
