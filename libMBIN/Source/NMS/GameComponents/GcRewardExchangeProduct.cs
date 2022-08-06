using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE722BF470BB5E3FE, NameHash = 0x2F9B8F940B001C76)]
    public class GcRewardExchangeProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 IDToGive;
        /* 0x10 */ public NMSString0x10 IDToTake;
        /* 0x20 */ public int AmountToGiveMin;
        /* 0x24 */ public int AmountToGiveMax;
        /* 0x28 */ public int AmountToTakeMax;
        /* 0x2C */ public bool HideNewProduct;
        /* 0x2D */ public bool ForceSpecialMessage;
    }
}
