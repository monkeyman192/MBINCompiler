using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E0443E098D863FF, NameHash = 0xB60FC5C97CF2713E)]
    public class GcRepShopData : NMSTemplate
    {
        /* 0x00 */ public List<GcRepShopDonation> DonatableItems;
        /* 0x10 */ public List<GcRepShopItem> RepItems;
    }
}
