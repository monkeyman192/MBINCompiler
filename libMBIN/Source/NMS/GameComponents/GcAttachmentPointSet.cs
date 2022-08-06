using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6CCE14818D16BC6, NameHash = 0x762F430C6C191529)]
    public class GcAttachmentPointSet : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x40 DebugName;
        /* 0x41 */ public NMSString0x40 BoneName;
        /* 0x88 */ public List<GcAttachmentPointData> FixedPoints;
    }
}
