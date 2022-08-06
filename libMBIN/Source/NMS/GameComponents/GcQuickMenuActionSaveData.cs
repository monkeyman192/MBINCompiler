using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF7156C5EF401FB8, NameHash = 0x15BEBD4BD6DD1244)]
    public class GcQuickMenuActionSaveData : NMSTemplate
    {
        /* 0x00 */ public GcQuickMenuActions Action;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Number;
        /* 0x1C */ public GcInventoryIndex InventoryIndex;
    }
}
