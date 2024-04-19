using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x679339A701CBDB74, NameHash = 0x49FD8C968D7B338D)]
    public class GcUniverseAddressData : NMSTemplate
    {
        /* 0x00 */ public GcGalacticAddressData GalacticAddress;
        /* 0x14 */ public int RealityIndex;
    }
}
