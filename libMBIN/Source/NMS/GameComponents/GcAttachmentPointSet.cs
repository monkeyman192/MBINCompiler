using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5DBBE772BEDA04, NameHash = 0x762F430C6C191529)]
    public class GcAttachmentPointSet : NMSTemplate
    {
        /* 0x00 */ public List<GcAttachmentPointData> FixedPoints;
        /* 0x10 */ public NMSString0x40 BoneName;
        /* 0x50 */ public NMSString0x40 DebugName;
        /* 0x90 */ public bool Enabled;
    }
}
