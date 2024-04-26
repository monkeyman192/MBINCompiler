using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2BE017BD772861E, NameHash = 0x6A104C45E1F1638D)]
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
