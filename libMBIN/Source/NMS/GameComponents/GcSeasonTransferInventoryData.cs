using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1C3F8BF3D644556, NameHash = 0x1C02B7BE)]
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
