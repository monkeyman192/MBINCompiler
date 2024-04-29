using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DC741F6F7713554, NameHash = 0xE386FFCF32C92476)]
    public class GcSeasonTransferInventoryData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcInventoryContainer Inventory;
        [NMS(Index = 1)]
        /* 0x158 */ public GcInventoryLayout Layout;
        [NMS(Index = 0)]
        /* 0x170 */ public int SeasonId;
    }
}
