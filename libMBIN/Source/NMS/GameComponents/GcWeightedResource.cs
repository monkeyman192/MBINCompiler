using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40EF411E62BDB6FB, NameHash = 0x701157823082E732)]
    public class GcWeightedResource : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource Geometry;
        [NMS(Index = 0)]
        /* 0x84 */ public float RelativeProbability;
    }
}
