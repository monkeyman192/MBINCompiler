namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75A93196F0108155, NameHash = 0x7913CBE7)]
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
