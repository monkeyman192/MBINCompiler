using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE15817B1A2DF340C, NameHash = 0x66A921119DC2BE37)]
    public class GcProductToCollect : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Product;
        /* 0x10 */ public int Amount;
    }
}
