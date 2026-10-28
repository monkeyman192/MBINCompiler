using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31FE92F62074FDC, NameHash = 0xEE9DB27A)]
    public class GcModBasePart : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcProductData ProductData;
        [NMS(Index = 2)]
        /* 0x300 */ public GcBaseBuildingEntry PartData;
        [NMS(Index = 0)]
        /* 0x5B8 */ public NMSString0x40 ID;
    }
}
