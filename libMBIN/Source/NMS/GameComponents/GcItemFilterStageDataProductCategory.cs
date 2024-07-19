using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BFC84065753FA3B, NameHash = 0xB827B7BC)]
    public class GcItemFilterStageDataProductCategory : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A DisabledMessage;
        [NMS(Index = 1)]
        /* 0x20 */ public GcProductCategory Category;
    }
}
