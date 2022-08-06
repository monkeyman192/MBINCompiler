using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4B6854809C3423C, NameHash = 0x10BF10453E33157C)]
    public class GcMissionSequenceWaitForFactionStanding : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcFactionSelectOptions SelectFrom;
        /* 0x88 */ public int AmountMin;
        /* 0x8C */ public int AmountMax;
        /* 0x90 */ public NMSString0x80 DebugText;
    }
}
