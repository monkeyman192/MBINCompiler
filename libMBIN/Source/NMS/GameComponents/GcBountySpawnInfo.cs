using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25794F3AEF274B3C, NameHash = 0x39C7A4F372F6707C)]
    public class GcBountySpawnInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public GcAIShipSpawnData Data;
        /* 0x1B8 */ public NMSString0x10 AttackData;
        /* 0x1C8 */ public TkTextureResource Icon;
        /* 0x250 */ public NMSString0x20A Label;
    }
}
