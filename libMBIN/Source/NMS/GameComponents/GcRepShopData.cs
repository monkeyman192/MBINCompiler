using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC323DAF7E983B5BB, NameHash = 0xB60FC5C97CF2713E)]
    public class GcRepShopData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcRepShopDonation> DonatableItems;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcRepShopItem> RepItems;
    }
}
