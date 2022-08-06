using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x039548BFD7D9BDE3, NameHash = 0xBA68F4D576FCF49E)]
    public class GcInventoryTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int MinSize;
        /* 0x14 */ public int MaxSize;
        /* 0x18 */ public GcInventoryLayoutSizeType LayoutSizeType;
    }
}
