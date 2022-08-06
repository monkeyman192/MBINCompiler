using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85D6D1DF15C3A811, NameHash = 0x01D21D52DD72961C)]
    public class GcRewardActivateEncounterSentinels : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A EncounterComponentScanEvent;
        /* 0x20 */ public NMSString0x10 EncounterOverride;
    }
}
