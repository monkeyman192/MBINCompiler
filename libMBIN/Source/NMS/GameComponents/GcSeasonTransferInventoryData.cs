using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CB4538036FB3C3B, NameHash = 0xE386FFCF32C92476)]
    public class GcSeasonTransferInventoryData : NMSTemplate
    {
        /* 0x000 */ public GcInventoryContainer Inventory;
        /* 0x158 */ public GcInventoryLayout Layout;
        /* 0x170 */ public int SeasonId;
    }
}
