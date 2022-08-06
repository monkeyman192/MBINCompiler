using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5EEEBBA0A1B82EEC, NameHash = 0xB76095BD04FCB5D2)]
    public class GcExpeditionPowerup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ProductId;
        /* 0x10 */ public GcFrigateStatType StatModified;
        /* 0x14 */ public int ValueChange;
        /* 0x18 */ public NMSString0x20A SelectionDescription;
        /* 0x38 */ public NMSString0x20A ModuleDescription;
    }
}
