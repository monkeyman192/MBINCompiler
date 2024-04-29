using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1AFC32A77A6AC47B, NameHash = 0x6A104C45E1F1638D)]
    public class GcModBasePart : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcProductData ProductData;
        [NMS(Index = 2)]
        /* 0x410 */ public GcBaseBuildingEntry PartData;
        [NMS(Index = 0)]
        /* 0x6A8 */ public NMSString0x40 ID;
    }
}
