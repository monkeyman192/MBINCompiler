using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB494E0BC39DE9C14, NameHash = 0x2AF78E5732410B4F)]
    public class GcMultitoolData : NMSTemplate
    {
        /* 0x000 */ public GcInventoryLayout Layout;
        /* 0x020 */ public GcInventoryContainer Store;
        /* 0x180 */ public GcSeed Seed;
        /* 0x190 */ public NMSString0x20 Name;
        /* 0x1B0 */ public bool IsLarge;
        /* 0x1B4 */ public int PrimaryMode;
        /* 0x1B8 */ public int SecondaryMode;
        /* 0x1BC */ public bool UseLegacyColours;
        /* 0x1C0 */ public GcResourceElement Resource;
    }
}
