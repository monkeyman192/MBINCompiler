using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81784D5DF3940199, NameHash = 0x1C02B7BE)]
    public class GcSeasonTransferInventoryData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcInventoryContainer Inventory;
        [NMS(Index = 1)]
        /* 0x160 */ public GcInventoryLayout Layout;
        [NMS(Index = 0)]
        /* 0x178 */ public int SeasonId;
    }
}
