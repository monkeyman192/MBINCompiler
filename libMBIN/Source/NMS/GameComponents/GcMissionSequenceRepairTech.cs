using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAAAA27F013B205A, NameHash = 0xF83A832D3507037F)]
    public class GcMissionSequenceRepairTech : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public List<NMSString0x10> TechsToRepair;
        /* 0x90 */ public NMSString0x80 DebugText;
    }
}
