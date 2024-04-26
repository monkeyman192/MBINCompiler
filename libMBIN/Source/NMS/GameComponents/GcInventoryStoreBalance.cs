namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF6181D1BC4CEE7B, NameHash = 0x950617F05949472B)]
    public class GcInventoryStoreBalance : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public float DeconstructRefundPercentage;
        [NMS(Index = 3)]
        /* 0x04 */ public int PlayerPersonalInventoryCargoHeight;
        [NMS(Index = 2)]
        /* 0x08 */ public int PlayerPersonalInventoryCargoWidth;
        [NMS(Index = 1)]
        /* 0x0C */ public int PlayerPersonalInventoryTechHeight;
        [NMS(Index = 0)]
        /* 0x10 */ public int PlayerPersonalInventoryTechWidth;
    }
}
