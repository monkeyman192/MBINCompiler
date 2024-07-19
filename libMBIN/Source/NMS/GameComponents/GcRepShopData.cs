using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FC91197628587AC, NameHash = 0xEB5FD087)]
    public class GcRepShopData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcRepShopDonation> DonatableItems;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcRepShopItem> RepItems;
    }
}
