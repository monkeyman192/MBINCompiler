using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1FAE54E8E761AA6, NameHash = 0x97DBB6FC681295D3)]
    public class GcDialogClearanceInfo : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A GlobalDialogID;
        /* 0x20 */ public NMSString0x10 AssociatedMission;
    }
}
