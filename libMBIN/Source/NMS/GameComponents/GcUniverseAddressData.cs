using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94C6ECCF945412BF, NameHash = 0x3AB38D4F)]
    public class GcUniverseAddressData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcGalacticAddressData GalacticAddress;
        [NMS(Index = 0)]
        /* 0x14 */ public int RealityIndex;
    }
}
